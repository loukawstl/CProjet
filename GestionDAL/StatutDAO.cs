using GestionBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDAL
{
    public class StatutDAO
    {
        private static StatutDAO unStatutDAO;

        // Accesseur en lecture, renvoi une instance
        public static StatutDAO GetunStatutDAO()
        {
            if (unStatutDAO == null)
            {
                unStatutDAO = new StatutDAO();
            }
            return unStatutDAO;
        }

        // Cette méthode retourne une List contenant les objets Utilisateurs contenus dans la table produit : VIEW

        public static List<Statut> GetStatut()
        {
            int code;
            string libelle;

            Statut unStatut;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Produit
            List<Statut> lesStatuts = new List<Statut>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT * FROM statut";
            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                code = Int32.Parse(monReader["code_statut"].ToString());
                libelle = monReader["libelle_statut"].ToString();

                unStatut = new Statut(code, libelle);
                lesStatuts.Add(unStatut);
            }

            // Fermeture de la connexion
            maConnexion.Close();
            return lesStatuts;
        }

        public static int GetCodeStatut(string libelle)
        {
            int code;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = "SELECT code_statut AS statut FROM statut WHERE libelle_statut = @libelle";

            cmd.Parameters.Add(new SqlParameter("@libelle", System.Data.SqlDbType.NVarChar, 255));
            cmd.Parameters["@libelle"].Value = libelle;

            //reader
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            code = (int)reader["statut"];
            reader.Close();

            // Fermeture de la connexion
            maConnexion.Close();

            code = code - 1;

            return code;
        }

        // Cette méthode insert un nouveau produit passé en paramètre dans la BD
        public static int AjoutStatut(Statut unStatut)
        {
            int nbEnr;

            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;

            cmd.CommandText = "INSERT INTO statut values (@libelle)";
            cmd.Parameters.Add(new SqlParameter("@libelle", System.Data.SqlDbType.NVarChar, 255));
            cmd.Parameters["@libelle"].Value = unStatut.Libelle;

            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
    }
}
