using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBO
{
    public class Contenir
    {
        private Devis devis;
        private Produit produit;
        private int quantite;
        private float remise;

        public Contenir(Devis devis, Produit produit, int quantite, float remise)
        {
            this.devis = devis;
            this.produit = produit;
            this.quantite = quantite;
            this.remise = remise;
        }

        public Devis Devis { get => devis; set => devis = value; }
        public Produit Produit { get => produit; set => produit = value; }
        public int Quantite { get => quantite; set => quantite = value; }
        public float Remise { get => remise; set => remise = value; }
    }
}
