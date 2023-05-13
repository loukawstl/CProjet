using GestionBO;
using GestionDAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBLL
{
    public class ClientBLL
    {
        private static ClientBLL uneGestionClient; // objet BLL

        // Accesseur en lecture
        public static ClientBLL GetGestionUtilisateurs()
        {
            if (uneGestionClient == null)
            {
                uneGestionClient = new ClientBLL();
            }
            return uneGestionClient;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la méthode GetClient() de la DAL : VIEW
        public static List<Client> GetClient()
        {
            return ClientDAO.GetClient();
        }

        public static int GetCodeClient(string nom)
        {
            return ClientDAO.GetCodeClient(nom);
        }

        // Méthode qui modifie un nouveau client avec la méthode UpdateClient de la DAL
        public static int ModifierClient(Client cli)
        {
            return ClientDAO.UpdateClient(cli);
        }

        public static int AjouterClient(Client cli)
        {
            return ClientDAO.AddClient(cli);
        }

        public static int SupprimerClient(int id)
        {
            return ClientDAO.DeleteClient(id);
        }
    }
}
