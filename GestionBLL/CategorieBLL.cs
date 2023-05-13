using GestionDAL;
using GestionBO;
using System.Configuration;


namespace GestionBLL
{
    public class CategorieBLL
    {
        private static CategorieBLL uneGestionCategorie; // objet BLL

        // Accesseur en lecture
        public static CategorieBLL GetGestionUtilisateurs()
        {
            if (uneGestionCategorie == null)
            {
                uneGestionCategorie = new CategorieBLL();
            }
            return uneGestionCategorie;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la méthode GetCategorie() de la DAL : VIEW
        public static List<Categorie> GetCategorie()
        {
            return CategorieDAO.GetCategorie();
        }

        public static int GetCodeCategorie(string libelle)
        {
            return CategorieDAO.GetCodeCategorie(libelle);
        }
    }
}
