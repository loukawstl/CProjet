using GestionBO;
using System.Data.SqlClient;
using System.Net.Sockets;

namespace GestionDAL
{
    public class ClientDAO
    {
        private static ClientDAO unClientDAO;

        // Accesseur en lecture, renvoi une instance
        public static ClientDAO GetunClientDAO()
        {
            if (unClientDAO == null)
            {
                unClientDAO = new ClientDAO();
            }
            return unClientDAO;
        }

        public static List<Client> GetClient()
        {
            int code;
            string nom;
            string prenom;
            string rue_facturation;
            string cp_facturation;
            string ville_facturation;
            string rue_livraison;
            string cp_livraison;
            string ville_livraison;
            string telephone;
            string fax;
            string email;

            Client unClient;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Client
            List<Client> lesClients = new List<Client>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT * FROM client";
            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                code = Int32.Parse(monReader["code_client"].ToString());
                nom = monReader["nom_client"].ToString();
                prenom = monReader["prenom_client"].ToString();
                rue_facturation = monReader["rue_facturation_client"].ToString();
                cp_facturation = monReader["cp_facturation_client"].ToString();
                ville_facturation = monReader["ville_facturation_client"].ToString();
                rue_livraison = monReader["rue_livraison_client"].ToString();
                cp_livraison = monReader["cp_livraison_client"].ToString();
                ville_livraison = monReader["ville_livraison_client"].ToString();
                telephone = monReader["telephone_client"].ToString();
                fax = monReader["fax_client"].ToString();
                email = monReader["email_client"].ToString();


                unClient = new Client(code, nom, prenom, rue_facturation, cp_facturation,
                    ville_facturation, rue_livraison, cp_livraison, ville_livraison,
                    telephone, fax, email);
                getDevisClient(unClient);
                lesClients.Add(unClient);
            }

            // Fermeture de la connexion
            maConnexion.Close();
            return lesClients;
        }

        public static int GetCodeClient(string nom)
        {
            int code;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = "SELECT code_client AS client FROM client WHERE nom_client = @nom";

            cmd.Parameters.Add(new SqlParameter("@nom", System.Data.SqlDbType.NVarChar, 255));
            cmd.Parameters["@nom"].Value = nom;

            //reader
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            code = (int)reader["client"];
            reader.Close();

            // Fermeture de la connexion
            maConnexion.Close();

            return code;
        }

        // Cette méthode modifie un utilisateur passé en paramètre dans la BD
        public static int UpdateClient(Client unClient)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE client SET nom_client = @nom," +
                "prenom_client = @prenom," +
                "rue_facturation_client = @rueFactu," +
                "cp_facturation_client = @cpFacturation," +
                "ville_facturation_client = @villeFacturation," +
                "rue_livraison_client = @rueLivraison," +
                "cp_livraison_client = @cpLivraison," +
                "ville_livraison_client = @villeLivraison," +
                "telephone_client = @telephone," +
                "fax_client = @fax," +
                "email_client = @email " +
                "WHERE code_client = @codeClient";

            cmd.Parameters.Add(new SqlParameter("@nom", System.Data.SqlDbType.NVarChar, 255));
            cmd.Parameters["@nom"].Value = unClient.Nom;

            cmd.Parameters.Add(new SqlParameter("@prenom", System.Data.SqlDbType.NVarChar, 255));
            cmd.Parameters["@prenom"].Value = unClient.Prenom;

            cmd.Parameters.Add(new SqlParameter("@rueFactu", System.Data.SqlDbType.NVarChar, 255));
            cmd.Parameters["@rueFactu"].Value = unClient.Rue_facturation;

            cmd.Parameters.Add(new SqlParameter("@cpFacturation", System.Data.SqlDbType.NVarChar, 5));
            cmd.Parameters["@cpFacturation"].Value = unClient.Cp_facturation;

            cmd.Parameters.Add(new SqlParameter("@villeFacturation", System.Data.SqlDbType.NVarChar, 255));
            cmd.Parameters["@villeFacturation"].Value = unClient.Ville_facturation;

            cmd.Parameters.Add(new SqlParameter("@rueLivraison", System.Data.SqlDbType.NVarChar, 255));
            cmd.Parameters["@rueLivraison"].Value = unClient.Rue_livraison;

            cmd.Parameters.Add(new SqlParameter("@cpLivraison", System.Data.SqlDbType.NVarChar, 5));
            cmd.Parameters["@cpLivraison"].Value = unClient.Cp_livraison;

            cmd.Parameters.Add(new SqlParameter("@villeLivraison", System.Data.SqlDbType.NVarChar, 255));
            cmd.Parameters["@villeLivraison"].Value = unClient.Ville_livraison;

            cmd.Parameters.Add(new SqlParameter("@telephone", System.Data.SqlDbType.NVarChar, 15));
            cmd.Parameters["@telephone"].Value = unClient.Telephone;

            cmd.Parameters.Add(new SqlParameter("@fax", System.Data.SqlDbType.NVarChar, 15));
            cmd.Parameters["@fax"].Value = unClient.Fax;

            cmd.Parameters.Add(new SqlParameter("@email", System.Data.SqlDbType.NVarChar, 255));
            cmd.Parameters["@email"].Value = unClient.Email;

            cmd.Parameters.Add(new SqlParameter("@codeClient", System.Data.SqlDbType.Int));
            cmd.Parameters["@codeClient"].Value = unClient.Code;

            cmd.Connection = maConnexion;

            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        public static int AddClient(Client unClient)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO client VALUES (@nom," +
                "@prenom," +
                "@rueFactu," +
                "@cpFacturation," +
                "@villeFacturation," +
                "@rueLivraison," +
                "@cpLivraison," +
                "@villeLivraison," +
                "@telephone," +
                "@fax," +
                "@email)";

            cmd.Parameters.Add(new SqlParameter("@nom", System.Data.SqlDbType.NVarChar, 255));
            cmd.Parameters["@nom"].Value = unClient.Nom;

            cmd.Parameters.Add(new SqlParameter("@prenom", System.Data.SqlDbType.NVarChar, 255));
            cmd.Parameters["@prenom"].Value = unClient.Prenom;

            cmd.Parameters.Add(new SqlParameter("@rueFactu", System.Data.SqlDbType.NVarChar, 255));
            cmd.Parameters["@rueFactu"].Value = unClient.Rue_facturation;

            cmd.Parameters.Add(new SqlParameter("@cpFacturation", System.Data.SqlDbType.NVarChar, 5));
            cmd.Parameters["@cpFacturation"].Value = unClient.Cp_facturation;

            cmd.Parameters.Add(new SqlParameter("@villeFacturation", System.Data.SqlDbType.NVarChar, 255));
            cmd.Parameters["@villeFacturation"].Value = unClient.Ville_facturation;

            cmd.Parameters.Add(new SqlParameter("@rueLivraison", System.Data.SqlDbType.NVarChar, 255));
            cmd.Parameters["@rueLivraison"].Value = unClient.Rue_livraison;

            cmd.Parameters.Add(new SqlParameter("@cpLivraison", System.Data.SqlDbType.NVarChar, 5));
            cmd.Parameters["@cpLivraison"].Value = unClient.Cp_livraison;

            cmd.Parameters.Add(new SqlParameter("@villeLivraison", System.Data.SqlDbType.NVarChar, 255));
            cmd.Parameters["@villeLivraison"].Value = unClient.Ville_livraison;

            cmd.Parameters.Add(new SqlParameter("@telephone", System.Data.SqlDbType.NVarChar, 15));
            cmd.Parameters["@telephone"].Value = unClient.Telephone;

            cmd.Parameters.Add(new SqlParameter("@fax", System.Data.SqlDbType.NVarChar, 15));
            cmd.Parameters["@fax"].Value = unClient.Fax;

            cmd.Parameters.Add(new SqlParameter("@email", System.Data.SqlDbType.NVarChar, 255));
            cmd.Parameters["@email"].Value = unClient.Email;

            cmd.Connection = maConnexion;

            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        public static int DeleteClient(int id)
        {
            int exec, nombre, nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT count(*) as nbDevis FROM devis WHERE code_client = " + id;
            exec = cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            nombre = (int)reader["nbDevis"];
            reader.Close();
            if (nombre > 0)
            {
                nbEnr = 0;

            }
            else
            {
                cmd.CommandText = "DELETE FROM client WHERE code_client = " + id;
                nbEnr = cmd.ExecuteNonQuery();
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        public static void getDevisClient(Client cli)
        {
            int exec;

            int code;
            DateTime date;
            float taux_tva;

            int code_client;
            string nom_client;
            string prenom_client;
            string rue_fact_client;
            string cp_fact_client;
            string ville_fact_client;
            string rue_liv_client;
            string cp_liv_client;
            string ville_liv_client;
            string telephone_client;
            string fax_client;
            string email_client;
            Client codeClient;

            int code_statut;
            string lib_statut;
            Statut codeStatut;

            Devis unDevis;

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM devis, statut WHERE code_client = @code_devis AND devis.code_statut = statut.code_statut";

            cmd.Parameters.Add(new SqlParameter("@code_devis", System.Data.SqlDbType.Int));
            cmd.Parameters["@code_devis"].Value = cli.Code;

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                code = Int32.Parse(monReader["code_devis"].ToString());
                date = DateTime.Parse(monReader["date_devis"].ToString());
                taux_tva = float.Parse(monReader["taux_tva_devis"].ToString());

                code_statut = Int32.Parse(monReader["code_statut"].ToString());
                lib_statut = monReader["libelle_statut"].ToString();

                unDevis = new Devis(code, date, taux_tva,
                new Client(0, "", "", "", "", "", "", "", "", "", "", ""),
                new Statut(code_statut, lib_statut));
                cli.addDevis(unDevis);
            }
        }

    }

}