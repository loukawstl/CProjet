namespace GestionGUI
{
    partial class FrmListeProduits
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
            this.lblProduit = new System.Windows.Forms.Label();
            this.retSynt = new System.Windows.Forms.Button();
            this.dgvProduit = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualiserProduit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addPro = new System.Windows.Forms.Button();
            this.lblErrorCategorie = new System.Windows.Forms.Label();
            this.lblErrorPrix = new System.Windows.Forms.Label();
            this.lblErrorLibellé = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLibelleProAdd = new System.Windows.Forms.Label();
            this.lblCatAddPro = new System.Windows.Forms.Label();
            this.listCategorie = new System.Windows.Forms.ListBox();
            this.LabelDetails = new System.Windows.Forms.Label();
            this.textPrix = new System.Windows.Forms.TextBox();
            this.textLibelle = new System.Windows.Forms.TextBox();
            this.textCode = new System.Windows.Forms.TextBox();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.PanelDelete = new System.Windows.Forms.Panel();
            this.MessageDelete2 = new System.Windows.Forms.Label();
            this.MessageDelete1 = new System.Windows.Forms.Label();
            this.AnnulerDelete = new System.Windows.Forms.Button();
            this.ConfirmerDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).BeginInit();
            this.panel1.SuspendLayout();
            this.PanelDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProduit
            // 
            this.lblProduit.AutoSize = true;
            this.lblProduit.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProduit.Location = new System.Drawing.Point(350, 64);
            this.lblProduit.Name = "lblProduit";
            this.lblProduit.Size = new System.Drawing.Size(552, 72);
            this.lblProduit.TabIndex = 1;
            this.lblProduit.Text = "Gestion des produits";
            // 
            // retSynt
            // 
            this.retSynt.Location = new System.Drawing.Point(11, 762);
            this.retSynt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.retSynt.Name = "retSynt";
            this.retSynt.Size = new System.Drawing.Size(94, 30);
            this.retSynt.TabIndex = 2;
            this.retSynt.Text = "Retour";
            this.retSynt.UseVisualStyleBackColor = true;
            this.retSynt.Click += new System.EventHandler(this.retSynt_Click);
            // 
            // dgvProduit
            // 
            this.dgvProduit.AllowUserToAddRows = false;
            this.dgvProduit.AllowUserToDeleteRows = false;
            this.dgvProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Libelle,
            this.Prix,
            this.Categorie});
            this.dgvProduit.Location = new System.Drawing.Point(26, 230);
            this.dgvProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProduit.Name = "dgvProduit";
            this.dgvProduit.ReadOnly = true;
            this.dgvProduit.RowHeadersWidth = 51;
            this.dgvProduit.RowTemplate.Height = 29;
            this.dgvProduit.Size = new System.Drawing.Size(554, 500);
            this.dgvProduit.TabIndex = 3;
            this.dgvProduit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduit_CellClick);
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.MinimumWidth = 6;
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 125;
            // 
            // Libelle
            // 
            this.Libelle.HeaderText = "Libelle";
            this.Libelle.MinimumWidth = 6;
            this.Libelle.Name = "Libelle";
            this.Libelle.ReadOnly = true;
            this.Libelle.Width = 125;
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.MinimumWidth = 6;
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            this.Prix.Width = 125;
            // 
            // Categorie
            // 
            this.Categorie.HeaderText = "Categorie";
            this.Categorie.MinimumWidth = 6;
            this.Categorie.Name = "Categorie";
            this.Categorie.ReadOnly = true;
            this.Categorie.Width = 125;
            // 
            // actualiserProduit
            // 
            this.actualiserProduit.Location = new System.Drawing.Point(26, 182);
            this.actualiserProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.actualiserProduit.Name = "actualiserProduit";
            this.actualiserProduit.Size = new System.Drawing.Size(94, 30);
            this.actualiserProduit.TabIndex = 5;
            this.actualiserProduit.Text = "Actualiser";
            this.actualiserProduit.UseVisualStyleBackColor = true;
            this.actualiserProduit.Click += new System.EventHandler(this.actualiserProduit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addPro);
            this.panel1.Controls.Add(this.lblErrorCategorie);
            this.panel1.Controls.Add(this.lblErrorPrix);
            this.panel1.Controls.Add(this.lblErrorLibellé);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblLibelleProAdd);
            this.panel1.Controls.Add(this.lblCatAddPro);
            this.panel1.Controls.Add(this.listCategorie);
            this.panel1.Controls.Add(this.LabelDetails);
            this.panel1.Controls.Add(this.textPrix);
            this.panel1.Controls.Add(this.textLibelle);
            this.panel1.Controls.Add(this.textCode);
            this.panel1.Controls.Add(this.Supprimer);
            this.panel1.Controls.Add(this.Modifier);
            this.panel1.Location = new System.Drawing.Point(703, 230);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 500);
            this.panel1.TabIndex = 8;
            // 
            // addPro
            // 
            this.addPro.Location = new System.Drawing.Point(71, 442);
            this.addPro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPro.Name = "addPro";
            this.addPro.Size = new System.Drawing.Size(94, 30);
            this.addPro.TabIndex = 19;
            this.addPro.Text = "Ajouter";
            this.addPro.UseVisualStyleBackColor = true;
            this.addPro.Click += new System.EventHandler(this.addPro_Click);
            // 
            // lblErrorCategorie
            // 
            this.lblErrorCategorie.AutoSize = true;
            this.lblErrorCategorie.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblErrorCategorie.Location = new System.Drawing.Point(283, 291);
            this.lblErrorCategorie.Name = "lblErrorCategorie";
            this.lblErrorCategorie.Size = new System.Drawing.Size(121, 20);
            this.lblErrorCategorie.TabIndex = 15;
            this.lblErrorCategorie.Text = "Catég. incorrecte";
            // 
            // lblErrorPrix
            // 
            this.lblErrorPrix.AutoSize = true;
            this.lblErrorPrix.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblErrorPrix.Location = new System.Drawing.Point(143, 269);
            this.lblErrorPrix.Name = "lblErrorPrix";
            this.lblErrorPrix.Size = new System.Drawing.Size(95, 20);
            this.lblErrorPrix.TabIndex = 18;
            this.lblErrorPrix.Text = "Prix incorrect";
            // 
            // lblErrorLibellé
            // 
            this.lblErrorLibellé.AutoSize = true;
            this.lblErrorLibellé.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblErrorLibellé.Location = new System.Drawing.Point(283, 201);
            this.lblErrorLibellé.Name = "lblErrorLibellé";
            this.lblErrorLibellé.Size = new System.Drawing.Size(115, 20);
            this.lblErrorLibellé.TabIndex = 17;
            this.lblErrorLibellé.Text = "Libellé incorrect";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Prix :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Code :";
            // 
            // lblLibelleProAdd
            // 
            this.lblLibelleProAdd.AutoSize = true;
            this.lblLibelleProAdd.Location = new System.Drawing.Point(283, 150);
            this.lblLibelleProAdd.Name = "lblLibelleProAdd";
            this.lblLibelleProAdd.Size = new System.Drawing.Size(60, 20);
            this.lblLibelleProAdd.TabIndex = 14;
            this.lblLibelleProAdd.Text = "Libellé :";
            // 
            // lblCatAddPro
            // 
            this.lblCatAddPro.AutoSize = true;
            this.lblCatAddPro.Location = new System.Drawing.Point(283, 221);
            this.lblCatAddPro.Name = "lblCatAddPro";
            this.lblCatAddPro.Size = new System.Drawing.Size(81, 20);
            this.lblCatAddPro.TabIndex = 12;
            this.lblCatAddPro.Text = "Catégorie :";
            // 
            // listCategorie
            // 
            this.listCategorie.FormattingEnabled = true;
            this.listCategorie.ItemHeight = 20;
            this.listCategorie.Location = new System.Drawing.Point(283, 245);
            this.listCategorie.Margin = new System.Windows.Forms.Padding(2);
            this.listCategorie.Name = "listCategorie";
            this.listCategorie.Size = new System.Drawing.Size(103, 44);
            this.listCategorie.TabIndex = 13;
            // 
            // LabelDetails
            // 
            this.LabelDetails.AutoSize = true;
            this.LabelDetails.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelDetails.Location = new System.Drawing.Point(165, 22);
            this.LabelDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelDetails.Name = "LabelDetails";
            this.LabelDetails.Size = new System.Drawing.Size(177, 67);
            this.LabelDetails.TabIndex = 12;
            this.LabelDetails.Text = "Détails";
            // 
            // textPrix
            // 
            this.textPrix.Location = new System.Drawing.Point(143, 240);
            this.textPrix.Margin = new System.Windows.Forms.Padding(2);
            this.textPrix.Name = "textPrix";
            this.textPrix.Size = new System.Drawing.Size(101, 27);
            this.textPrix.TabIndex = 10;
            // 
            // textLibelle
            // 
            this.textLibelle.Location = new System.Drawing.Point(283, 172);
            this.textLibelle.Margin = new System.Windows.Forms.Padding(2);
            this.textLibelle.Name = "textLibelle";
            this.textLibelle.Size = new System.Drawing.Size(103, 27);
            this.textLibelle.TabIndex = 9;
            // 
            // textCode
            // 
            this.textCode.Enabled = false;
            this.textCode.Location = new System.Drawing.Point(143, 172);
            this.textCode.Margin = new System.Windows.Forms.Padding(2);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(101, 27);
            this.textCode.TabIndex = 8;
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(326, 444);
            this.Supprimer.Margin = new System.Windows.Forms.Padding(2);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(103, 26);
            this.Supprimer.TabIndex = 7;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(194, 444);
            this.Modifier.Margin = new System.Windows.Forms.Padding(2);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(101, 26);
            this.Modifier.TabIndex = 6;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // PanelDelete
            // 
            this.PanelDelete.Controls.Add(this.MessageDelete2);
            this.PanelDelete.Controls.Add(this.MessageDelete1);
            this.PanelDelete.Controls.Add(this.AnnulerDelete);
            this.PanelDelete.Controls.Add(this.ConfirmerDelete);
            this.PanelDelete.Location = new System.Drawing.Point(451, 352);
            this.PanelDelete.Margin = new System.Windows.Forms.Padding(2);
            this.PanelDelete.Name = "PanelDelete";
            this.PanelDelete.Size = new System.Drawing.Size(309, 164);
            this.PanelDelete.TabIndex = 22;
            // 
            // MessageDelete2
            // 
            this.MessageDelete2.AutoSize = true;
            this.MessageDelete2.Location = new System.Drawing.Point(78, 42);
            this.MessageDelete2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MessageDelete2.Name = "MessageDelete2";
            this.MessageDelete2.Size = new System.Drawing.Size(159, 20);
            this.MessageDelete2.TabIndex = 3;
            this.MessageDelete2.Text = "supprimer ce produit ?";
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
            // FrmListeProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1232, 802);
            this.Controls.Add(this.PanelDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.actualiserProduit);
            this.Controls.Add(this.dgvProduit);
            this.Controls.Add(this.retSynt);
            this.Controls.Add(this.lblProduit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmListeProduits";
            this.Text = "ListeProduitsForms";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelDelete.ResumeLayout(false);
            this.PanelDelete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblProduit;
        private Button retSynt;
        private DataGridView dgvProduit;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn Libelle;
        private DataGridViewTextBoxColumn Prix;
        private DataGridViewTextBoxColumn Categorie;
        private Button actualiserProduit;
        private Panel panel1;
        private Button addPro;
        private Label lblErrorCategorie;
        private Label lblErrorPrix;
        private Label lblErrorLibellé;
        private Label label2;
        private Label label1;
        private Label lblLibelleProAdd;
        private Label lblCatAddPro;
        private ListBox listCategorie;
        private Label LabelDetails;
        private TextBox textPrix;
        private TextBox textLibelle;
        private TextBox textCode;
        private Button Supprimer;
        private Button Modifier;
        private Panel PanelDelete;
        private Label MessageDelete2;
        private Label MessageDelete1;
        private Button AnnulerDelete;
        private Button ConfirmerDelete;
    }
}