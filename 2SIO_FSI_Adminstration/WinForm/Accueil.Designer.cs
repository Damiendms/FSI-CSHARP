namespace _2SIO_FSI_Adminstration
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.msGlobal = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionEtudiantToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesEtudiantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnEtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionEtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionClToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supressionCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.PanelQuitter = new System.Windows.Forms.Panel();
            this.bQuitter = new System.Windows.Forms.Button();
            this.PanelInterieur = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lBien = new System.Windows.Forms.Label();
            this.tbUserConnecte = new System.Windows.Forms.TextBox();
            this.modifCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelMenu.SuspendLayout();
            this.msGlobal.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.PanelInterieur.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.Controls.Add(this.msGlobal);
            this.PanelMenu.Location = new System.Drawing.Point(87, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(806, 29);
            this.PanelMenu.TabIndex = 7;
            // 
            // msGlobal
            // 
            this.msGlobal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msGlobal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem2,
            this.gestionEtudiantToolStripMenuItem1,
            this.gestionClasseToolStripMenuItem,
            this.gestionCoursToolStripMenuItem});
            this.msGlobal.Location = new System.Drawing.Point(0, 0);
            this.msGlobal.Name = "msGlobal";
            this.msGlobal.Size = new System.Drawing.Size(806, 28);
            this.msGlobal.TabIndex = 0;
            this.msGlobal.Text = "Menu";
            // 
            // accueilToolStripMenuItem2
            // 
            this.accueilToolStripMenuItem2.Name = "accueilToolStripMenuItem2";
            this.accueilToolStripMenuItem2.Size = new System.Drawing.Size(71, 24);
            this.accueilToolStripMenuItem2.Text = "Accueil";
            this.accueilToolStripMenuItem2.Click += new System.EventHandler(this.accueilToolStripMenuItem2_Click);
            // 
            // gestionEtudiantToolStripMenuItem1
            // 
            this.gestionEtudiantToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesEtudiantsToolStripMenuItem,
            this.ajouterUnEtudiantToolStripMenuItem,
            this.suppressionEtudiantToolStripMenuItem});
            this.gestionEtudiantToolStripMenuItem1.Name = "gestionEtudiantToolStripMenuItem1";
            this.gestionEtudiantToolStripMenuItem1.Size = new System.Drawing.Size(132, 24);
            this.gestionEtudiantToolStripMenuItem1.Text = "Gestion Etudiant";
            // 
            // listeDesEtudiantsToolStripMenuItem
            // 
            this.listeDesEtudiantsToolStripMenuItem.Name = "listeDesEtudiantsToolStripMenuItem";
            this.listeDesEtudiantsToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.listeDesEtudiantsToolStripMenuItem.Text = "Liste des étudiants";
            this.listeDesEtudiantsToolStripMenuItem.Click += new System.EventHandler(this.listeDesEtudiantsToolStripMenuItem_Click);
            // 
            // ajouterUnEtudiantToolStripMenuItem
            // 
            this.ajouterUnEtudiantToolStripMenuItem.Name = "ajouterUnEtudiantToolStripMenuItem";
            this.ajouterUnEtudiantToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.ajouterUnEtudiantToolStripMenuItem.Text = "Ajouter un étudiant";
            this.ajouterUnEtudiantToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnEtudiantToolStripMenuItem_Click);
            // 
            // suppressionEtudiantToolStripMenuItem
            // 
            this.suppressionEtudiantToolStripMenuItem.Name = "suppressionEtudiantToolStripMenuItem";
            this.suppressionEtudiantToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.suppressionEtudiantToolStripMenuItem.Text = "SuppressionEtudiant";
            this.suppressionEtudiantToolStripMenuItem.Click += new System.EventHandler(this.suppressionEtudiantToolStripMenuItem_Click);
            // 
            // gestionClasseToolStripMenuItem
            // 
            this.gestionClasseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesClassesToolStripMenuItem,
            this.ajouterUneClasseToolStripMenuItem,
            this.modifClasseToolStripMenuItem,
            this.suppressionClToolStripMenuItem});
            this.gestionClasseToolStripMenuItem.Name = "gestionClasseToolStripMenuItem";
            this.gestionClasseToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.gestionClasseToolStripMenuItem.Text = "Gestion classe";
            // 
            // listeDesClassesToolStripMenuItem
            // 
            this.listeDesClassesToolStripMenuItem.Name = "listeDesClassesToolStripMenuItem";
            this.listeDesClassesToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.listeDesClassesToolStripMenuItem.Text = "Liste des classes";
            this.listeDesClassesToolStripMenuItem.Click += new System.EventHandler(this.listeDesClassesToolStripMenuItem_Click);
            // 
            // ajouterUneClasseToolStripMenuItem
            // 
            this.ajouterUneClasseToolStripMenuItem.Name = "ajouterUneClasseToolStripMenuItem";
            this.ajouterUneClasseToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.ajouterUneClasseToolStripMenuItem.Text = "Ajouter une classe";
            this.ajouterUneClasseToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneClasseToolStripMenuItem_Click);
            // 
            // modifClasseToolStripMenuItem
            // 
            this.modifClasseToolStripMenuItem.Name = "modifClasseToolStripMenuItem";
            this.modifClasseToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.modifClasseToolStripMenuItem.Text = "ModifClasse";
            this.modifClasseToolStripMenuItem.Click += new System.EventHandler(this.modifClasseToolStripMenuItem_Click);
            // 
            // suppressionClToolStripMenuItem
            // 
            this.suppressionClToolStripMenuItem.Name = "suppressionClToolStripMenuItem";
            this.suppressionClToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.suppressionClToolStripMenuItem.Text = "SuppressionClasse";
            this.suppressionClToolStripMenuItem.Click += new System.EventHandler(this.suppressionClToolStripMenuItem_Click);
            // 
            // gestionCoursToolStripMenuItem
            // 
            this.gestionCoursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterCoursToolStripMenuItem,
            this.listeCoursToolStripMenuItem,
            this.supressionCoursToolStripMenuItem,
            this.modifCoursToolStripMenuItem});
            this.gestionCoursToolStripMenuItem.Name = "gestionCoursToolStripMenuItem";
            this.gestionCoursToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.gestionCoursToolStripMenuItem.Text = "Gestion cours";
            // 
            // ajouterCoursToolStripMenuItem
            // 
            this.ajouterCoursToolStripMenuItem.Name = "ajouterCoursToolStripMenuItem";
            this.ajouterCoursToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ajouterCoursToolStripMenuItem.Text = "Ajouter cours";
            this.ajouterCoursToolStripMenuItem.Click += new System.EventHandler(this.ajouterCoursToolStripMenuItem_Click);
            // 
            // listeCoursToolStripMenuItem
            // 
            this.listeCoursToolStripMenuItem.Name = "listeCoursToolStripMenuItem";
            this.listeCoursToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listeCoursToolStripMenuItem.Text = "Liste cours";
            this.listeCoursToolStripMenuItem.Click += new System.EventHandler(this.listeCoursToolStripMenuItem_Click);
            // 
            // supressionCoursToolStripMenuItem
            // 
            this.supressionCoursToolStripMenuItem.DoubleClickEnabled = true;
            this.supressionCoursToolStripMenuItem.Name = "supressionCoursToolStripMenuItem";
            this.supressionCoursToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.supressionCoursToolStripMenuItem.Text = "SuppressionCours";
            this.supressionCoursToolStripMenuItem.Click += new System.EventHandler(this.supressionCoursToolStripMenuItem_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.pbLogo);
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(84, 90);
            this.PanelLogo.TabIndex = 9;
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
            this.PanelQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelQuitter.AutoSize = true;
            this.PanelQuitter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelQuitter.Location = new System.Drawing.Point(899, 0);
            this.PanelQuitter.Name = "PanelQuitter";
            this.PanelQuitter.Size = new System.Drawing.Size(0, 0);
            this.PanelQuitter.TabIndex = 10;
            // 
            // bQuitter
            // 
            this.bQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bQuitter.AutoSize = true;
            this.bQuitter.BackColor = System.Drawing.Color.Green;
            this.bQuitter.ForeColor = System.Drawing.Color.White;
            this.bQuitter.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.bQuitter.Location = new System.Drawing.Point(908, 12);
            this.bQuitter.Name = "bQuitter";
            this.bQuitter.Size = new System.Drawing.Size(133, 43);
            this.bQuitter.TabIndex = 7;
            this.bQuitter.Text = "QUITTER";
            this.bQuitter.UseVisualStyleBackColor = false;
            this.bQuitter.Click += new System.EventHandler(this.bQuitter_Click);
            // 
            // PanelInterieur
            // 
            this.PanelInterieur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelInterieur.AutoSize = true;
            this.PanelInterieur.Controls.Add(this.label1);
            this.PanelInterieur.Controls.Add(this.lBien);
            this.PanelInterieur.Location = new System.Drawing.Point(87, 35);
            this.PanelInterieur.Name = "PanelInterieur";
            this.PanelInterieur.Size = new System.Drawing.Size(806, 482);
            this.PanelInterieur.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(138, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "Application de gestion administration de l\'école FSI";
            // 
            // lBien
            // 
            this.lBien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lBien.AutoSize = true;
            this.lBien.Font = new System.Drawing.Font("Arial Narrow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBien.ForeColor = System.Drawing.Color.Green;
            this.lBien.Location = new System.Drawing.Point(324, 19);
            this.lBien.Name = "lBien";
            this.lBien.Size = new System.Drawing.Size(171, 33);
            this.lBien.TabIndex = 13;
            this.lBien.Text = "BIENVENUE !!";
            // 
            // tbUserConnecte
            // 
            this.tbUserConnecte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUserConnecte.BackColor = System.Drawing.Color.White;
            this.tbUserConnecte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUserConnecte.Font = new System.Drawing.Font("Arial Narrow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserConnecte.ForeColor = System.Drawing.Color.Green;
            this.tbUserConnecte.Location = new System.Drawing.Point(941, 61);
            this.tbUserConnecte.Name = "tbUserConnecte";
            this.tbUserConnecte.ReadOnly = true;
            this.tbUserConnecte.Size = new System.Drawing.Size(100, 31);
            this.tbUserConnecte.TabIndex = 12;
            // 
            // modifCoursToolStripMenuItem
            // 
            this.modifCoursToolStripMenuItem.Name = "modifCoursToolStripMenuItem";
            this.modifCoursToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.modifCoursToolStripMenuItem.Text = "Modif Cours";
            this.modifCoursToolStripMenuItem.Click += new System.EventHandler(this.modifCoursToolStripMenuItem_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1053, 529);
            this.Controls.Add(this.bQuitter);
            this.Controls.Add(this.tbUserConnecte);
            this.Controls.Add(this.PanelInterieur);
            this.Controls.Add(this.PanelQuitter);
            this.Controls.Add(this.PanelLogo);
            this.Controls.Add(this.PanelMenu);
            this.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Accueil";
            this.Text = "ACCUEIL";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            this.msGlobal.ResumeLayout(false);
            this.msGlobal.PerformLayout();
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.PanelInterieur.ResumeLayout(false);
            this.PanelInterieur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.MenuStrip msGlobal;
  //      private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gestionEtudiantToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeDesEtudiantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnEtudiantToolStripMenuItem;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel PanelQuitter;
   //     private System.Windows.Forms.Button bDeConnexion;
        private System.Windows.Forms.Panel PanelInterieur;
    //    private System.Windows.Forms.Label lTexteBienvenue;
   //     private System.Windows.Forms.Label lBienvenue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lBien;
        private System.Windows.Forms.Button bQuitter;
        private System.Windows.Forms.ToolStripMenuItem gestionClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneClasseToolStripMenuItem;
        private System.Windows.Forms.TextBox tbUserConnecte;
        private System.Windows.Forms.ToolStripMenuItem modifClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supressionCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppressionClToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppressionEtudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifCoursToolStripMenuItem;
    }
}

