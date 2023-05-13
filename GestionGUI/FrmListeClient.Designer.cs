namespace GestionGUI
{
    partial class FrmListeClients
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
            this.retSynt = new System.Windows.Forms.Button();
            this.actualiserProduit = new System.Windows.Forms.Button();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rue_Fac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cp_fact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ville_fact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rue_liv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cp_liv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ville_liv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProduit = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifierCli = new System.Windows.Forms.Button();
            this.SupprimerCli = new System.Windows.Forms.Button();
            this.textCodeCli = new System.Windows.Forms.TextBox();
            this.textNomCli = new System.Windows.Forms.TextBox();
            this.textPrenomCli = new System.Windows.Forms.TextBox();
            this.LabelDetails = new System.Windows.Forms.Label();
            this.lblNomCli = new System.Windows.Forms.Label();
            this.lblCodeCli = new System.Windows.Forms.Label();
            this.lblPrenomCli = new System.Windows.Forms.Label();
            this.AjouterCli = new System.Windows.Forms.Button();
            this.textEmailCli = new System.Windows.Forms.TextBox();
            this.lblEmailCli = new System.Windows.Forms.Label();
            this.lblTelCli = new System.Windows.Forms.Label();
            this.lblFaxCli = new System.Windows.Forms.Label();
            this.textTelCli = new System.Windows.Forms.TextBox();
            this.textFaxCli = new System.Windows.Forms.TextBox();
            this.lblRueFactCli = new System.Windows.Forms.Label();
            this.textRueFactuCli = new System.Windows.Forms.TextBox();
            this.lblCodePostalFactuCli = new System.Windows.Forms.Label();
            this.textCPFactuCli = new System.Windows.Forms.TextBox();
            this.lblVilleFactuCli = new System.Windows.Forms.Label();
            this.textVilleFactCli = new System.Windows.Forms.TextBox();
            this.lblRueLivraisonCli = new System.Windows.Forms.Label();
            this.textRueLivraisonCli = new System.Windows.Forms.TextBox();
            this.lblCodePostalLivraiCli = new System.Windows.Forms.Label();
            this.CodePostalLivraiCli = new System.Windows.Forms.TextBox();
            this.lblVilleLivraiCli = new System.Windows.Forms.Label();
            this.textVilleLivraiCli = new System.Windows.Forms.TextBox();
            this.lblErrorClient = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelDelete = new System.Windows.Forms.Panel();
            this.MessageDelete2 = new System.Windows.Forms.Label();
            this.MessageDelete1 = new System.Windows.Forms.Label();
            this.AnnulerDelete = new System.Windows.Forms.Button();
            this.ConfirmerDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.panel1.SuspendLayout();
            this.PanelDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // retSynt
            // 
            this.retSynt.Location = new System.Drawing.Point(21, 752);
            this.retSynt.Name = "retSynt";
            this.retSynt.Size = new System.Drawing.Size(94, 29);
            this.retSynt.TabIndex = 2;
            this.retSynt.Text = "Retour";
            this.retSynt.UseVisualStyleBackColor = true;
            this.retSynt.Click += new System.EventHandler(this.retSynt_Click);
            // 
            // actualiserProduit
            // 
            this.actualiserProduit.Location = new System.Drawing.Point(21, 173);
            this.actualiserProduit.Name = "actualiserProduit";
            this.actualiserProduit.Size = new System.Drawing.Size(94, 29);
            this.actualiserProduit.TabIndex = 5;
            this.actualiserProduit.Text = "Actualiser";
            this.actualiserProduit.UseVisualStyleBackColor = true;
            this.actualiserProduit.Click += new System.EventHandler(this.actualiserClient_Click);
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.AllowUserToDeleteRows = false;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.fax,
            this.dataGridViewTextBoxColumn5,
            this.Rue_Fac,
            this.cp_fact,
            this.ville_fact,
            this.rue_liv,
            this.cp_liv,
            this.ville_liv});
            this.dgvClient.Location = new System.Drawing.Point(21, 229);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            this.dgvClient.RowHeadersWidth = 51;
            this.dgvClient.RowTemplate.Height = 29;
            this.dgvClient.Size = new System.Drawing.Size(554, 500);
            this.dgvClient.TabIndex = 3;
            this.dgvClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduit_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Code";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // fax
            // 
            this.fax.HeaderText = "Fax";
            this.fax.MinimumWidth = 6;
            this.fax.Name = "fax";
            this.fax.ReadOnly = true;
            this.fax.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Téléphone";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // Rue_Fac
            // 
            this.Rue_Fac.HeaderText = "Rue facturation";
            this.Rue_Fac.MinimumWidth = 6;
            this.Rue_Fac.Name = "Rue_Fac";
            this.Rue_Fac.ReadOnly = true;
            this.Rue_Fac.Width = 125;
            // 
            // cp_fact
            // 
            this.cp_fact.HeaderText = "Code postal facturation";
            this.cp_fact.MinimumWidth = 6;
            this.cp_fact.Name = "cp_fact";
            this.cp_fact.ReadOnly = true;
            this.cp_fact.Width = 125;
            // 
            // ville_fact
            // 
            this.ville_fact.HeaderText = "Ville facturation";
            this.ville_fact.MinimumWidth = 6;
            this.ville_fact.Name = "ville_fact";
            this.ville_fact.ReadOnly = true;
            this.ville_fact.Width = 125;
            // 
            // rue_liv
            // 
            this.rue_liv.HeaderText = "Rue livraison";
            this.rue_liv.MinimumWidth = 6;
            this.rue_liv.Name = "rue_liv";
            this.rue_liv.ReadOnly = true;
            this.rue_liv.Width = 125;
            // 
            // cp_liv
            // 
            this.cp_liv.HeaderText = "Code postal livraison";
            this.cp_liv.MinimumWidth = 6;
            this.cp_liv.Name = "cp_liv";
            this.cp_liv.ReadOnly = true;
            this.cp_liv.Width = 125;
            // 
            // ville_liv
            // 
            this.ville_liv.HeaderText = "Ville livraison";
            this.ville_liv.MinimumWidth = 6;
            this.ville_liv.Name = "ville_liv";
            this.ville_liv.ReadOnly = true;
            this.ville_liv.Width = 125;
            // 
            // Telephone
            // 
            this.Telephone.HeaderText = "Telephone";
            this.Telephone.MinimumWidth = 6;
            this.Telephone.Name = "Telephone";
            this.Telephone.Width = 125;
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.MinimumWidth = 6;
            this.Code.Name = "Code";
            this.Code.Width = 125;
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.MinimumWidth = 6;
            this.Prenom.Name = "Prenom";
            this.Prenom.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // lblProduit
            // 
            this.lblProduit.AutoSize = true;
            this.lblProduit.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProduit.Location = new System.Drawing.Point(350, 64);
            this.lblProduit.Name = "lblProduit";
            this.lblProduit.Size = new System.Drawing.Size(502, 72);
            this.lblProduit.TabIndex = 1;
            this.lblProduit.Text = "Gestion des clients";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.Width = 125;
            // 
            // ModifierCli
            // 
            this.ModifierCli.Location = new System.Drawing.Point(262, 561);
            this.ModifierCli.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ModifierCli.Name = "ModifierCli";
            this.ModifierCli.Size = new System.Drawing.Size(101, 27);
            this.ModifierCli.TabIndex = 6;
            this.ModifierCli.Text = "Modifier";
            this.ModifierCli.UseVisualStyleBackColor = true;
            this.ModifierCli.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // SupprimerCli
            // 
            this.SupprimerCli.Location = new System.Drawing.Point(456, 563);
            this.SupprimerCli.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SupprimerCli.Name = "SupprimerCli";
            this.SupprimerCli.Size = new System.Drawing.Size(103, 27);
            this.SupprimerCli.TabIndex = 7;
            this.SupprimerCli.Text = "Supprimer";
            this.SupprimerCli.UseVisualStyleBackColor = true;
            this.SupprimerCli.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // textCodeCli
            // 
            this.textCodeCli.Enabled = false;
            this.textCodeCli.Location = new System.Drawing.Point(27, 172);
            this.textCodeCli.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textCodeCli.Name = "textCodeCli";
            this.textCodeCli.Size = new System.Drawing.Size(170, 27);
            this.textCodeCli.TabIndex = 8;
            // 
            // textNomCli
            // 
            this.textNomCli.Location = new System.Drawing.Point(27, 261);
            this.textNomCli.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textNomCli.Name = "textNomCli";
            this.textNomCli.Size = new System.Drawing.Size(170, 27);
            this.textNomCli.TabIndex = 9;
            // 
            // textPrenomCli
            // 
            this.textPrenomCli.Location = new System.Drawing.Point(27, 355);
            this.textPrenomCli.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textPrenomCli.Name = "textPrenomCli";
            this.textPrenomCli.Size = new System.Drawing.Size(170, 27);
            this.textPrenomCli.TabIndex = 10;
            // 
            // LabelDetails
            // 
            this.LabelDetails.AutoSize = true;
            this.LabelDetails.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelDetails.Location = new System.Drawing.Point(229, 19);
            this.LabelDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelDetails.Name = "LabelDetails";
            this.LabelDetails.Size = new System.Drawing.Size(177, 67);
            this.LabelDetails.TabIndex = 12;
            this.LabelDetails.Text = "Détails";
            // 
            // lblNomCli
            // 
            this.lblNomCli.AutoSize = true;
            this.lblNomCli.Location = new System.Drawing.Point(27, 239);
            this.lblNomCli.Name = "lblNomCli";
            this.lblNomCli.Size = new System.Drawing.Size(49, 20);
            this.lblNomCli.TabIndex = 14;
            this.lblNomCli.Text = "Nom :";
            // 
            // lblCodeCli
            // 
            this.lblCodeCli.AutoSize = true;
            this.lblCodeCli.Location = new System.Drawing.Point(27, 149);
            this.lblCodeCli.Name = "lblCodeCli";
            this.lblCodeCli.Size = new System.Drawing.Size(51, 20);
            this.lblCodeCli.TabIndex = 15;
            this.lblCodeCli.Text = "Code :";
            // 
            // lblPrenomCli
            // 
            this.lblPrenomCli.AutoSize = true;
            this.lblPrenomCli.Location = new System.Drawing.Point(27, 331);
            this.lblPrenomCli.Name = "lblPrenomCli";
            this.lblPrenomCli.Size = new System.Drawing.Size(67, 20);
            this.lblPrenomCli.TabIndex = 16;
            this.lblPrenomCli.Text = "Prénom :";
            // 
            // AjouterCli
            // 
            this.AjouterCli.Location = new System.Drawing.Point(63, 560);
            this.AjouterCli.Name = "AjouterCli";
            this.AjouterCli.Size = new System.Drawing.Size(101, 29);
            this.AjouterCli.TabIndex = 19;
            this.AjouterCli.Text = "Ajouter";
            this.AjouterCli.UseVisualStyleBackColor = true;
            this.AjouterCli.Click += new System.EventHandler(this.AjouterCli_Click);
            // 
            // textEmailCli
            // 
            this.textEmailCli.Location = new System.Drawing.Point(27, 449);
            this.textEmailCli.Name = "textEmailCli";
            this.textEmailCli.Size = new System.Drawing.Size(174, 27);
            this.textEmailCli.TabIndex = 20;
            // 
            // lblEmailCli
            // 
            this.lblEmailCli.AutoSize = true;
            this.lblEmailCli.Location = new System.Drawing.Point(27, 427);
            this.lblEmailCli.Name = "lblEmailCli";
            this.lblEmailCli.Size = new System.Drawing.Size(53, 20);
            this.lblEmailCli.TabIndex = 21;
            this.lblEmailCli.Text = "Email :";
            // 
            // lblTelCli
            // 
            this.lblTelCli.AutoSize = true;
            this.lblTelCli.Location = new System.Drawing.Point(229, 149);
            this.lblTelCli.Name = "lblTelCli";
            this.lblTelCli.Size = new System.Drawing.Size(85, 20);
            this.lblTelCli.TabIndex = 22;
            this.lblTelCli.Text = "Téléphone :";
            // 
            // lblFaxCli
            // 
            this.lblFaxCli.AutoSize = true;
            this.lblFaxCli.Location = new System.Drawing.Point(423, 147);
            this.lblFaxCli.Name = "lblFaxCli";
            this.lblFaxCli.Size = new System.Drawing.Size(37, 20);
            this.lblFaxCli.TabIndex = 23;
            this.lblFaxCli.Text = "Fax :";
            // 
            // textTelCli
            // 
            this.textTelCli.Location = new System.Drawing.Point(229, 172);
            this.textTelCli.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textTelCli.Name = "textTelCli";
            this.textTelCli.Size = new System.Drawing.Size(172, 27);
            this.textTelCli.TabIndex = 24;
            // 
            // textFaxCli
            // 
            this.textFaxCli.Location = new System.Drawing.Point(423, 172);
            this.textFaxCli.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textFaxCli.Name = "textFaxCli";
            this.textFaxCli.Size = new System.Drawing.Size(172, 27);
            this.textFaxCli.TabIndex = 25;
            // 
            // lblRueFactCli
            // 
            this.lblRueFactCli.AutoSize = true;
            this.lblRueFactCli.Location = new System.Drawing.Point(229, 331);
            this.lblRueFactCli.Name = "lblRueFactCli";
            this.lblRueFactCli.Size = new System.Drawing.Size(117, 20);
            this.lblRueFactCli.TabIndex = 26;
            this.lblRueFactCli.Text = "Rue facturation :";
            // 
            // textRueFactuCli
            // 
            this.textRueFactuCli.Location = new System.Drawing.Point(229, 355);
            this.textRueFactuCli.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textRueFactuCli.Name = "textRueFactuCli";
            this.textRueFactuCli.Size = new System.Drawing.Size(172, 27);
            this.textRueFactuCli.TabIndex = 27;
            // 
            // lblCodePostalFactuCli
            // 
            this.lblCodePostalFactuCli.AutoSize = true;
            this.lblCodePostalFactuCli.Location = new System.Drawing.Point(229, 427);
            this.lblCodePostalFactuCli.Name = "lblCodePostalFactuCli";
            this.lblCodePostalFactuCli.Size = new System.Drawing.Size(172, 20);
            this.lblCodePostalFactuCli.TabIndex = 20;
            this.lblCodePostalFactuCli.Text = "Code postal facturation :";
            // 
            // textCPFactuCli
            // 
            this.textCPFactuCli.Location = new System.Drawing.Point(229, 449);
            this.textCPFactuCli.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textCPFactuCli.Name = "textCPFactuCli";
            this.textCPFactuCli.Size = new System.Drawing.Size(172, 27);
            this.textCPFactuCli.TabIndex = 28;
            // 
            // lblVilleFactuCli
            // 
            this.lblVilleFactuCli.AutoSize = true;
            this.lblVilleFactuCli.Location = new System.Drawing.Point(229, 239);
            this.lblVilleFactuCli.Name = "lblVilleFactuCli";
            this.lblVilleFactuCli.Size = new System.Drawing.Size(121, 20);
            this.lblVilleFactuCli.TabIndex = 29;
            this.lblVilleFactuCli.Text = "Ville facturation :";
            // 
            // textVilleFactCli
            // 
            this.textVilleFactCli.Location = new System.Drawing.Point(229, 262);
            this.textVilleFactCli.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textVilleFactCli.Name = "textVilleFactCli";
            this.textVilleFactCli.Size = new System.Drawing.Size(172, 27);
            this.textVilleFactCli.TabIndex = 30;
            // 
            // lblRueLivraisonCli
            // 
            this.lblRueLivraisonCli.AutoSize = true;
            this.lblRueLivraisonCli.Location = new System.Drawing.Point(423, 332);
            this.lblRueLivraisonCli.Name = "lblRueLivraisonCli";
            this.lblRueLivraisonCli.Size = new System.Drawing.Size(100, 20);
            this.lblRueLivraisonCli.TabIndex = 31;
            this.lblRueLivraisonCli.Text = "Rue livraison :";
            // 
            // textRueLivraisonCli
            // 
            this.textRueLivraisonCli.Location = new System.Drawing.Point(423, 355);
            this.textRueLivraisonCli.Name = "textRueLivraisonCli";
            this.textRueLivraisonCli.Size = new System.Drawing.Size(172, 27);
            this.textRueLivraisonCli.TabIndex = 21;
            // 
            // lblCodePostalLivraiCli
            // 
            this.lblCodePostalLivraiCli.AutoSize = true;
            this.lblCodePostalLivraiCli.Location = new System.Drawing.Point(423, 426);
            this.lblCodePostalLivraiCli.Name = "lblCodePostalLivraiCli";
            this.lblCodePostalLivraiCli.Size = new System.Drawing.Size(155, 20);
            this.lblCodePostalLivraiCli.TabIndex = 32;
            this.lblCodePostalLivraiCli.Text = "Code postal livraison :";
            // 
            // CodePostalLivraiCli
            // 
            this.CodePostalLivraiCli.Location = new System.Drawing.Point(423, 449);
            this.CodePostalLivraiCli.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CodePostalLivraiCli.Name = "CodePostalLivraiCli";
            this.CodePostalLivraiCli.Size = new System.Drawing.Size(172, 27);
            this.CodePostalLivraiCli.TabIndex = 33;
            // 
            // lblVilleLivraiCli
            // 
            this.lblVilleLivraiCli.AutoSize = true;
            this.lblVilleLivraiCli.Location = new System.Drawing.Point(423, 238);
            this.lblVilleLivraiCli.Name = "lblVilleLivraiCli";
            this.lblVilleLivraiCli.Size = new System.Drawing.Size(104, 20);
            this.lblVilleLivraiCli.TabIndex = 34;
            this.lblVilleLivraiCli.Text = "Ville livraison :";
            this.lblVilleLivraiCli.Click += new System.EventHandler(this.lblVilleLivraiCli_Click);
            // 
            // textVilleLivraiCli
            // 
            this.textVilleLivraiCli.Location = new System.Drawing.Point(423, 262);
            this.textVilleLivraiCli.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textVilleLivraiCli.Name = "textVilleLivraiCli";
            this.textVilleLivraiCli.Size = new System.Drawing.Size(172, 27);
            this.textVilleLivraiCli.TabIndex = 35;
            // 
            // lblErrorClient
            // 
            this.lblErrorClient.AutoSize = true;
            this.lblErrorClient.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblErrorClient.Location = new System.Drawing.Point(201, 509);
            this.lblErrorClient.Name = "lblErrorClient";
            this.lblErrorClient.Size = new System.Drawing.Size(242, 20);
            this.lblErrorClient.TabIndex = 37;
            this.lblErrorClient.Text = "Veuillez renseigner tous les champs";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblErrorClient);
            this.panel1.Controls.Add(this.textVilleLivraiCli);
            this.panel1.Controls.Add(this.lblVilleLivraiCli);
            this.panel1.Controls.Add(this.CodePostalLivraiCli);
            this.panel1.Controls.Add(this.lblCodePostalLivraiCli);
            this.panel1.Controls.Add(this.textRueLivraisonCli);
            this.panel1.Controls.Add(this.lblRueLivraisonCli);
            this.panel1.Controls.Add(this.textVilleFactCli);
            this.panel1.Controls.Add(this.lblVilleFactuCli);
            this.panel1.Controls.Add(this.textCPFactuCli);
            this.panel1.Controls.Add(this.lblCodePostalFactuCli);
            this.panel1.Controls.Add(this.textRueFactuCli);
            this.panel1.Controls.Add(this.lblRueFactCli);
            this.panel1.Controls.Add(this.textFaxCli);
            this.panel1.Controls.Add(this.textTelCli);
            this.panel1.Controls.Add(this.lblFaxCli);
            this.panel1.Controls.Add(this.lblTelCli);
            this.panel1.Controls.Add(this.lblEmailCli);
            this.panel1.Controls.Add(this.textEmailCli);
            this.panel1.Controls.Add(this.AjouterCli);
            this.panel1.Controls.Add(this.lblPrenomCli);
            this.panel1.Controls.Add(this.lblCodeCli);
            this.panel1.Controls.Add(this.lblNomCli);
            this.panel1.Controls.Add(this.LabelDetails);
            this.panel1.Controls.Add(this.textPrenomCli);
            this.panel1.Controls.Add(this.textNomCli);
            this.panel1.Controls.Add(this.textCodeCli);
            this.panel1.Controls.Add(this.SupprimerCli);
            this.panel1.Controls.Add(this.ModifierCli);
            this.panel1.Location = new System.Drawing.Point(599, 173);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 608);
            this.panel1.TabIndex = 7;
            // 
            // PanelDelete
            // 
            this.PanelDelete.Controls.Add(this.MessageDelete2);
            this.PanelDelete.Controls.Add(this.MessageDelete1);
            this.PanelDelete.Controls.Add(this.AnnulerDelete);
            this.PanelDelete.Controls.Add(this.ConfirmerDelete);
            this.PanelDelete.Location = new System.Drawing.Point(462, 320);
            this.PanelDelete.Margin = new System.Windows.Forms.Padding(2);
            this.PanelDelete.Name = "PanelDelete";
            this.PanelDelete.Size = new System.Drawing.Size(309, 164);
            this.PanelDelete.TabIndex = 23;
            // 
            // MessageDelete2
            // 
            this.MessageDelete2.AutoSize = true;
            this.MessageDelete2.Location = new System.Drawing.Point(85, 42);
            this.MessageDelete2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MessageDelete2.Name = "MessageDelete2";
            this.MessageDelete2.Size = new System.Drawing.Size(146, 20);
            this.MessageDelete2.TabIndex = 3;
            this.MessageDelete2.Text = "supprimer ce client ?";
            this.MessageDelete2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MessageDelete1
            // 
            this.MessageDelete1.AutoSize = true;
            this.MessageDelete1.Location = new System.Drawing.Point(64, 22);
            this.MessageDelete1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MessageDelete1.Name = "MessageDelete1";
            this.MessageDelete1.Size = new System.Drawing.Size(184, 20);
            this.MessageDelete1.TabIndex = 2;
            this.MessageDelete1.Text = "Êtes-vous sûr(e) de vouloir";
            // 
            // AnnulerDelete
            // 
            this.AnnulerDelete.Location = new System.Drawing.Point(178, 112);
            this.AnnulerDelete.Margin = new System.Windows.Forms.Padding(2);
            this.AnnulerDelete.Name = "AnnulerDelete";
            this.AnnulerDelete.Size = new System.Drawing.Size(90, 27);
            this.AnnulerDelete.TabIndex = 1;
            this.AnnulerDelete.Text = "Non";
            this.AnnulerDelete.UseVisualStyleBackColor = true;
            this.AnnulerDelete.Click += new System.EventHandler(this.AnnulerDelete_Click);
            // 
            // ConfirmerDelete
            // 
            this.ConfirmerDelete.Location = new System.Drawing.Point(39, 112);
            this.ConfirmerDelete.Margin = new System.Windows.Forms.Padding(2);
            this.ConfirmerDelete.Name = "ConfirmerDelete";
            this.ConfirmerDelete.Size = new System.Drawing.Size(90, 27);
            this.ConfirmerDelete.TabIndex = 0;
            this.ConfirmerDelete.Text = "Oui";
            this.ConfirmerDelete.UseVisualStyleBackColor = true;
            this.ConfirmerDelete.Click += new System.EventHandler(this.ConfirmerDelete_Click);
            // 
            // FrmListeClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1232, 803);
            this.Controls.Add(this.PanelDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.actualiserProduit);
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.retSynt);
            this.Controls.Add(this.lblProduit);
            this.Name = "FrmListeClients";
            this.Text = "ListeProduitsForms";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelDelete.ResumeLayout(false);
            this.PanelDelete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button retSynt;
        private Button actualiserProduit;
        private DataGridView dgvClient;
        private DataGridViewTextBoxColumn Telephone;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn Prenom;
        private DataGridViewTextBoxColumn Email;
        private Label lblProduit;
        private DataGridViewTextBoxColumn Nom;
        private Button ModifierCli;
        private Button SupprimerCli;
        private TextBox textCodeCli;
        private TextBox textNomCli;
        private TextBox textPrenomCli;
        private Label LabelDetails;
        private Label lblNomCli;
        private Label lblCodeCli;
        private Label lblPrenomCli;
        private Button AjouterCli;
        private TextBox textEmailCli;
        private Label lblEmailCli;
        private Label lblTelCli;
        private Label lblFaxCli;
        private TextBox textTelCli;
        private TextBox textFaxCli;
        private Label lblRueFactCli;
        private TextBox textRueFactuCli;
        private Label lblCodePostalFactuCli;
        private TextBox textCPFactuCli;
        private Label lblVilleFactuCli;
        private TextBox textVilleFactCli;
        private Label lblRueLivraisonCli;
        private TextBox textRueLivraisonCli;
        private Label lblCodePostalLivraiCli;
        private TextBox CodePostalLivraiCli;
        private Label lblVilleLivraiCli;
        private TextBox textVilleLivraiCli;
        private Label lblErrorClient;
        private Panel panel1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn fax;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn Rue_Fac;
        private DataGridViewTextBoxColumn cp_fact;
        private DataGridViewTextBoxColumn ville_fact;
        private DataGridViewTextBoxColumn rue_liv;
        private DataGridViewTextBoxColumn cp_liv;
        private DataGridViewTextBoxColumn ville_liv;
        private Panel PanelDelete;
        private Label MessageDelete2;
        private Label MessageDelete1;
        private Button AnnulerDelete;
        private Button ConfirmerDelete;
    }
}