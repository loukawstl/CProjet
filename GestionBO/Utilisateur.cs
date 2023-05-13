namespace GestionBO
{
    public class Utilisateur
    {
        private int id;
        private string nom;
        private string password;

        public Utilisateur(int id, string nom, string password)
        {
            this.id = id;
            this.nom = nom;
            this.password = password;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Password { get => password; set => password = value; }
    }
}