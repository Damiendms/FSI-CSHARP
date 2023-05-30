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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void bConnexion_Click(object sender, EventArgs e)
        {
            string loginUti = tbLogin.Text;
            string mdpUti = tbMdp.Text;
            //Contrôle de la connexion
            string Conx = "Server=localhost;Port=5432;Database=FSI;User Id=postgres;Password=OLEN@bts2023;";
            NpgsqlConnection MyCnx = new NpgsqlConnection(Conx);
            MyCnx = new NpgsqlConnection(Conx);
            MyCnx.Open();
            string select = "SELECT * FROM utilisateur where loginutilisateur = :login;";
            select = "SELECT * FROM utilisateur where mdputilisateur = :mdp;";
            NpgsqlCommand MyCmd = new NpgsqlCommand(select, MyCnx);
            MyCmd.Parameters.Add(new NpgsqlParameter("login", NpgsqlDbType.Varchar)).Value = loginUti;
            MyCmd.Parameters.Add(new NpgsqlParameter("mdp", NpgsqlDbType.Varchar)).Value = mdpUti;
            NpgsqlDataReader dr = MyCmd.ExecuteReader();

            if (dr.Read())
            {
                // Création de l'objet utilisateur

                Utilisateur uti = new Utilisateur(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));
                if (uti.MdpUtilisateur == mdpUti)
                {
                    this.Hide();
                    Form formAccueil = new Accueil(uti);
                    formAccueil.Show();
                }
                else
                {
                    MessageBox.Show("Erreur d'authentification");
                    tbLogin.Text = "";
                    tbMdp.Text = "";
                }
                //Ouverture du formulaire d'accueil si la connexion est ok

            }
            else
            {
                MessageBox.Show("Erreur d'authentification");
                tbLogin.Text = "";
                tbMdp.Text = "";
            }

            MyCnx.Close();





        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }
    }
}
