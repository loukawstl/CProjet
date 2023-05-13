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
    public class DevisBLL
    {
        private static DevisBLL uneGestionDevis; // objet BLL

        // Accesseur en lecture
        public static DevisBLL GetGestionUtilisateurs()
        {
            if (uneGestionDevis == null)
            {
                uneGestionDevis = new DevisBLL();
            }
            return uneGestionDevis;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la méthode GetProduit() de la DAL : VIEW
        public static List<Devis> GetDevis()
        {
            return DevisDAO.GetDevis();
        }

        public static int GetCodeDevis(DateTime date, float txTVA, Client client, Statut statut)
        {
            return DevisDAO.GetCodeDevis(date, txTVA, client, statut);
        }

        // Méthode qui renvoit le code du client
        public static int ClientDevis(int code)
        {
            return DevisDAO.SelectClientDevis(code);
        }

        // Méthode qui renvoit le code du statut
        public static int StatutDevis(int code)
        {
            return DevisDAO.SelectStatutDevis(code);
        }

        // Fonction qui modifie un devis
        public static int ModifierDevis(Devis dev)
        {
            return DevisDAO.ModifierDevis(dev);
        }

        public static int CreerDevis(Devis dev)
        {
            return DevisDAO.AjoutDevis(dev);
        }

        public static int SupprimerDevis(int id)
        {
            return DevisDAO.DeleteDevis(id);
        }
    }
}
