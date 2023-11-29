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
    public partial class Ecran1 : Form
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

        public Ecran1()
        {
            InitializeComponent();
        }
        private void btnRAZ_Click(object sender, EventArgs e)
        {
            txtBoxNom.Text = "";
            txtBoxPrenom.Text = "";
            txtBoxMail.Text = "";
            txtBoxLogin.Text = "";
            txtBoxMdp.Text = "";
        }
        private void btnObtientLogin_Click(object sender, EventArgs e)
        {
            string NewMdp;

            if (txtBoxPrenom.Text == "" || txtBoxNom.Text == "" || txtBoxMail.Text == "" || Outils.IsValidEmail(txtBoxMail.Text) == false)
            {
                MessageBox.Show("Entrez correctement tout les champs demandés", "Erreur", MessageBoxButtons.OKCancel);
            }
            else
            {
                NewMdp = Outils.GeneratePassword(8);
                txtBoxMdp.Text = NewMdp;
                txtBoxLogin.Text = txtBoxMail.Text;
                nom = txtBoxNom.Text;
                prenom = txtBoxPrenom.Text;
            }
        }
        private void btnInscription_Click(object sender, EventArgs e)
        {
            if (txtBoxMdp.Text == "" || txtBoxLogin.Text != txtBoxMail.Text)
            {
                MessageBox.Show("Cliquez sur Obtenir votre Login", "Erreur", MessageBoxButtons.OKCancel);
            }
            else
            {
                Ecran2 f = new Ecran2();
                f.ChaineConnexion = this.chaineConnexion;               
                f.Prenom = this.prenom;
                f.Nom = this.nom;
                f.Show();
            }
        }
    }
}
