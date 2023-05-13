using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using GestionBO;

namespace GestionDAL
{
    public class ContenirDAO
    {
        private static ContenirDAO unContenirDAO;

        // Accesseur en lecture, renvoi une instance
        public static ContenirDAO GetunContenirDAO()
        {
            if (unContenirDAO == null)
            {
                unContenirDAO = new ContenirDAO();
            }
            return unContenirDAO;
        }

        // Cette méthode retourne une List contenant les objets Utilisateurs contenus dans la table produit : VIEW

        public static List<Contenir> GetContenir(int code_devis)
        {
            int quantite;
            float remise;

            DateTime date_devis;
            float taux_tva_devis;

            int code_produit;
            string libelle_produit;
            float prix_produit;

            int code_categorie;
            string libelle_categorie;

            int code_statut;
            string libelle_statut;

            int code_client;
            string nom_client;
            string prenom_client;
            string rue_facturation_client;
            string cp_facturation_client;
            string ville_facturation_client;
            string rue_livraison_client;
            string cp_livraison_client;
            string ville_livraison_client;
            string telephone_client;
            string fax_client;
            string email_client;


            Client unClient;
            Statut unStatut;
            Contenir unConteneur;
            Devis unDevis;
            Produit unProduit;
            Categorie uneCategorie;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Produit
            List<Contenir> lesConteneurs = new List<Contenir>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM informations WHERE code_devis = " + code_devis;
            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                code_produit = Int32.Parse(monReader["code_produit"].ToString());
                quantite = Int32.Parse(monReader["quantite"].ToString());
                remise = float.Parse(monReader["remise"].ToString());

                date_devis = DateTime.Parse(monReader["date_devis"].ToString());
                taux_tva_devis = float.Parse(monReader["remise"].ToString());

                libelle_produit = monReader["libelle_produit"].ToString();
                prix_produit = float.Parse(monReader["prix_vente_ht_produit"].ToString());

                code_categorie = Int32.Parse(monReader["code_categorie"].ToString());
                libelle_categorie = monReader["libelle_categorie"].ToString();

                code_statut = Int32.Parse(monReader["code_statut"].ToString());
                libelle_statut = monReader["libelle_statut"].ToString();

                code_client = Int32.Parse(monReader["code_client"].ToString());
                nom_client = monReader["nom_client"].ToString();
                prenom_client = monReader["prenom_client"].ToString();
                rue_facturation_client = monReader["rue_facturation_client"].ToString();
                cp_facturation_client = monReader["cp_facturation_client"].ToString();
                ville_facturation_client = monReader["ville_facturation_client"].ToString();
                rue_livraison_client = monReader["rue_livraison_client"].ToString();
                cp_livraison_client = monReader["cp_livraison_client"].ToString();
                ville_livraison_client = monReader["ville_livraison_client"].ToString();
                telephone_client = monReader["telephone_client"].ToString();
                fax_client = monReader["fax_client"].ToString();
                email_client = monReader["email_client"].ToString();


                unClient = new Client(code_client, nom_client, prenom_client,
                    rue_facturation_client, cp_facturation_client, ville_facturation_client,
                    rue_livraison_client, cp_livraison_client, ville_livraison_client,
                    telephone_client, fax_client, email_client);

                uneCategorie = new Categorie(code_categorie, libelle_categorie);

                unStatut = new Statut(code_statut, libelle_statut);

                unProduit = new Produit(code_produit, libelle_produit, prix_produit, uneCategorie);

                unDevis = new Devis(code_devis, date_devis, taux_tva_devis, unClient, unStatut);

                unConteneur = new Contenir(unDevis, unProduit, quantite, remise);

                lesConteneurs.Add(unConteneur);
            }

            // Fermeture de la connexion
            maConnexion.Close();
            return lesConteneurs;
        }

        public static int AjoutContenir(Contenir con)
        {
            int nbEnr;

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = "INSERT INTO contenir VALUES (@codeDev, @codePro, @qte, @remise)";

            cmd.Parameters.Add(new SqlParameter("@codeDev", System.Data.SqlDbType.Int, 255));
            cmd.Parameters["@codeDev"].Value = con.Devis.Code;

            cmd.Parameters.Add(new SqlParameter("@codePro", System.Data.SqlDbType.Int));
            cmd.Parameters["@codePro"].Value = con.Produit.Code;

            cmd.Parameters.Add(new SqlParameter("@qte", System.Data.SqlDbType.Int));
            cmd.Parameters["@qte"].Value = con.Quantite;

            cmd.Parameters.Add(new SqlParameter("@remise", System.Data.SqlDbType.Int));
            cmd.Parameters["@remise"].Value = con.Remise;

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        public static int UpdateContenir(Contenir con)
        {
            int nbEnr;

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = "UPDATE contenir set quantite = @qte, remise = @remise " +
                "WHERE code_devis = @codeDev " +
                "AND code_produit = @codePro";
            cmd.Parameters.Add(new SqlParameter("@codeDev", System.Data.SqlDbType.Int, 255));
            cmd.Parameters["@codeDev"].Value = con.Devis.Code;

            cmd.Parameters.Add(new SqlParameter("@codePro", System.Data.SqlDbType.Int));
            cmd.Parameters["@codePro"].Value = con.Produit.Code;

            cmd.Parameters.Add(new SqlParameter("@qte", System.Data.SqlDbType.Int));
            cmd.Parameters["@qte"].Value = con.Quantite;

            cmd.Parameters.Add(new SqlParameter("@remise", System.Data.SqlDbType.Int));
            cmd.Parameters["@remise"].Value = con.Remise;

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        public static int DeleteContenir(int code_devis, int code_produit)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM contenir " +
                "WHERE code_devis = @codeDev " +
                "AND code_produit = @codePro";

            cmd.Parameters.Add(new SqlParameter("@codeDev", System.Data.SqlDbType.Int, 255));
            cmd.Parameters["@codeDev"].Value = code_devis;

            cmd.Parameters.Add(new SqlParameter("@codePro", System.Data.SqlDbType.Int));
            cmd.Parameters["@codePro"].Value = code_produit;

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
    }
}
