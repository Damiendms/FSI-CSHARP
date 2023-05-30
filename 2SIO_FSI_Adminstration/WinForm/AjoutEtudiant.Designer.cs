namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class AjoutEtudiant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutEtudiant));
            this.lNom = new System.Windows.Forms.Label();
            this.lPrenom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAENom = new System.Windows.Forms.TextBox();
            this.tbAEPrenom = new System.Windows.Forms.TextBox();
            this.bouton1 = new System.Windows.Forms.Button();
            this.bouton3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bouton2 = new System.Windows.Forms.Button();
            this.cbClasse = new System.Windows.Forms.ComboBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.Tel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.ForeColor = System.Drawing.Color.DarkGreen;
            this.lNom.Location = new System.Drawing.Point(42, 54);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(70, 31);
            this.lNom.TabIndex = 0;
            this.lNom.Text = "Nom";
            // 
            // lPrenom
            // 
            this.lPrenom.AutoSize = true;
            this.lPrenom.ForeColor = System.Drawing.Color.DarkGreen;
            this.lPrenom.Location = new System.Drawing.Point(13, 114);
            this.lPrenom.Name = "lPrenom";
            this.lPrenom.Size = new System.Drawing.Size(105, 31);
            this.lPrenom.TabIndex = 1;
            this.lPrenom.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(30, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Classe";
            // 
            // tbAENom
            // 
            this.tbAENom.Location = new System.Drawing.Point(123, 41);
            this.tbAENom.Name = "tbAENom";
            this.tbAENom.Size = new System.Drawing.Size(190, 46);
            this.tbAENom.TabIndex = 3;
            // 
            // tbAEPrenom
            // 
            this.tbAEPrenom.Location = new System.Drawing.Point(123, 101);
            this.tbAEPrenom.Name = "tbAEPrenom";
            this.tbAEPrenom.Size = new System.Drawing.Size(190, 46);
            this.tbAEPrenom.TabIndex = 4;
            // 
            // bouton1
            // 
            this.bouton1.BackColor = System.Drawing.Color.Honeydew;
            this.bouton1.ForeColor = System.Drawing.Color.DarkGreen;
            this.bouton1.Location = new System.Drawing.Point(30, 396);
            this.bouton1.Name = "bouton1";
            this.bouton1.Size = new System.Drawing.Size(159, 40);
            this.bouton1.TabIndex = 6;
            this.bouton1.Text = "EFFACER";
            this.bouton1.UseVisualStyleBackColor = false;
            this.bouton1.Click += new System.EventHandler(this.bouton1_Click);
            // 
            // bouton3
            // 
            this.bouton3.BackColor = System.Drawing.Color.Honeydew;
            this.bouton3.ForeColor = System.Drawing.Color.DarkGreen;
            this.bouton3.Location = new System.Drawing.Point(195, 396);
            this.bouton3.Name = "bouton3";
            this.bouton3.Size = new System.Drawing.Size(164, 40);
            this.bouton3.TabIndex = 7;
            this.bouton3.Text = "ENREGISTRER";
            this.bouton3.UseVisualStyleBackColor = false;
            this.bouton3.Click += new System.EventHandler(this.bouton3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // bouton2
            // 
            this.bouton2.BackColor = System.Drawing.Color.Honeydew;
            this.bouton2.ForeColor = System.Drawing.Color.DarkGreen;
            this.bouton2.Location = new System.Drawing.Point(109, 458);
            this.bouton2.Name = "bouton2";
            this.bouton2.Size = new System.Drawing.Size(159, 40);
            this.bouton2.TabIndex = 9;
            this.bouton2.Text = "RETOUR";
            this.bouton2.UseVisualStyleBackColor = false;
            this.bouton2.Click += new System.EventHandler(this.bouton2_Click);
            // 
            // cbClasse
            // 
            this.cbClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasse.FormattingEnabled = true;
            this.cbClasse.Location = new System.Drawing.Point(123, 173);
            this.cbClasse.Name = "cbClasse";
            this.cbClasse.Size = new System.Drawing.Size(190, 39);
            this.cbClasse.TabIndex = 10;
            this.cbClasse.SelectedIndexChanged += new System.EventHandler(this.cbClasse_SelectedIndexChanged);
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(123, 218);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(190, 46);
            this.textBoxTel.TabIndex = 11;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(123, 280);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(190, 46);
            this.textBoxEmail.TabIndex = 12;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(123, 332);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(190, 46);
            this.textBoxAdresse.TabIndex = 13;
            // 
            // Tel
            // 
            this.Tel.AutoSize = true;
            this.Tel.ForeColor = System.Drawing.Color.DarkGreen;
            this.Tel.Location = new System.Drawing.Point(67, 233);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(50, 31);
            this.Tel.TabIndex = 14;
            this.Tel.Text = "Tel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(39, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(12, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "Adresse";
            // 
            // AjoutEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(371, 510);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.cbClasse);
            this.Controls.Add(this.bouton2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bouton3);
            this.Controls.Add(this.bouton1);
            this.Controls.Add(this.tbAEPrenom);
            this.Controls.Add(this.tbAENom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lPrenom);
            this.Controls.Add(this.lNom);
            this.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AjoutEtudiant";
            this.Text = "AjouterEtudiant";
            this.Load += new System.EventHandler(this.AjoutEtudiant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.Label lPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAENom;
        private System.Windows.Forms.TextBox tbAEPrenom;
        private System.Windows.Forms.Button bouton1;
        private System.Windows.Forms.Button bouton3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bouton2;
        private System.Windows.Forms.ComboBox cbClasse;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.Label Tel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        //    private P2022_Appli_AdministrationDataSet1TableAdapters.classeTableAdapter classeTableAdapter;
    }
}