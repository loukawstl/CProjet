using GestionBLL;
using GestionBO;
using GestionGUI;
using System.Configuration;

namespace Connexion
{
    public partial class ConnexionForm : Form
    {
        public ConnexionForm()
        {
            InitializeComponent();
            UtilisateurBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string nom = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;

            Utilisateur uti = new Utilisateur(0, nom, password);

            if (UtilisateurBLL.verifierConnexion(uti))
            {
                this.Hide()
;               FrmSyntheseClients FrmSyntheseClients;
                FrmSyntheseClients = new FrmSyntheseClients();
                FrmSyntheseClients.Closed += (s, args) => this.Close();
                FrmSyntheseClients.ShowDialog(); // ouverture du formulaire list produit
                this.Close();
            }
            else
            {
                lblErreur.ForeColor = Color.Red;
            }
        }

        private void temp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSyntheseClients FrmSyntheseClients;
            FrmSyntheseClients = new FrmSyntheseClients();
            FrmSyntheseClients.Closed += (s, args) => this.Close();
            FrmSyntheseClients.ShowDialog(); // ouverture du formulaire synthese
            this.Close();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void ConnexionForm_Load(object sender, EventArgs e)
        {

        }
    }
}