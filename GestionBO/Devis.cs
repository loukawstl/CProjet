using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBO
{
    public class Devis
    {
        private int code;
        private DateTime date;
        private float taux_tva;
        private Client client;
        private Statut statut;

        public Devis(int code, DateTime date, float taux_tva, Client client, Statut statut)
        {
            this.code = code;
            this.date = date;
            this.taux_tva = taux_tva;
            this.client = client;
            this.statut = statut;
        }

        public int Code { get => code; set => code = value; }
        public DateTime Date { get => date; set => date = value; }
        public float Taux_tva { get => taux_tva; set => taux_tva = value; }
        public Client Client { get => client; set => client = value; }
        public Statut Statut { get => statut; set => statut = value; }
    }
}
