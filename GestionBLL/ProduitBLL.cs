using GestionDAL;
using GestionBO;
using System.Configuration;


namespace GestionBLL
{
    public class ProduitBLL
    {
        private static ProduitBLL uneGestionProduit; // objet BLL

        // Accesseur en lecture
        public static ProduitBLL GetGestionUtilisateurs()
        {
            if (uneGestionProduit == null)
            {
                uneGestionProduit = new ProduitBLL();
            }
            return uneGestionProduit;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la méthode GetProduit() de la DAL : VIEW
        public static List<Produit> GetProduit()
        {
            return ProduitDAO.GetProduit();
        }

        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la méthode GetProduit() de la DAL : VIEW
        public static int CategorieProduit(int code)
        {
            return ProduitDAO.SelectCategorieProduit(code);
        }

        // Méthode qui renvoi l’objet Produit en l'ajoutant à la
        // BD avec la méthode AjoutProduit de la DAL
        public static int CreerProduit(Produit ut)
        {
            return ProduitDAO.AjoutProduit(ut);
        }


        // Méthode qui modifie un nouveau Produit avec la méthode UpdateProduit de la DAL
        public static int ModifierProduit(Produit prod)
        {
            return ProduitDAO.UpdateProduit(prod);
        }

        // Méthode qui supprime un Produit avec la méthode DeleteProduit de la DAL
        public static int SupprimerProduit(int id)
        {
            return ProduitDAO.DeleteProduit(id);
        }
    }
}
