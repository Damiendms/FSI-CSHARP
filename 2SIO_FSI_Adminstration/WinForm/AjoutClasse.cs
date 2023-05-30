using _2SIO_FSI_Adminstration.Classe;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class AjoutClasse : Form
    {

        NpgsqlConnection maConnexion;
        NpgsqlCommand commande;
        public AjoutClasse()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbAENom_TextChanged(object sender, EventArgs e)
        {

        }

        private void lNom_Click(object sender, EventArgs e)
        {

        }
        private void reInitialisation()
        {
            tbAENom.Text = "";
        }
        private void bouton1_Click(object sender, EventArgs e)
        {
            reInitialisation();
        }

        private void bouton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bouton2_Click(object sender, EventArgs e)
        {
            string a = tbAENom.Text;

            if (!string.IsNullOrEmpty(tbAENom.Text))
            {
                try
                {
                    string connexion = "Server=localhost;Port=5432;Database=FSI;User Id=postgres;Password=OLEN@bts2023;";
                    maConnexion = new NpgsqlConnection(connexion);
                    maConnexion = new NpgsqlConnection(connexion);
                    maConnexion.Open();
                    string pufff = "INSERT INTO classe (libelleclasse) values ( :1);";
                    commande = new NpgsqlCommand(pufff, maConnexion);
                    commande.Parameters.Add(new NpgsqlParameter("1", NpgsqlDbType.Varchar)).Value = a;
                    commande.Prepare();
                    commande.CommandType = CommandType.Text;
                    commande.ExecuteNonQuery();
                    MessageBox.Show("Classe ajouté");
                }
                finally
                {
                    if (commande != null) commande.Dispose();
                    if (maConnexion != null) maConnexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Remplir les champs");

            }

        }
    }
}
