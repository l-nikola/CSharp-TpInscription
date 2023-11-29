using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inscription
{
    public partial class Ecran2 : Form
    {
        private string nom, prenom;
        string chaineConnexion;
        public string ChaineConnexion
        {
            get { return chaineConnexion; }
            set { chaineConnexion = value; }
        }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        private void Ecran2_Load(object sender, EventArgs e)
        {
            txtBoxNom.Text = nom;
            txtBoxPrenom.Text = prenom;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtBoxNom.Text == "" || txtBoxPrenom.Text == "" || txtBoxRue.Text == "" || txtBoxVille.Text == "" || txtBoxCP.Text == "" || txtBoxNumLicence.Text == "" || txtBoxNumLicenceFam.Text == "" || txtBoxNumClub.Text == "")
            {
                MessageBox.Show("Veuillez entrer tous les champs", "Erreur", MessageBoxButtons.OKCancel);
            }
            else
            {
                MessageBox.Show("Vous avez bien été crée en tant que demandeur et votre numéro est le ..", "", MessageBoxButtons.OKCancel);
            }
        }

        public Ecran2()
        {
            InitializeComponent();
        }
    }
}
