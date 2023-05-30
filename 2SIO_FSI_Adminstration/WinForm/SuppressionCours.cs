using _2SIO_FSI_Adminstration.Classe;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class SuppressionCours : Form
    {

        List<Cours> mesCours = new List<Cours>();
        NpgsqlConnection maConnexion;
        NpgsqlCommand commande;
        public SuppressionCours()
        {
            InitializeComponent();
        }

        private void lNom_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void reInitialisation()
        {
            comboBox1.Text = "";
        }

        private void bouton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id_cours = 0;

            foreach (var Cours in mesCours)
            {
                if (comboBox1.SelectedItem == Cours.libellecours)
                {
                    id_cours = Cours.idcours;
                }
            }

            if (!string.IsNullOrEmpty(comboBox1.Text))
            {


                try
                {
                    string connexion = "Server=localhost;Port=5432;Database=FSI;User Id=postgres;Password=OLEN@bts2023;";
                    maConnexion = new NpgsqlConnection(connexion);
                    maConnexion.Open();
                    string pufff = "DELETE FROM cours WHERE idcours = :id_cours";
                    commande = new NpgsqlCommand(pufff, maConnexion);
                    commande.Parameters.Add(new NpgsqlParameter("id_cours", NpgsqlDbType.Integer)).Value = id_cours;
                    commande.ExecuteNonQuery();


                    MessageBox.Show("Cours supprimé");
                    reInitialisation();
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
    

        private void SuppressionCours_Load(object sender, EventArgs e)
        {
            {
                string connexion = "Server=localhost;Port=5432;Database=FSI;User Id=postgres;Password=OLEN@bts2023;";
                maConnexion = new NpgsqlConnection(connexion);
                maConnexion.Open();
                string select_classe = "SELECT * from cours;";
                NpgsqlCommand maCommande = new NpgsqlCommand(select_classe, maConnexion);
                NpgsqlDataReader select = maCommande.ExecuteReader();

                while (select.Read())
                {
                    mesCours.Add(new Cours(select.GetInt32(0), select.GetString(1), select.GetString(2)));
                }

                foreach (var classe in mesCours)
                {
                    comboBox1.Items.Add(classe.libellecours);
                }
            }
        }
    }
}
