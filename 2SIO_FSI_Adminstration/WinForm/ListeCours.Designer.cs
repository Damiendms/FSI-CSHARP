namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class ListeCours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeCours));
            this.bQuitter = new System.Windows.Forms.Button();
            this.bFermer = new System.Windows.Forms.Button();
            this.PanelQuitter = new System.Windows.Forms.Panel();
            this.PanelInterieur = new System.Windows.Forms.Panel();
            this.dgvClasse = new System.Windows.Forms.DataGridView();
            this.nomEtudiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomEtudiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvListeEtudiant = new System.Windows.Forms.DataGridView();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.PanelInterieur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeEtudiant)).BeginInit();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // bQuitter
            // 
            this.bQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bQuitter.BackColor = System.Drawing.Color.Green;
            this.bQuitter.ForeColor = System.Drawing.Color.White;
            this.bQuitter.Location = new System.Drawing.Point(932, 111);
            this.bQuitter.Name = "bQuitter";
            this.bQuitter.Size = new System.Drawing.Size(127, 41);
            this.bQuitter.TabIndex = 14;
            this.bQuitter.Text = "QUITTER";
            this.bQuitter.UseVisualStyleBackColor = false;
            this.bQuitter.Click += new System.EventHandler(this.bQuitter_Click);
            // 
            // bFermer
            // 
            this.bFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bFermer.AutoSize = true;
            this.bFermer.BackColor = System.Drawing.Color.Green;
            this.bFermer.ForeColor = System.Drawing.Color.White;
            this.bFermer.Location = new System.Drawing.Point(932, 64);
            this.bFermer.Name = "bFermer";
            this.bFermer.Size = new System.Drawing.Size(127, 41);
            this.bFermer.TabIndex = 16;
            this.bFermer.Text = "FERMER";
            this.bFermer.UseVisualStyleBackColor = false;
            this.bFermer.Click += new System.EventHandler(this.bFermer_Click);
            // 
            // PanelQuitter
            // 
            this.PanelQuitter.Location = new System.Drawing.Point(932, 12);
            this.PanelQuitter.Name = "PanelQuitter";
            this.PanelQuitter.Size = new System.Drawing.Size(123, 46);
            this.PanelQuitter.TabIndex = 15;
            // 
            // PanelInterieur
            // 
            this.PanelInterieur.Controls.Add(this.dgvClasse);
            this.PanelInterieur.Controls.Add(this.dgvListeEtudiant);
            this.PanelInterieur.Location = new System.Drawing.Point(120, 64);
            this.PanelInterieur.Name = "PanelInterieur";
            this.PanelInterieur.Size = new System.Drawing.Size(806, 482);
            this.PanelInterieur.TabIndex = 17;
            // 
            // dgvClasse
            // 
            this.dgvClasse.AllowUserToAddRows = false;
            this.dgvClasse.AllowUserToDeleteRows = false;
            this.dgvClasse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClasse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClasse.BackgroundColor = System.Drawing.Color.Green;
            this.dgvClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomEtudiant,
            this.prenomEtudiant});
            this.dgvClasse.GridColor = System.Drawing.Color.White;
            this.dgvClasse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvClasse.Location = new System.Drawing.Point(3, 0);
            this.dgvClasse.MultiSelect = false;
            this.dgvClasse.Name = "dgvClasse";
            this.dgvClasse.ReadOnly = true;
            this.dgvClasse.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvClasse.Size = new System.Drawing.Size(806, 476);
            this.dgvClasse.TabIndex = 1;
            this.dgvClasse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClasse_CellContentClick);
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
            this.prenomEtudiant.HeaderText = "Description";
            this.prenomEtudiant.MinimumWidth = 6;
            this.prenomEtudiant.Name = "prenomEtudiant";
            this.prenomEtudiant.ReadOnly = true;
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
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.pbLogo);
            this.PanelLogo.Location = new System.Drawing.Point(12, 12);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(84, 90);
            this.PanelLogo.TabIndex = 18;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(6, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(78, 87);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // ListeCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 584);
            this.Controls.Add(this.PanelLogo);
            this.Controls.Add(this.PanelInterieur);
            this.Controls.Add(this.bQuitter);
            this.Controls.Add(this.bFermer);
            this.Controls.Add(this.PanelQuitter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListeCours";
            this.Text = "ListeCours";
            this.Load += new System.EventHandler(this.ListeCours_Load);
            this.PanelInterieur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeEtudiant)).EndInit();
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bQuitter;
        private System.Windows.Forms.Button bFermer;
        private System.Windows.Forms.Panel PanelQuitter;
        private System.Windows.Forms.Panel PanelInterieur;
        private System.Windows.Forms.DataGridView dgvClasse;
        private System.Windows.Forms.DataGridView dgvListeEtudiant;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomEtudiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomEtudiant;
    }
}