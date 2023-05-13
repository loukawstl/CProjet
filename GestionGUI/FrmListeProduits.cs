using GestionBLL;
using GestionBO;
using GestionDAL;
using System.Configuration;
using System.Drawing;

namespace GestionGUI
{
    public partial class FrmListeProduits : Form
    {
        public FrmListeProduits()
        {
            InitializeComponent();
            ProduitBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);

            foreach (Produit pro in ProduitBLL.GetProduit())
            {
                dgvProduit.Rows.Add(pro.Code, pro.Libelle, pro.Prix, pro.Categorie.Libelle);
            }



            foreach (Categorie cate in CategorieBLL.GetCategorie())
            {
                this.listCategorie.Items.Add(cate.Libelle);
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
            int code_categorie;
            string libelle_categorie;

            libelle_categorie = dgvProduit.CurrentRow.Cells[3].Value.ToString();
            code_categorie = CategorieBLL.GetCodeCategorie(libelle_categorie);
            
            panel1.Show();
            textCode.Text = dgvProduit.CurrentRow.Cells[0].Value.ToString();
            textLibelle.Text = dgvProduit.CurrentRow.Cells[1].Value.ToString();
            textPrix.Text = dgvProduit.CurrentRow.Cells[2].Value.ToString();
            listCategorie.SelectedIndex = code_categorie;
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            string libelle = textLibelle.Text;
            string prix = textPrix.Text;
            string categorie = listCategorie.Text;
            bool saisie = true;

            if (libelle == "")
            {
                lblErrorLibellé.ForeColor = Color.Red;
                saisie = false;
            }
            else
            {
                lblErrorLibellé.ForeColor = System.Drawing.SystemColors.ControlDark;
            }

            if (prix == "")
            {
                lblErrorPrix.ForeColor = Color.Red;
                saisie = false;
            }
            else
            {
                lblErrorPrix.ForeColor = System.Drawing.SystemColors.ControlDark;
            }

            if (categorie == "")
            {
                lblErrorCategorie.ForeColor = Color.Red;
                saisie = false;
            }
            else
            {
                lblErrorCategorie.ForeColor = System.Drawing.SystemColors.ControlDark;
            }

            if (saisie)
            {
                float temp;
                float.TryParse(textPrix.Text, out temp);
                int id;

                int.TryParse(textCode.Text, out id);

                foreach (Categorie cate in CategorieBLL.GetCategorie())
                {
                    if (cate.Libelle == listCategorie.Text)
                    {
                        // Création de l'objet produit avec le nom récupéré dans la GUI
                        Produit pro = new Produit(id, libelle, temp, cate);

                        // Appel de la méthode CreerProduit de la couche BLL
                        ProduitBLL.ModifierProduit(pro);

                        this.Hide();
                        FrmListeProduits FrmListeProduits;
                        FrmListeProduits = new FrmListeProduits();
                        FrmListeProduits.Closed += (s, args) => this.Close();
                        FrmListeProduits.ShowDialog(); // ouverture du formulaire list produit
                        this.Close();

                        break;
                    }
                };

            }
        }

        private void addPro_Click(object sender, EventArgs e)
        {
            string libelle = textLibelle.Text;
            string prix = textPrix.Text;
            string categorie = listCategorie.Text;
            bool saisie = true;

            if (libelle == "")
            {
                lblErrorLibellé.ForeColor = Color.Red;
                saisie = false;
            }
            else
            {
                lblErrorLibellé.ForeColor = System.Drawing.SystemColors.ControlDark;
            }

            if (prix == "")
            {
                lblErrorPrix.ForeColor = Color.Red;
                saisie = false;
            }
            else
            {
                lblErrorPrix.ForeColor = System.Drawing.SystemColors.ControlDark;
            }

            if (categorie == "")
            {
                lblErrorCategorie.ForeColor = Color.Red;
                saisie = false;
            }
            else
            {
                lblErrorCategorie.ForeColor = System.Drawing.SystemColors.ControlDark;
            }

            if (saisie)
            {
                float temp;
                float.TryParse(textPrix.Text, out temp);

                foreach (Categorie cate in CategorieBLL.GetCategorie())
                {
                    if (cate.Libelle == listCategorie.Text)
                    {
                        // Création de l'objet produit avec le nom récupéré dans la GUI
                        Produit pro = new Produit(0, textLibelle.Text, temp, cate);

                        // Appel de la méthode CreerProduit de la couche BLL
                        ProduitBLL.CreerProduit(pro);


                        this.Hide();
                        FrmListeProduits FrmListeProduits;
                        FrmListeProduits = new FrmListeProduits();
                        FrmListeProduits.Closed += (s, args) => this.Close();
                        FrmListeProduits.ShowDialog(); // ouverture du formulaire list produit
                        this.Close();

                        break;
                    }
                };
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            PanelDelete.Show();
        }

        private void ConfirmerDelete_Click(object sender, EventArgs e)
        {
            PanelDelete.Hide();

            int id;

            int.TryParse(textCode.Text, out id);
            // ProduitBLL.SupprimerProduit(id);

            int delete = ProduitBLL.SupprimerProduit(id);
            if (delete == 0)
            {
                MessageBox.Show("Le produit est relié à au moins un devis, il ne peut donc pas être supprimé.");
            }

            this.Hide();
            FrmListeProduits FrmListeProduits;
            FrmListeProduits = new FrmListeProduits();
            FrmListeProduits.Closed += (s, args) => this.Close();
            FrmListeProduits.ShowDialog(); // ouverture du formulaire list produit
            this.Close();
        }

        private void AnnulerDelete_Click(object sender, EventArgs e)
        {
            PanelDelete.Hide();
        }

        private void actualiserProduit_Click(object sender, EventArgs e)
        {
            dgvProduit.Rows.Clear();

            foreach (Produit pro in ProduitBLL.GetProduit())
            {
                dgvProduit.Rows.Add(pro.Code, pro.Libelle, pro.Prix, pro.Categorie.Libelle);
            }
       }
    }
}
