using _2SIO_FSI_Adminstration.Classe;
using _2SIO_FSI_Adminstration.WinForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SIO_FSI_Adminstration
{
    public partial class Accueil : Form
    {
        Utilisateur uti;
        public Accueil(Utilisateur utiConnecte)
        {
            InitializeComponent();
            uti = utiConnecte;
            Form formConnexion = new WinForm.Connexion();
            formConnexion.Close();
            tbUserConnecte.Text = uti.LoginUtilisateur;
     
        }
        public Accueil()
        {
            InitializeComponent();  
        }

        private void bQuitter_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void listeDesEtudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formListeEtudiant = new ListeEtudiant(uti);
            formListeEtudiant.Show();
        }

        private void ajouterUnEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            Form formAjouterEtudiant = new AjoutEtudiant();
            formAjouterEtudiant.Show();
        }

        private void ajouterUneClasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formAjouterClasse = new AjoutClasse();
            formAjouterClasse.Show();
        }

        private void listeDesClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formListeClasses = new ListeClasses(uti);
            formListeClasses.Show();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        private void accueilToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form formAccueil = new Accueil();
            formAccueil.Show();
        }

        private void modifClasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formModifclasse = new ModifClasse(); 
            formModifclasse.Show();
        }

        private void ajouterCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formAjouterCours = new AjoutCours();
            formAjouterCours.Show();
        }

        private void supressionCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formSuppressionCours = new SuppressionCours();
            formSuppressionCours.Show();
        }

        private void suppressionClToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formSuppressionClasse= new SuppressionClasse();
            formSuppressionClasse.Show();
        }

        private void suppressionEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formSuppressionEtudiant = new SuppressionEtudiant();
            formSuppressionEtudiant.Show();
        }

        private void listeCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formListeCours = new ListeCours();
            formListeCours.Show();
        }

        private void modifCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formModifCours = new ModifCours();
            formModifCours.Show();
        }
    }
}
