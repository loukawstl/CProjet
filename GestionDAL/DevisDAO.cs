using GestionBO;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Formats.Asn1;

namespace GestionDAL
{
    public class DevisDAO
    {
        private static DevisDAO unDevisDAO;

        // Accesseur en lecture, renvoi une instance
        public static DevisDAO GetunDevisDAO()
        {
            if (unDevisDAO == null)
            {
                unDevisDAO = new DevisDAO();
            }
            return unDevisDAO;
        }

        // Cette méthode retourne une List contenant les objets Utilisateurs contenus dans la table Devis : VIEW

        public static List<Devis> GetDevis()
        {
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

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Produit
            List<Devis> lesDevis = new List<Devis>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT * FROM devis, client, statut " +
                "WHERE devis.code_client = client.code_client " +
                "AND devis.code_statut = statut.code_statut";
            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                code = Int32.Parse(monReader["code_devis"].ToString());
                date = DateTime.Parse(monReader["date_devis"].ToString());
                taux_tva = float.Parse(monReader["taux_tva_devis"].ToString());

                code_client = Int32.Parse(monReader["code_client"].ToString());
                nom_client = monReader["nom_client"].ToString();
                prenom_client = monReader["prenom_client"].ToString();
                rue_fact_client = monReader["rue_facturation_client"].ToString();
                cp_fact_client = monReader["cp_facturation_client"].ToString();
                ville_fact_client = monReader["ville_facturation_client"].ToString();
                rue_liv_client = monReader["rue_livraison_client"].ToString();
                cp_liv_client = monReader["cp_livraison_client"].ToString();
                ville_liv_client = monReader["ville_livraison_client"].ToString();
                telephone_client = monReader["telephone_client"].ToString();
                fax_client = monReader["fax_client"].ToString();
                email_client = monReader["email_client"].ToString();

                code_statut = Int32.Parse(monReader["code_statut"].ToString());
                lib_statut = monReader["libelle_statut"].ToString();

                unDevis = new Devis(code, date, taux_tva,
                new Client(code_client, nom_client, prenom_client,
                rue_fact_client, cp_fact_client, ville_fact_client,
                rue_liv_client, cp_liv_client, ville_liv_client,
                telephone_client, fax_client, email_client),
                new Statut (code_statut, lib_statut));
                lesDevis.Add(unDevis);
            }

            // Fermeture de la connexion
            maConnexion.Close();
            return lesDevis;
        }

        public static int GetCodeDevis(DateTime date, float txTVA, Client client, Statut statut)
        {
            int code_client = client.Code;
            int code_statut = statut.Code;
            int code_devis;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT code_devis as code_devis FROM devis " +
                "WHERE taux_tva_devis = @taux_tva " +
                "AND code_client = @codeClient " +
                "AND code_statut = @codeStatut";

            //cmd.Parameters.Add(new SqlParameter("@date", System.Data.SqlDbType.DateTime, 255));
            //cmd.Parameters["@date"].Value = date;

            cmd.Parameters.Add(new SqlParameter("@taux_tva", System.Data.SqlDbType.Float));
            cmd.Parameters["@taux_tva"].Value = txTVA;

            cmd.Parameters.Add(new SqlParameter("@codeClient", System.Data.SqlDbType.Int));
            cmd.Parameters["@codeClient"].Value = code_client;

            cmd.Parameters.Add(new SqlParameter("@codeStatut", System.Data.SqlDbType.Int));
            cmd.Parameters["@codeStatut"].Value = code_statut;

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            code_devis = (int)reader["code_devis"];
            reader.Close();

            return code_devis;
        }

        public static int SelectClientDevis(int code)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = "SELECT code_client as cli FROM devis WHERE code_devis = " + code;

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        public static int SelectStatutDevis(int code)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = "SELECT code_statut as sta FROM devis WHERE code_devis = " + code;

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        // Cette méthode insert un nouveau devis passé en paramètre dans la BD
        public static int AjoutDevis(Devis unDevis)
        {
            int nbEnr;

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = "INSERT INTO devis values (@date, @taux_tva, @codeClient, @codeStatut)";
            cmd.Parameters.Add(new SqlParameter("@date", System.Data.SqlDbType.DateTime, 255));
            cmd.Parameters["@date"].Value = unDevis.Date;

            cmd.Parameters.Add(new SqlParameter("@taux_tva", System.Data.SqlDbType.Float));
            cmd.Parameters["@taux_tva"].Value = unDevis.Taux_tva;

            cmd.Parameters.Add(new SqlParameter("@codeClient", System.Data.SqlDbType.Int));
            cmd.Parameters["@codeClient"].Value = unDevis.Client.Code;

            cmd.Parameters.Add(new SqlParameter("@codeStatut", System.Data.SqlDbType.Int));
            cmd.Parameters["@codeStatut"].Value = unDevis.Statut.Code;

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        // Cette méthode modifie un devis passé en paramètre dans la BD
        public static int ModifierDevis(Devis unDevis)
        {
            int nbEnr;

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = "UPDATE devis set date_devis = @date, taux_tva_devis = @taux_tva," +
                "code_client = @codeClient, code_statut = @codeStatut " +
                "WHERE code_devis = @code";
            cmd.Parameters.Add(new SqlParameter("@date", System.Data.SqlDbType.DateTime, 255));
            cmd.Parameters["@date"].Value = unDevis.Date;

            cmd.Parameters.Add(new SqlParameter("@taux_tva", System.Data.SqlDbType.Float));
            cmd.Parameters["@taux_tva"].Value = unDevis.Taux_tva;

            cmd.Parameters.Add(new SqlParameter("@codeClient", System.Data.SqlDbType.Int));
            cmd.Parameters["@codeClient"].Value = unDevis.Client.Code;

            cmd.Parameters.Add(new SqlParameter("@codeStatut", System.Data.SqlDbType.Int));
            cmd.Parameters["@codeStatut"].Value = unDevis.Statut.Code;

            cmd.Parameters.Add(new SqlParameter("@code", System.Data.SqlDbType.Int));
            cmd.Parameters["@code"].Value = unDevis.Code;

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        public static int DeleteDevis(int id)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM contenir WHERE code_devis = " + id;
            nbEnr = cmd.ExecuteNonQuery();
            cmd.CommandText = "DELETE FROM devis WHERE code_devis = " + id;
            nbEnr = cmd.ExecuteNonQuery();
            
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

    }
}
