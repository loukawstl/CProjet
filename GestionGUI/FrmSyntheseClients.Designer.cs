namespace GestionGUI
{
    partial class FrmSyntheseClients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.syntheseProduit = new System.Windows.Forms.Button();
            this.deconnexion = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnDevis = new System.Windows.Forms.Button();
            this.lblSynthese = new System.Windows.Forms.Label();
            this.dataGridSynthese = new System.Windows.Forms.DataGridView();
            this.nomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDevis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDevisAccepté = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pourcentageDevisAccepté = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pourcentageDevisAttente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pourcentageDevisRefuse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantTotalFactureHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeSynth = new System.Windows.Forms.DateTimePicker();
            this.dateTimeSynth2 = new System.Windows.Forms.DateTimePicker();
            this.lblRecherche2 = new System.Windows.Forms.Label();
            this.lblRecherche1 = new System.Windows.Forms.Label();
            this.btnRecherche = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSynthese)).BeginInit();
            this.SuspendLayout();
            // 
            // syntheseProduit
            // 
            this.syntheseProduit.Location = new System.Drawing.Point(585, 716);
            this.syntheseProduit.Name = "syntheseProduit";
            this.syntheseProduit.Size = new System.Drawing.Size(94, 29);
            this.syntheseProduit.TabIndex = 0;
            this.syntheseProduit.Text = "Produits";
            this.syntheseProduit.UseVisualStyleBackColor = true;
            this.syntheseProduit.Click += new System.EventHandler(this.syntheseProduit_Click);
            // 
            // deconnexion
            // 
            this.deconnexion.Location = new System.Drawing.Point(1066, 107);
            this.deconnexion.Name = "deconnexion";
            this.deconnexion.Size = new System.Drawing.Size(118, 29);
            this.deconnexion.TabIndex = 1;
            this.deconnexion.Text = "Déconnexion";
            this.deconnexion.UseVisualStyleBackColor = true;
            this.deconnexion.Click += new System.EventHandler(this.deconnexion_Click);
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(437, 716);
            this.btnClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(94, 28);
            this.btnClient.TabIndex = 2;
            this.btnClient.Text = "Clients";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnDevis
            // 
            this.btnDevis.Location = new System.Drawing.Point(733, 716);
            this.btnDevis.Name = "btnDevis";
            this.btnDevis.Size = new System.Drawing.Size(94, 29);
            this.btnDevis.TabIndex = 3;
            this.btnDevis.Text = "Devis";
            this.btnDevis.UseVisualStyleBackColor = true;
            this.btnDevis.Click += new System.EventHandler(this.btnDevis_Click);
            // 
            // lblSynthese
            // 
            this.lblSynthese.AutoSize = true;
            this.lblSynthese.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSynthese.Location = new System.Drawing.Point(334, 70);
            this.lblSynthese.Name = "lblSynthese";
            this.lblSynthese.Size = new System.Drawing.Size(536, 72);
            this.lblSynthese.TabIndex = 25;
            this.lblSynthese.Text = "Synthèse des clients";
            // 
            // dataGridSynthese
            // 
            this.dataGridSynthese.AllowUserToAddRows = false;
            this.dataGridSynthese.AllowUserToDeleteRows = false;
            this.dataGridSynthese.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSynthese.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomClient,
            this.nombreDevis,
            this.nombreDevisAccepté,
            this.pourcentageDevisAccepté,
            this.pourcentageDevisAttente,
            this.pourcentageDevisRefuse,
            this.montantTotalFactureHT});
            this.dataGridSynthese.Location = new System.Drawing.Point(153, 229);
            this.dataGridSynthese.Name = "dataGridSynthese";
            this.dataGridSynthese.ReadOnly = true;
            this.dataGridSynthese.RowHeadersWidth = 51;
            this.dataGridSynthese.RowTemplate.Height = 29;
            this.dataGridSynthese.Size = new System.Drawing.Size(928, 458);
            this.dataGridSynthese.TabIndex = 26;
            this.dataGridSynthese.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSynthese_CellContentClick);
            // 
            // nomClient
            // 
            this.nomClient.HeaderText = "Nom client";
            this.nomClient.MinimumWidth = 6;
            this.nomClient.Name = "nomClient";
            this.nomClient.ReadOnly = true;
            this.nomClient.Width = 125;
            // 
            // nombreDevis
            // 
            this.nombreDevis.HeaderText = "Nombre devis";
            this.nombreDevis.MinimumWidth = 6;
            this.nombreDevis.Name = "nombreDevis";
            this.nombreDevis.ReadOnly = true;
            this.nombreDevis.Width = 125;
            // 
            // nombreDevisAccepté
            // 
            this.nombreDevisAccepté.HeaderText = "Nombre devis acceptés";
            this.nombreDevisAccepté.MinimumWidth = 6;
            this.nombreDevisAccepté.Name = "nombreDevisAccepté";
            this.nombreDevisAccepté.ReadOnly = true;
            this.nombreDevisAccepté.Width = 125;
            // 
            // pourcentageDevisAccepté
            // 
            this.pourcentageDevisAccepté.HeaderText = "Pourcentage devis acceptés";
            this.pourcentageDevisAccepté.MinimumWidth = 6;
            this.pourcentageDevisAccepté.Name = "pourcentageDevisAccepté";
            this.pourcentageDevisAccepté.ReadOnly = true;
            this.pourcentageDevisAccepté.Width = 125;
            // 
            // pourcentageDevisAttente
            // 
            this.pourcentageDevisAttente.HeaderText = "Pourcentage devis attentes";
            this.pourcentageDevisAttente.MinimumWidth = 6;
            this.pourcentageDevisAttente.Name = "pourcentageDevisAttente";
            this.pourcentageDevisAttente.ReadOnly = true;
            this.pourcentageDevisAttente.Width = 125;
            // 
            // pourcentageDevisRefuse
            // 
            this.pourcentageDevisRefuse.HeaderText = "Pourcentage Devis Refusés";
            this.pourcentageDevisRefuse.MinimumWidth = 6;
            this.pourcentageDevisRefuse.Name = "pourcentageDevisRefuse";
            this.pourcentageDevisRefuse.ReadOnly = true;
            this.pourcentageDevisRefuse.Width = 125;
            // 
            // montantTotalFactureHT
            // 
            this.montantTotalFactureHT.HeaderText = "Montant total facture hors taxe";
            this.montantTotalFactureHT.MinimumWidth = 6;
            this.montantTotalFactureHT.Name = "montantTotalFactureHT";
            this.montantTotalFactureHT.ReadOnly = true;
            this.montantTotalFactureHT.Width = 125;
            // 
            // dateTimeSynth
            // 
            this.dateTimeSynth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeSynth.Location = new System.Drawing.Point(378, 196);
            this.dateTimeSynth.Name = "dateTimeSynth";
            this.dateTimeSynth.Size = new System.Drawing.Size(121, 27);
            this.dateTimeSynth.TabIndex = 43;
            // 
            // dateTimeSynth2
            // 
            this.dateTimeSynth2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeSynth2.Location = new System.Drawing.Point(580, 196);
            this.dateTimeSynth2.Name = "dateTimeSynth2";
            this.dateTimeSynth2.Size = new System.Drawing.Size(121, 27);
            this.dateTimeSynth2.TabIndex = 44;
            // 
            // lblRecherche2
            // 
            this.lblRecherche2.AutoSize = true;
            this.lblRecherche2.Location = new System.Drawing.Point(549, 201);
            this.lblRecherche2.Name = "lblRecherche2";
            this.lblRecherche2.Size = new System.Drawing.Size(25, 20);
            this.lblRecherche2.TabIndex = 45;
            this.lblRecherche2.Text = "au";
            // 
            // lblRecherche1
            // 
            this.lblRecherche1.AutoSize = true;
            this.lblRecherche1.Location = new System.Drawing.Point(344, 201);
            this.lblRecherche1.Name = "lblRecherche1";
            this.lblRecherche1.Size = new System.Drawing.Size(28, 20);
            this.lblRecherche1.TabIndex = 46;
            this.lblRecherche1.Text = "Du";
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(755, 195);
            this.btnRecherche.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(94, 28);
            this.btnRecherche.TabIndex = 47;
            this.btnRecherche.Text = "Recherche";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // FrmSyntheseClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1232, 803);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.lblRecherche1);
            this.Controls.Add(this.lblRecherche2);
            this.Controls.Add(this.dateTimeSynth2);
            this.Controls.Add(this.dateTimeSynth);
            this.Controls.Add(this.dataGridSynthese);
            this.Controls.Add(this.lblSynthese);
            this.Controls.Add(this.btnDevis);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.deconnexion);
            this.Controls.Add(this.syntheseProduit);
            this.Name = "FrmSyntheseClients";
            this.Text = "SyntheseClientsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSynthese)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button syntheseProduit;
        private Button deconnexion;
        private Button btnClient;
        private Button btnDevis;
        private Label lblSynthese;
        private DataGridView dataGridSynthese;
        private DataGridViewTextBoxColumn nomClient;
        private DataGridViewTextBoxColumn nombreDevis;
        private DataGridViewTextBoxColumn nombreDevisAccepté;
        private DataGridViewTextBoxColumn pourcentageDevisAccepté;
        private DataGridViewTextBoxColumn pourcentageDevisAttente;
        private DataGridViewTextBoxColumn pourcentageDevisRefuse;
        private DataGridViewTextBoxColumn montantTotalFactureHT;
        private DateTimePicker dateTimeSynth;
        private DateTimePicker dateTimeSynth2;
        private Label lblRecherche2;
        private Label lblRecherche1;
        private Button btnRecherche;
    }
}