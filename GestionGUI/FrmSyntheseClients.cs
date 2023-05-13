using GestionBLL;
using GestionBO;
using System.Windows.Forms;
using Connexion;


namespace GestionGUI
{
    public partial class FrmSyntheseClients : Form
    {
        public FrmSyntheseClients()
        {
            InitializeComponent();

            foreach (Client cli in ClientBLL.GetClient())
            {
                List<Devis> listDevis = cli.LesDevis;
                int taille = listDevis.Count;
                int code_devis;
                double prixTotalDevis = 0;
                double nbAcc = 0, nbRef = 0, nbAtt = 0;

                foreach (Devis dev in listDevis)
                {
                    switch (dev.Statut.Libelle)
                    {
                        case "Accepté":
                            nbAcc++;
                            break;
                        case "Refusé":
                            nbRef++;
                            break;
                        case "En attente":
                            nbAtt++;
                            break;
                        default:
                            break;
                    }

                    code_devis = dev.Code;
                    foreach (Contenir con in ContenirBLL.GetConteneurs(code_devis))
                    {
                        double prixTotal = con.Produit.Prix * con.Quantite;
                        // prixTotalDevis = prixTotalDevis + prixTotal;
                        prixTotalDevis = prixTotalDevis + (prixTotal - (prixTotal * (con.Remise / 100)));

                        prixTotalDevis = Math.Round(prixTotalDevis, 1, MidpointRounding.ToEven);
                    }
                }

                double prAcc = 0, prRef = 0, prAtt = 0;

                if (taille > 0)
                {
                    prAcc = (nbAcc / taille) * 100;
                    prRef = (nbRef / taille) * 100;
                    prAtt = (nbAtt / taille) * 100;
                }

                prAcc = Math.Round(prAcc, 1, MidpointRounding.ToEven);
                prRef = Math.Round(prRef, 1 , MidpointRounding.ToEven);
                prAtt = Math.Round(prAtt, 1, MidpointRounding.ToEven);

                dataGridSynthese.Rows.Add(cli.Nom, taille, nbAcc, prAcc + "%", prAtt + "%", prRef + "%", prixTotalDevis);
            }

        }

        private void syntheseProduit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmListeProduits FrmListesProduit;
            FrmListesProduit = new FrmListeProduits();
            FrmListesProduit.Closed += (s, args) => this.Close();
            FrmListesProduit.ShowDialog(); // ouverture du formulaire list produit
            this.Close();
        }

        private void deconnexion_Click(object sender, EventArgs e)
        {            
            this.Hide();
            ConnexionForm connexionForm;
            connexionForm = new ConnexionForm();
            connexionForm.Closed += (s, args) => this.Close();
            connexionForm.ShowDialog(); // déconnexion
            this.Close();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmListeClients FrmListeClients;
            FrmListeClients = new FrmListeClients();
            FrmListeClients.Closed += (s, args) => this.Close();
            FrmListeClients.ShowDialog(); // ouverture du formulaire list client
            this.Close();
        }

        private void btnDevis_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmListeDevis FrmListeDevis;
            FrmListeDevis = new FrmListeDevis();
            FrmListeDevis.Closed += (s, args) => this.Close();
            FrmListeDevis.ShowDialog(); // ouverture du formulaire list devis
            this.Close();
        }

        private void dataGridSynthese_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            DateTime date1 = DateTime.Parse(dateTimeSynth.Value.ToString());
            DateTime date2 = DateTime.Parse(dateTimeSynth2.Value.ToString());
            dataGridSynthese.Rows.Clear();


            foreach (Client cli in ClientBLL.GetClient())
            {
                List<Devis> listDevis = cli.LesDevis;
                int code_devis;
                double prixTotalDevis = 0;
                double nbAcc = 0, nbRef = 0, nbAtt = 0;

                foreach (Devis dev in listDevis)
                { 
                    if (DateTime.Compare(date1, dev.Date) <= 0 && DateTime.Compare(dev.Date, date2) <= 0)
                    {
                        switch (dev.Statut.Libelle)
                        {
                            case "Accepté":
                                nbAcc++;
                                break;
                            case "Refusé":
                                nbRef++;
                                break;
                            case "En attente":
                                nbAtt++;
                                break;
                            default:
                                break;
                        }

                        code_devis = dev.Code;
                        foreach (Contenir con in ContenirBLL.GetConteneurs(code_devis))
                        {
                            double prixTotal = con.Produit.Prix * con.Quantite;
                            // prixTotalDevis = prixTotalDevis + prixTotal;
                            prixTotalDevis = prixTotalDevis + (prixTotal - (prixTotal * (con.Remise / 100)));

                            prixTotalDevis = Math.Round(prixTotalDevis, 1, MidpointRounding.ToEven);
                        }   

                    }               
                }

                double prAcc = 0, prRef = 0, prAtt = 0;
                double taille = nbAcc + nbAtt + nbRef;


                if (taille > 0)
                {
                    prAcc = (nbAcc / taille) * 100;
                    prRef = (nbRef / taille) * 100;
                    prAtt = (nbAtt / taille) * 100;

                    prAcc = Math.Round(prAcc, 1, MidpointRounding.ToEven);
                    prRef = Math.Round(prRef, 1, MidpointRounding.ToEven);
                    prAtt = Math.Round(prAtt, 1, MidpointRounding.ToEven);

                    dataGridSynthese.Rows.Add(cli.Nom, taille, nbAcc, prAcc + "%", prAtt + "%", prRef + "%", prixTotalDevis);
                }              

                
            }
        }
    }
}
