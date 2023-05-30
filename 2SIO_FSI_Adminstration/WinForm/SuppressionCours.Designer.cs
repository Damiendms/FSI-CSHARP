namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class SuppressionCours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppressionCours));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lNom = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bouton3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(256, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 24);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNom.ForeColor = System.Drawing.Color.DarkGreen;
            this.lNom.Location = new System.Drawing.Point(101, 68);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(149, 32);
            this.lNom.TabIndex = 31;
            this.lNom.Text = "Nom cours";
            this.lNom.Click += new System.EventHandler(this.lNom_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Honeydew;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.button1.ForeColor = System.Drawing.Color.DarkGreen;
            this.button1.Location = new System.Drawing.Point(289, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 40);
            this.button1.TabIndex = 32;
            this.button1.Text = "SUPPRIMER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bouton3
            // 
            this.bouton3.BackColor = System.Drawing.Color.Honeydew;
            this.bouton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.bouton3.ForeColor = System.Drawing.Color.DarkGreen;
            this.bouton3.Location = new System.Drawing.Point(312, 280);
            this.bouton3.Name = "bouton3";
            this.bouton3.Size = new System.Drawing.Size(159, 40);
            this.bouton3.TabIndex = 33;
            this.bouton3.Text = "RETOUR";
            this.bouton3.UseVisualStyleBackColor = false;
            this.bouton3.Click += new System.EventHandler(this.bouton3_Click);
            // 
            // SuppressionCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bouton3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lNom);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SuppressionCours";
            this.Text = "SuppressionCours";
            this.Load += new System.EventHandler(this.SuppressionCours_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bouton3;
    }
}