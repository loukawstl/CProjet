namespace GestionBO
{
    public class Produit
    {
        private int code;
        private string libelle;
        private float prix;
        private Categorie categorie;

        public Produit(int code, string libelle, float prix, Categorie categorie)
        {
            this.code = code;
            this.libelle = libelle;
            this.prix = prix;
            this.categorie = categorie;
        }

        public int Code { get => code; set => code = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public float Prix { get => prix; set => prix = value; }
        public Categorie Categorie { get => categorie; set => categorie = value; }
    }
}
