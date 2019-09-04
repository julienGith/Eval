using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banque;

namespace BanqueWindowsGUI
{
    public partial class FrmListeComptes : Form
    {
        private Comptes comptes; 
        public FrmListeComptes()
        {
            InitializeComponent();
        }

        private void btnAjouterCompte_Click(object sender, EventArgs e)
        {
            FrmNouveauCompte nouveauCompte = new FrmNouveauCompte(comptes);
            if (nouveauCompte.ShowDialog()==DialogResult.OK)
            {
                // la méthode resetBindingSource ne fonctionnant pas correctement
                // je simule l'affectation d'une nouvelle source de source de données
                // qui provoque de nouveau le dessin du contrôle
                comptesBindingSource.DataSource = null;
                comptesBindingSource.DataSource = comptes;

                comptes.Save(Properties.Settings.Default.BanqueAppData);
            }
        }

        private void FrmListeComptes_Load(object sender, EventArgs e)
        {
            comptes = new Comptes();
            comptes.Load(Properties.Settings.Default.BanqueAppData);
            comptesBindingSource.DataSource = comptes;
            
        }
    }
}
