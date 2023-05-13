using GestionBO;
using System.Data.SqlClient;

namespace GestionDAL
{
    public class UtilisateurDAO
    {
        private static UtilisateurDAO unUtilisateurDAO;

        public static UtilisateurDAO GetunUtilisateurDAO()
        {
            if (unUtilisateurDAO == null)
            {
                unUtilisateurDAO = new UtilisateurDAO();
            }
            return unUtilisateurDAO;
        }

        public static bool checkConnection(Utilisateur uti)
        {
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM utilisateur WHERE login_utilisateur = @nom and mot_de_passe_utilisateur = @mdp";
            cmd.Parameters.Add(new SqlParameter("@nom", System.Data.SqlDbType.NVarChar, 40));
            cmd.Parameters["@nom"].Value = uti.Nom;
            cmd.Parameters.Add(new SqlParameter("@mdp", System.Data.SqlDbType.NVarChar, 40));
            cmd.Parameters["@mdp"].Value = uti.Password;

            SqlDataReader monReader = cmd.ExecuteReader();
            monReader.Read();

            if (monReader.HasRows)
            {
                int id;
                int.TryParse(monReader["code_utilisateur"].ToString(), out id);
                string nom = monReader["login_utilisateur"].ToString();
                string password = monReader["mot_de_passe_utilisateur"].ToString();
                monReader.Close();

                return true;
            }
            else
            {
                monReader.Close();
                return false;
            }
        }
    }
}