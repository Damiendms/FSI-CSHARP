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
using System.Windows.Forms.VisualStyles;

namespace _2SIO_FSI_Adminstration.WinForm
{
    public partial class AjoutCours : Form
    {
        List<Classe.Classe> mesClasses = new List<Classe.Classe>();
        NpgsqlConnection maConnexion;
        NpgsqlCommand commande;

        public AjoutCours()
        {
            InitializeComponent();
        }

        private void lNom_Click(object sender, EventArgs e)
        {

        }
        private void reInitialisation()
        {
            tbAENom.Text = "";
            textBox1.Text = "";
            comboBox1.Text = "";
        }
        private void bouton1_Click(object sender, EventArgs e)
        {
            reInitialisation();
        }

        private void bouton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = tbAENom.Text;
            string desc = textBox1.Text;
            int id_classe = 0;
            
            foreach (var Cours in mesClasses)
            {
                if (comboBox1.SelectedItem == Cours.libelleclasse)
                {

                    id_classe = Cours.idclasse;
                }
            }



            if (!string.IsNullOrEmpty(tbAENom.Text) && !string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(comboBox1.Text))
            {

           
                try
                {
                    string connexion = "Server=localhost;Port=5432;Database=FSI;User Id=postgres;Password=OLEN@bts2023;";
                    maConnexion = new NpgsqlConnection(connexion);
                    maConnexion.Open();
                    string pufff = "INSERT INTO cours (libellecours, descriptioncours, idclasse) values ( :1, :2, :3);";
                    commande = new NpgsqlCommand(pufff, maConnexion);
                    commande.Parameters.Add(new NpgsqlParameter("1", NpgsqlDbType.Varchar)).Value = nom;
                    commande.Parameters.Add(new NpgsqlParameter("2", NpgsqlDbType.Varchar)).Value = desc;
                    commande.Parameters.Add(new NpgsqlParameter("3", NpgsqlDbType.Integer)).Value = id_classe;
                    commande.Prepare();
                    commande.CommandType = CommandType.Text;
                    commande.ExecuteNonQuery();
                

                MessageBox.Show("Cours ajouté");
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


      

        private void AjoutCours_Load(object sender, EventArgs e)
        {
            {
                string connexion = "Server=localhost;Port=5432;Database=FSI;User Id=postgres;Password=OLEN@bts2023;";
                maConnexion = new NpgsqlConnection(connexion);
                maConnexion.Open();
                string select_classe = "SELECT * from classe;";
                NpgsqlCommand maCommande = new NpgsqlCommand(select_classe, maConnexion);
                NpgsqlDataReader select = maCommande.ExecuteReader();

                while (select.Read())
                {
                    mesClasses.Add(new Classe.Classe(select.GetInt32(0), select.GetString(1)));
                }

                foreach (var classe in mesClasses)
                {
                    comboBox1.Items.Add(classe.libelleclasse);
                }
            }
        
    }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbAENom_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
    



