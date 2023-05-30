namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class ListeEtudiant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeEtudiant));
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.PanelQuitter = new System.Windows.Forms.Panel();
            this.bQuitter = new System.Windows.Forms.Button();
            this.PanelInterieur = new System.Windows.Forms.Panel();
            this.dgvEtudiants = new System.Windows.Forms.DataGridView();
            this.nomEtudiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomEtudiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvListeEtudiant = new System.Windows.Forms.DataGridView();
            this.bFermer = new System.Windows.Forms.Button();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.PanelInterieur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtudiants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeEtudiant)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.pbLogo);
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(84, 90);
            this.PanelLogo.TabIndex = 10;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(3, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(78, 87);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // PanelQuitter
            // 
            this.PanelQuitter.Location = new System.Drawing.Point(899, 0);
            this.PanelQuitter.Name = "PanelQuitter";
            this.PanelQuitter.Size = new System.Drawing.Size(123, 46);
            this.PanelQuitter.TabIndex = 11;
            // 
            // bQuitter
            // 
            this.bQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bQuitter.BackColor = System.Drawing.Color.Green;
            this.bQuitter.ForeColor = System.Drawing.Color.White;
            this.bQuitter.Location = new System.Drawing.Point(895, 82);
            this.bQuitter.Name = "bQuitter";
            this.bQuitter.Size = new System.Drawing.Size(127, 41);
            this.bQuitter.TabIndex = 7;
            this.bQuitter.Text = "QUITTER";
            this.bQuitter.UseVisualStyleBackColor = false;
            this.bQuitter.Click += new System.EventHandler(this.bQuitter_Click);
            // 
            // PanelInterieur
            // 
            this.PanelInterieur.Controls.Add(this.dgvEtudiants);
            this.PanelInterieur.Controls.Add(this.dgvListeEtudiant);
            this.PanelInterieur.Location = new System.Drawing.Point(87, 35);
            this.PanelInterieur.Name = "PanelInterieur";
            this.PanelInterieur.Size = new System.Drawing.Size(806, 482);
            this.PanelInterieur.TabIndex = 12;
            // 
            // dgvEtudiants
            // 
            this.dgvEtudiants.AllowUserToAddRows = false;
            this.dgvEtudiants.AllowUserToDeleteRows = false;
            this.dgvEtudiants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEtudiants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEtudiants.BackgroundColor = System.Drawing.Color.Green;
            this.dgvEtudiants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtudiants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomEtudiant,
            this.prenomEtudiant,
            this.Classe,
            this.Tel,
            this.Email,
            this.Adresse});
            this.dgvEtudiants.GridColor = System.Drawing.Color.White;
            this.dgvEtudiants.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvEtudiants.Location = new System.Drawing.Point(0, 0);
            this.dgvEtudiants.MultiSelect = false;
            this.dgvEtudiants.Name = "dgvEtudiants";
            this.dgvEtudiants.ReadOnly = true;
            this.dgvEtudiants.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvEtudiants.Size = new System.Drawing.Size(806, 476);
            this.dgvEtudiants.TabIndex = 1;
            this.dgvEtudiants.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEtudiants_CellContentClick);
            // 
            // nomEtudiant
            // 
            this.nomEtudiant.HeaderText = "nom";
            this.nomEtudiant.MinimumWidth = 6;
            this.nomEtudiant.Name = "nomEtudiant";
            this.nomEtudiant.ReadOnly = true;
            // 
            // prenomEtudiant
            // 
            this.prenomEtudiant.HeaderText = "Prénom";
            this.prenomEtudiant.MinimumWidth = 6;
            this.prenomEtudiant.Name = "prenomEtudiant";
            this.prenomEtudiant.ReadOnly = true;
            // 
            // Classe
            // 
            this.Classe.HeaderText = "Rue";
            this.Classe.MinimumWidth = 6;
            this.Classe.Name = "Classe";
            this.Classe.ReadOnly = true;
            // 
            // Tel
            // 
            this.Tel.HeaderText = "EMail";
            this.Tel.MinimumWidth = 6;
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Tel";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Adresse
            // 
            this.Adresse.HeaderText = "Classe";
            this.Adresse.MinimumWidth = 6;
            this.Adresse.Name = "Adresse";
            this.Adresse.ReadOnly = true;
            // 
            // dgvListeEtudiant
            // 
            this.dgvListeEtudiant.AllowUserToOrderColumns = true;
            this.dgvListeEtudiant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvListeEtudiant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListeEtudiant.BackgroundColor = System.Drawing.Color.White;
            this.dgvListeEtudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeEtudiant.GridColor = System.Drawing.Color.SkyBlue;
            this.dgvListeEtudiant.Location = new System.Drawing.Point(0, 0);
            this.dgvListeEtudiant.Name = "dgvListeEtudiant";
            this.dgvListeEtudiant.RowHeadersWidth = 51;
            this.dgvListeEtudiant.Size = new System.Drawing.Size(806, 482);
            this.dgvListeEtudiant.TabIndex = 0;
            this.dgvListeEtudiant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListeEtudiant_CellContentClick);
            // 
            // bFermer
            // 
            this.bFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bFermer.AutoSize = true;
            this.bFermer.BackColor = System.Drawing.Color.Green;
            this.bFermer.ForeColor = System.Drawing.Color.White;
            this.bFermer.Location = new System.Drawing.Point(895, 35);
            this.bFermer.Name = "bFermer";
            this.bFermer.Size = new System.Drawing.Size(127, 41);
            this.bFermer.TabIndex = 13;
            this.bFermer.Text = "FERMER";
            this.bFermer.UseVisualStyleBackColor = false;
            this.bFermer.Click += new System.EventHandler(this.bFermer_Click);
            // 
            // ListeEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 529);
            this.Controls.Add(this.bQuitter);
            this.Controls.Add(this.bFermer);
            this.Controls.Add(this.PanelInterieur);
            this.Controls.Add(this.PanelQuitter);
            this.Controls.Add(this.PanelLogo);
            this.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ListeEtudiant";
            this.Text = "Liste des Etudiants";
            this.Load += new System.EventHandler(this.ListeEtudiant_Load);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.PanelInterieur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtudiants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeEtudiant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel PanelQuitter;
        private System.Windows.Forms.Button bQuitter;
        private System.Windows.Forms.Panel PanelInterieur;
        private System.Windows.Forms.DataGridView dgvListeEtudiant;
        //   private P2022_Appli_AdministrationDataSetTableAdapters.etudiantTableAdapter etudiantTableAdapter;
        private System.Windows.Forms.Button bFermer;
        private System.Windows.Forms.DataGridView dgvEtudiants;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomEtudiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomEtudiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
    }
}