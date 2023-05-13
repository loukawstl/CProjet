using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBO
{
    public class Client
    {
        private int code;
        private string nom;
        private string prenom;
        private string rue_facturation;
        private string cp_facturation;
        private string ville_facturation;
        private string rue_livraison;
        private string cp_livraison;
        private string ville_livraison;
        private string telephone;
        private string fax;
        private string email;
        private List<Devis> lesDevis;

        public Client(int code, string nom, string prenom, 
            string rue_facturation, string cp_facturation,
            string ville_facturation, string rue_livraison,
            string cp_livraison, string ville_livraison,
            string telephone, string fax, string email)
        {
            this.Code = code;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Rue_facturation = rue_facturation;
            this.Cp_facturation = cp_facturation;
            this.Ville_facturation = ville_facturation;
            this.Rue_livraison = rue_livraison;
            this.Cp_livraison = cp_livraison;
            this.Ville_livraison = ville_livraison;
            this.Telephone = telephone;
            this.Fax = fax;
            this.Email = email;
            this.LesDevis = new List<Devis>();
        }

        public int Code { get => code; set => code = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Rue_facturation { get => rue_facturation; set => rue_facturation = value; }
        public string Cp_facturation { get => cp_facturation; set => cp_facturation = value; }
        public string Ville_facturation { get => ville_facturation; set => ville_facturation = value; }
        public string Rue_livraison { get => rue_livraison; set => rue_livraison = value; }
        public string Cp_livraison { get => cp_livraison; set => cp_livraison = value; }
        public string Ville_livraison { get => ville_livraison; set => ville_livraison = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Fax { get => fax; set => fax = value; }
        public string Email { get => email; set => email = value; }
        public List<Devis> LesDevis { get => lesDevis; set => lesDevis = value; }

        public void addDevis(Devis dev)
        {
            this.lesDevis.Add(dev);
        }
    }
}
