using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanqueWindowsGUI
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void AjouterUnNouveauVirementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterVirement ajouterVirement = new AjouterVirement();
            ajouterVirement.Show();
        }

        private void GestionsDesVirementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionVirements gestionVirements = new GestionVirements();
            gestionVirements.Show();
        }
    }
}
