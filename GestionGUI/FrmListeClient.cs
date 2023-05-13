using GestionBLL;
using GestionBO;
using GestionDAL;
using System.Configuration;
using System.Drawing;

namespace GestionGUI
{
    public partial class FrmListeClients : Form
    {
        public FrmListeClients()
        {
            InitializeComponent();
            ClientBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);

            foreach (Client cli in ClientBLL.GetClient())
            {
                dgvClient.Rows.Add(cli.Code, cli.Nom, cli.Prenom, cli.Email, cli.Fax, cli.Telephone,
                    cli.Rue_facturation, cli.Cp_facturation, cli.Ville_facturation,
                    cli.Rue_livraison, cli.Cp_livraison, cli.Ville_livraison);
            }

            PanelDelete.Hide();

        }

        private void retSynt_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSyntheseClients FrmSyntheseClients;
            FrmSyntheseClients = new FrmSyntheseClients();
            FrmSyntheseClients.Closed += (s, args) => this.Close();
            FrmSyntheseClients.ShowDialog(); // retour synthese
            this.Close();
        }

        private void dgvProduit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Show();
            textCodeCli.Text = dgvClient.CurrentRow.Cells[0].Value.ToString();
            textNomCli.Text = dgvClient.CurrentRow.Cells[1].Value.ToString();
            textPrenomCli.Text = dgvClient.CurrentRow.Cells[2].Value.ToString();
            textEmailCli.Text = dgvClient.CurrentRow.Cells[3].Value.ToString();
            textFaxCli.Text = dgvClient.CurrentRow.Cells[4].Value.ToString();
            textTelCli.Text = dgvClient.CurrentRow.Cells[5].Value.ToString();            
            textRueFactuCli.Text = dgvClient.CurrentRow.Cells[6].Value.ToString();
            textCPFactuCli.Text = dgvClient.CurrentRow.Cells[7].Value.ToString();
            textVilleFactCli.Text = dgvClient.CurrentRow.Cells[8].Value.ToString();
            textRueLivraisonCli.Text = dgvClient.CurrentRow.Cells[9].Value.ToString();
            CodePostalLivraiCli.Text = dgvClient.CurrentRow.Cells[10].Value.ToString();
            textVilleLivraiCli.Text = dgvClient.CurrentRow.Cells[11].Value.ToString();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            string nom = textNomCli.Text;
            string prenom = textPrenomCli.Text;
            string email = textEmailCli.Text;
            string telephone = textTelCli.Text;
            string fax = textFaxCli.Text;
            string rueFactu = textRueFactuCli.Text;
            string cpFactu = textCPFactuCli.Text;
            string villeFact = textVilleFactCli.Text;
            string rueLivraison = textRueLivraisonCli.Text;
            string cpLivraison = CodePostalLivraiCli.Text;
            string villeLivraison = textVilleLivraiCli.Text;
            bool saisie = true;

            if (nom == "" || prenom == "" || email == "" || telephone == "" || fax == "" || rueFactu == "" ||
                cpFactu == "" || villeFact == "" || rueLivraison == "" || cpLivraison == "" || villeLivraison == "")
            {
                lblErrorClient.ForeColor = Color.Red;
                saisie = false;
            }
            else
            {
                lblErrorClient.ForeColor = System.Drawing.SystemColors.ControlDark;
            }

            if (saisie)
            {
                int id;
                int.TryParse(textCodeCli.Text, out id);
                             
                // Création de l'objet client avec le nom récupéré dans la GUI
                Client cli = new Client(id, nom, prenom, rueFactu, 
                    cpFactu, villeFact, rueLivraison, cpLivraison, 
                    villeLivraison, telephone, fax, email);

                // Appel de la méthode CreerProduit de la couche BLL
                ClientBLL.ModifierClient(cli);

                this.Hide();
                FrmListeClients FrmListeClients;
                FrmListeClients = new FrmListeClients();
                FrmListeClients.Closed += (s, args) => this.Close();
                FrmListeClients.ShowDialog(); // ouverture du formulaire list produit
                this.Close();
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            PanelDelete.Show();
        }

        private void actualiserClient_Click(object sender, EventArgs e)
        {
            dgvClient.Rows.Clear();

            foreach (Client cli in ClientBLL.GetClient())
            {
                dgvClient.Rows.Add(cli.Code, cli.Nom, cli.Prenom, cli.Email, 
                    cli.Fax, cli.Telephone, cli.Rue_facturation, cli.Cp_facturation, 
                    cli.Ville_facturation, cli.Rue_livraison, cli.Cp_livraison, cli.Ville_livraison);
            }
        }

        private void AjouterCli_Click(object sender, EventArgs e)
        {
            string nom = textNomCli.Text;
            string prenom = textPrenomCli.Text;
            string email = textEmailCli.Text;
            string telephone = textTelCli.Text;
            string fax = textFaxCli.Text;
            string rueFactu = textRueFactuCli.Text;
            string cpFactu = textCPFactuCli.Text;
            string villeFact = textVilleFactCli.Text;
            string rueLivraison = textRueLivraisonCli.Text;
            string cpLivraison = CodePostalLivraiCli.Text;
            string villeLivraison = textVilleLivraiCli.Text;
            bool saisie = true;

            if (nom == "" || prenom == "" || email == "" || telephone == "" || fax == "" || rueFactu == "" ||
                cpFactu == "" || villeFact == "" || rueLivraison == "" || cpLivraison == "" || villeLivraison == "")
            {
                lblErrorClient.ForeColor = Color.Red;
                saisie = false;
            }
            else
            {
                lblErrorClient.ForeColor = System.Drawing.SystemColors.ControlDark;
            }

            if (saisie)
            {
                int id;
                int.TryParse(textCodeCli.Text, out id);

                // Création de l'objet client avec le nom récupéré dans la GUI
                Client cli = new Client(id, nom, prenom, rueFactu,
                    cpFactu, villeFact, rueLivraison, cpLivraison,
                    villeLivraison, telephone, fax, email);

                // Appel de la méthode CreerProduit de la couche BLL
                ClientBLL.AjouterClient(cli);

                this.Hide();
                FrmListeClients FrmListeClients;
                FrmListeClients = new FrmListeClients();
                FrmListeClients.Closed += (s, args) => this.Close();
                FrmListeClients.ShowDialog(); // ouverture du formulaire list clients
                this.Close();
            }
        }

        private void ConfirmerDelete_Click(object sender, EventArgs e)
        {
            PanelDelete.Hide();

            int id;

            int.TryParse(textCodeCli.Text, out id);
            // ProduitBLL.SupprimerProduit(id);

            int deleteCli = ClientBLL.SupprimerClient(id);
            if (deleteCli == 0)
            {
                MessageBox.Show("Le client est relié à au moins un devis, il ne peut donc pas être supprimé.");
            }

            this.Hide();
            FrmListeClients FrmListeClients;
            FrmListeClients = new FrmListeClients();
            FrmListeClients.Closed += (s, args) => this.Close();
            FrmListeClients.ShowDialog(); // ouverture du formulaire list clients
            this.Close();
        }

        private void AnnulerDelete_Click(object sender, EventArgs e)
        {
            PanelDelete.Hide();
        }

        private void lblVilleLivraiCli_Click(object sender, EventArgs e)
        {

        }
    }
}
