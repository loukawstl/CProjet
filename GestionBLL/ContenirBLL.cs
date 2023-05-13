using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDAL;
using GestionBO;
using System.Configuration;

namespace GestionBLL
{
    public class ContenirBLL
    {
        private static ContenirBLL uneGestionContenir; // objet BLL

        // Accesseur en lecture
        public static ContenirBLL GetGestionContenir()
        {
            if (uneGestionContenir == null)
            {
                uneGestionContenir = new ContenirBLL();
            }
            return uneGestionContenir;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la méthode GetProduit() de la DAL : VIEW
        public static List<Contenir> GetConteneurs(int code_devis)
        {
            return ContenirDAO.GetContenir(code_devis);
        }

        public static int ModifierContenir(Contenir con)
        {
            return ContenirDAO.UpdateContenir(con);
        }

        public static int CreerContenir(Contenir con)
        {
            return ContenirDAO.AjoutContenir(con);
        }

        public static int SupprimerContenir(int code_devis, int code_produit)
        {
            return ContenirDAO.DeleteContenir(code_devis, code_produit);
        }
    }
}
