namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class ModifCours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifCours));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lNom = new System.Windows.Forms.Label();
            this.tbAENom = new System.Windows.Forms.TextBox();
            this.bouton3 = new System.Windows.Forms.Button();
            this.bouton2 = new System.Windows.Forms.Button();
            this.bouton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(305, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(255, 24);
            this.comboBox1.TabIndex = 29;
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNom.ForeColor = System.Drawing.Color.DarkGreen;
            this.lNom.Location = new System.Drawing.Point(155, 194);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(149, 32);
            this.lNom.TabIndex = 28;
            this.lNom.Text = "Nom cours";
            // 
            // tbAENom
            // 
            this.tbAENom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAENom.Location = new System.Drawing.Point(322, 188);
            this.tbAENom.Name = "tbAENom";
            this.tbAENom.Size = new System.Drawing.Size(206, 41);
            this.tbAENom.TabIndex = 27;
            // 
            // bouton3
            // 
            this.bouton3.BackColor = System.Drawing.Color.Honeydew;
            this.bouton3.ForeColor = System.Drawing.Color.DarkGreen;
            this.bouton3.Location = new System.Drawing.Point(336, 330);
            this.bouton3.Name = "bouton3";
            this.bouton3.Size = new System.Drawing.Size(159, 40);
            this.bouton3.TabIndex = 26;
            this.bouton3.Text = "RETOUR";
            this.bouton3.UseVisualStyleBackColor = false;
            this.bouton3.Click += new System.EventHandler(this.bouton3_Click_2);
            // 
            // bouton2
            // 
            this.bouton2.BackColor = System.Drawing.Color.Honeydew;
            this.bouton2.ForeColor = System.Drawing.Color.DarkGreen;
            this.bouton2.Location = new System.Drawing.Point(481, 284);
            this.bouton2.Name = "bouton2";
            this.bouton2.Size = new System.Drawing.Size(164, 40);
            this.bouton2.TabIndex = 25;
            this.bouton2.Text = "ENREGISTRER";
            this.bouton2.UseVisualStyleBackColor = false;
            this.bouton2.Click += new System.EventHandler(this.bouton2_Click_1);
            // 
            // bouton1
            // 
            this.bouton1.BackColor = System.Drawing.Color.Honeydew;
            this.bouton1.ForeColor = System.Drawing.Color.DarkGreen;
            this.bouton1.Location = new System.Drawing.Point(204, 284);
            this.bouton1.Name = "bouton1";
            this.bouton1.Size = new System.Drawing.Size(159, 40);
            this.bouton1.TabIndex = 24;
            this.bouton1.Text = "EFFACER";
            this.bouton1.UseVisualStyleBackColor = false;
            this.bouton1.Click += new System.EventHandler(this.bouton1_Click);
            // 
            // ModifCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lNom);
            this.Controls.Add(this.tbAENom);
            this.Controls.Add(this.bouton3);
            this.Controls.Add(this.bouton2);
            this.Controls.Add(this.bouton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifCours";
            this.Text = "ModifCours";
            this.Load += new System.EventHandler(this.ModifCours_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.TextBox tbAENom;
        private System.Windows.Forms.Button bouton3;
        private System.Windows.Forms.Button bouton2;
        private System.Windows.Forms.Button bouton1;
    }
}