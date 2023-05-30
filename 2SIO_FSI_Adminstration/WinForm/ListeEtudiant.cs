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
    public partial class ListeEtudiant : Form
    {
        Utilisateur x;
        public ListeEtudiant(Utilisateur utiConnecte)
        {
        InitializeComponent();
            x = utiConnecte;
            ForeColor = Color.Green;
            

            //Contrôle de la connexion
            string Conx = "Server=localhost;Port=5432;Database=FSI;User Id=postgres;Password=OLEN@bts2023;";
            NpgsqlConnection MyCnx = new NpgsqlConnection(Conx);
            MyCnx = new NpgsqlConnection(Conx);
            MyCnx.Open();
            string select = "SELECT e.idetudiant,nometudiant,prenometudiant,tel, email,adresse, c.libelleclasse from etudiant e inner join classe c on e.idclasse = c.idclasse;";
            NpgsqlCommand MyCmd = new NpgsqlCommand(select, MyCnx);
            NpgsqlDataReader dr = MyCmd.ExecuteReader();

            List<Etudiant> mesEtudiant = new List<Etudiant>();
            while (dr.Read())
            {
                // Création de l'objet etudiant
                int idEtudiant = dr.GetInt32(0);
                string nomEtudiant = dr.GetString(1);
                string prenomEtudiant = dr.GetString(2);
                string classeEtudiant = dr.GetString(3);
                string adress = dr.GetString(4);
                var email = dr.GetString(5);
                var tel = dr.GetString(6);

                Etudiant unEtudiant = new Etudiant(idEtudiant, nomEtudiant, prenomEtudiant,tel,email,adress, classeEtudiant);
                mesEtudiant.Add(unEtudiant);
                ForeColor = Color.Green;
            }

            //Affichage dans le dataGridView
            foreach(Etudiant etu in mesEtudiant)
            {
                dgvEtudiants.Rows.Add(etu.NomEtudiant,etu.PrenomEtudiant,etu.telephone,etu.adressemail, etu.adresspostal,etu.ClasseEtudiant);
                ForeColor = Color.Green;
            }
         

            MyCnx.Close();

        }

        private void bQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
       

        private void dgvListeEtudiant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEtudiants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListeEtudiant_Load(object sender, EventArgs e)
        {
           
        }

    }
}
