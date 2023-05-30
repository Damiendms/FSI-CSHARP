using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SIO_FSI_Adminstration.WinForm
    {
public partial class AjoutEtudiant : Form
        {
        NpgsqlConnection maConnexion;
        NpgsqlCommand commande;
        public AjoutEtudiant()
        {
            InitializeComponent();
            //Contrôle de la connexion
            string Conx = "Server=localhost;Port=5432;Database=FSI;User Id=postgres;Password=OLEN@bts2023;";
            NpgsqlConnection MyCnx = new NpgsqlConnection(Conx);
            MyCnx = new NpgsqlConnection(Conx);
            MyCnx.Open();
            string select = "SELECT * FROM classe";
            NpgsqlCommand MyCmd = new NpgsqlCommand(select, MyCnx);
            NpgsqlDataReader dr = MyCmd.ExecuteReader();

            List<Classe.Classe> mesClasses = new List<Classe.Classe>();
            while (dr.Read())
            {
                // Création de l'objet classe
                int idClasse = dr.GetInt32(0);
                string libelleclasse = dr.GetString(1);

                Classe.Classe uneClasse = new Classe.Classe(idClasse, libelleclasse);
                mesClasses.Add(uneClasse);

            }

            //Affichage dans le dataGridView
            foreach (Classe.Classe classe in mesClasses)
            {
                cbClasse.Items.Add(classe.libelleclasse);

            }


            MyCnx.Close();
        }
        private void bouton3_Click(object sender, EventArgs e)
        {
            string a = tbAENom.Text;
            string z = tbAEPrenom.Text;
            string u = textBoxTel.Text;
            string r = textBoxEmail.Text;
            string t = textBoxAdresse.Text;


            if (!string.IsNullOrEmpty(tbAENom.Text) && !string.IsNullOrEmpty(tbAEPrenom.Text) && !string.IsNullOrEmpty(textBoxTel.Text) && !string.IsNullOrEmpty(textBoxEmail.Text) && !string.IsNullOrEmpty(textBoxAdresse.Text))
            {
                try
                {
                    string connexion = "Server=localhost;Port=5432;Database=FSI;User Id=postgres;Password=OLEN@bts2023;";
                    maConnexion = new NpgsqlConnection(connexion);
                    maConnexion = new NpgsqlConnection(connexion);
                    maConnexion.Open();
                    string pufff = "INSERT INTO etudiant (nomEtudiant, prenometudiant, tel, email, adresse, idClasse) values ( :1, :2, :3, :4, :5, 1);";
                    commande = new NpgsqlCommand(pufff, maConnexion);
                    commande.Parameters.Add(new NpgsqlParameter("1", NpgsqlDbType.Varchar)).Value = a;
                    commande.Parameters.Add(new NpgsqlParameter("2", NpgsqlDbType.Varchar)).Value = z;
                    commande.Parameters.Add(new NpgsqlParameter("3", NpgsqlDbType.Varchar)).Value = u;
                    commande.Parameters.Add(new NpgsqlParameter("4", NpgsqlDbType.Varchar)).Value = r;
                    commande.Parameters.Add(new NpgsqlParameter("5", NpgsqlDbType.Varchar)).Value = t;
                    commande.Prepare();
                    commande.CommandType = CommandType.Text;
                    commande.ExecuteNonQuery();
                    MessageBox.Show("Etudiant ajouté");
                }
                finally
                {
                    if (commande != null) commande.Dispose();
                    if (maConnexion != null) maConnexion.Close();

                }
                

            }
            
            else {
                MessageBox.Show("Remplir les champs");
                    
                    }

        }
        private void reInitialisation()
        {
            tbAENom.Text = "";
            tbAEPrenom.Text = "";
            cbClasse.Text = "";
            textBoxTel.Text = ""; 
            textBoxEmail.Text = ""; 
            textBoxAdresse.Text = ""; 
        }

        private void bouton1_Click(object sender, EventArgs e)
        {
            reInitialisation();
        }

        private void bouton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AjoutEtudiant_Load(object sender, EventArgs e)
        {

        }
    }
}
