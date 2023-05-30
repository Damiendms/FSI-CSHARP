namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class AjoutClasse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutClasse));
            this.bouton3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bouton2 = new System.Windows.Forms.Button();
            this.bouton1 = new System.Windows.Forms.Button();
            this.tbAENom = new System.Windows.Forms.TextBox();
            this.lNom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bouton3
            // 
            this.bouton3.BackColor = System.Drawing.Color.Honeydew;
            this.bouton3.ForeColor = System.Drawing.Color.DarkGreen;
            this.bouton3.Location = new System.Drawing.Point(357, 276);
            this.bouton3.Name = "bouton3";
            this.bouton3.Size = new System.Drawing.Size(159, 40);
            this.bouton3.TabIndex = 19;
            this.bouton3.Text = "RETOUR";
            this.bouton3.UseVisualStyleBackColor = false;
            this.bouton3.Click += new System.EventHandler(this.bouton3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // bouton2
            // 
            this.bouton2.BackColor = System.Drawing.Color.Honeydew;
            this.bouton2.ForeColor = System.Drawing.Color.DarkGreen;
            this.bouton2.Location = new System.Drawing.Point(515, 211);
            this.bouton2.Name = "bouton2";
            this.bouton2.Size = new System.Drawing.Size(164, 40);
            this.bouton2.TabIndex = 17;
            this.bouton2.Text = "ENREGISTRER";
            this.bouton2.UseVisualStyleBackColor = false;
            this.bouton2.Click += new System.EventHandler(this.bouton2_Click);
            // 
            // bouton1
            // 
            this.bouton1.BackColor = System.Drawing.Color.Honeydew;
            this.bouton1.ForeColor = System.Drawing.Color.DarkGreen;
            this.bouton1.Location = new System.Drawing.Point(226, 211);
            this.bouton1.Name = "bouton1";
            this.bouton1.Size = new System.Drawing.Size(159, 40);
            this.bouton1.TabIndex = 16;
            this.bouton1.Text = "EFFACER";
            this.bouton1.UseVisualStyleBackColor = false;
            this.bouton1.Click += new System.EventHandler(this.bouton1_Click);
            // 
            // tbAENom
            // 
            this.tbAENom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAENom.Location = new System.Drawing.Point(339, 103);
            this.tbAENom.Name = "tbAENom";
            this.tbAENom.Size = new System.Drawing.Size(206, 41);
            this.tbAENom.TabIndex = 14;
            this.tbAENom.TextChanged += new System.EventHandler(this.tbAENom_TextChanged);
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNom.ForeColor = System.Drawing.Color.DarkGreen;
            this.lNom.Location = new System.Drawing.Point(152, 109);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(161, 32);
            this.lNom.TabIndex = 11;
            this.lNom.Text = "Nom classe";
            this.lNom.Click += new System.EventHandler(this.lNom_Click);
            // 
            // AjoutClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bouton3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bouton2);
            this.Controls.Add(this.bouton1);
            this.Controls.Add(this.tbAENom);
            this.Controls.Add(this.lNom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjoutClasse";
            this.Text = "AjoutClasse";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bouton3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bouton2;
        private System.Windows.Forms.Button bouton1;
        private System.Windows.Forms.TextBox tbAENom;
        private System.Windows.Forms.Label lNom;
    }
}