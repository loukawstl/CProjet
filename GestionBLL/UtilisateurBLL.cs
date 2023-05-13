using GestionDAL;
using GestionBO;
using System.Configuration;

namespace GestionBLL
{
    public class UtilisateurBLL
    {
        private static UtilisateurBLL uneGestionUtilisateurs; // objet BLL

        public static UtilisateurBLL GetGestionUtilisateurs()
        {
            if (uneGestionUtilisateurs == null)
            {
                uneGestionUtilisateurs = new UtilisateurBLL();
            }
            return uneGestionUtilisateurs;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        public static bool verifierConnexion(Utilisateur uti)
        {
            return UtilisateurDAO.checkConnection(uti);
        }
    }
}