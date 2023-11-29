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
    public partial class Form1 : Form
    {
        string chaineConnexion;
        public string ChaineConnexion
        {
            get { return chaineConnexion; }
            set { chaineConnexion = value; }
        }
        public Form1()
        {
            ChaineConnexion = "server = localhost; user id = frediadmin;password= nikola;database = fredi";
            InitializeComponent();
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            Ecran1 f = new Ecran1();
            f.ChaineConnexion = this.chaineConnexion;
            f.Show();
        }
    }
}
