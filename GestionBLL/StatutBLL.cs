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
    public class StatutBLL
    {
        private static StatutBLL uneGestionStatut; // objet BLL

        // Accesseur en lecture
        public static StatutBLL GetGestionUtilisateurs()
        {
            if (uneGestionStatut == null)
            {
                uneGestionStatut = new StatutBLL();
            }
            return uneGestionStatut;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la méthode GetProduit() de la DAL : VIEW
        public static List<Statut> GetStatut()
        {
            return StatutDAO.GetStatut();
        }

        // Méthode qui renvoi l’objet Produit en l'ajoutant à la
        // BD avec la méthode AjoutProduit de la DAL
        public static int CreerStatut(Statut sta)
        {
            return StatutDAO.AjoutStatut(sta);
        }

        public static int GetCodeStatut(string libelle)
        {
            return StatutDAO.GetCodeStatut(libelle);
        }
    }
}
