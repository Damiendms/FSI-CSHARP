using _2SIO_FSI_Adminstration.Classe;
using Npgsql;
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
    public partial class ListeCours : Form
    {

        Utilisateur x;
        private Utilisateur utiConnecte;
        public ListeCours()
        {
            InitializeComponent();
            x = utiConnecte;

            // Contrôle de la connexion
            string Conx = "Server=localhost;Port=5432;Database=FSI;User Id=postgres;Password=OLEN@bts2023;";
            NpgsqlConnection MyCnx = new NpgsqlConnection(Conx);
            MyCnx.Open();

            // Requête pour récupérer la liste des cours
            string select = "SELECT * FROM cours;";
            NpgsqlCommand MyCmd = new NpgsqlCommand(select, MyCnx);
            NpgsqlDataReader dr = MyCmd.ExecuteReader();
            List<Cours> mesCours = new List<Cours>();
            while (dr.Read())
            {
                int idCours = dr.GetInt32(0);
                string libelleCours = dr.GetString(1);
                string descriptioncours = dr.GetString(2);
                Cours unCours = new Cours(idCours, libelleCours, descriptioncours);
                mesCours.Add(unCours);

            }


            // Affichage dans le DataGridView
            foreach (Cours classe in mesCours)
            {
                dgvClasse.Rows.Add(classe.libellecours, classe.descriptioncours);
            }

            MyCnx.Close();
        }

     

   

        private void bFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvClasse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListeCours_Load(object sender, EventArgs e)
        {

        }
    }
}
