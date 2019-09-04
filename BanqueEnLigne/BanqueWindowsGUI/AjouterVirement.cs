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
    public partial class AjouterVirement : Form
    {
        public AjouterVirement()
        {
            InitializeComponent();
        }

        private void ButtonAddCompte_Click(object sender, EventArgs e)
        {
            FrmNouveauCompte nouveauCompte = new FrmNouveauCompte();
            nouveauCompte.Show();
        }

        /// <summary>
        /// Désactivé.
        /// Le chargement de la form FrmListeComptes renvoi une exception lié à la validité du format d'un compte.
        /// A corriger.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnListeComptes_Click(object sender, EventArgs e)
        {
            //FrmListeComptes listeComptes = new FrmListeComptes();
            //listeComptes.Show();
        }
    }
}
