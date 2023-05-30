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
    public partial class ModifCours : Form
    {
        List<Cours> mesCours = new List<Cours>();
        NpgsqlConnection maConnexion;
        NpgsqlCommand commande, classe_query;
        private NpgsqlConnection coursConnexion;
        private object id_classe;

        public ModifCours()
        {
            InitializeComponent();
            string connexion_cours = "Server=localhost;Port=5432;Database=FSI;User Id=postgres;Password=OLEN@bts2023;";
            string select_cours = "SELECT * from cours;";
            coursConnexion = new NpgsqlConnection(connexion_cours);
            coursConnexion.Open();
            classe_query = new NpgsqlCommand(select_cours, coursConnexion);
            NpgsqlDataReader ajouter = classe_query.ExecuteReader();

            while (ajouter.Read())
            {
                mesCours.Add(new Cours(ajouter.GetInt32(0), ajouter.GetString(1), ajouter.GetString(2)));
            }

            foreach (var Cours in mesCours)
            {
                comboBox1.Items.Add(Cours.libellecours);
            }
        }

        private void lNom_Click(object sender, EventArgs e)
        {

        }

        private void ModifCours_Load(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string textclasse = "";

            foreach (var Cours in mesCours)
            {
                if (comboBox1.SelectedItem == Cours.libellecours)
                {
                    tbAENom.Text = Cours.libellecours;
                }
            }

            tbAENom.Text = textclasse.ToString();
        }

        private void bouton3_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifCours_Load_1(object sender, EventArgs e)
        {

        }

        private void bouton2_Click_1(object sender, EventArgs e)
        {
            int id_cours = 0;
            string premon = tbAENom.Text;

            foreach (var Cours in mesCours)
            {
                if (comboBox1.SelectedItem == Cours.libellecours)
                {

                    id_cours = Cours.idcours;
                }
            }


            string connexion = "Server=localhost;Port=5432;Database=FSI;User Id=postgres;Password=OLEN@bts2023;";
            maConnexion = new NpgsqlConnection(connexion);
            maConnexion.Open();
            string pufff = " UPDATE cours SET libellecours = @FirstName WHERE idcours = :3 ; ";
            commande = new NpgsqlCommand(pufff, maConnexion);
            commande.Parameters.Add(new NpgsqlParameter("@FirstName", NpgsqlDbType.Varchar)).Value = premon;
            commande.Parameters.Add(new NpgsqlParameter("3", NpgsqlDbType.Integer)).Value = id_cours;
            commande.Prepare();
            commande.CommandType = CommandType.Text;
            commande.ExecuteNonQuery();

            MessageBox.Show("Cour modifier");


        }
    }

}

