using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Banque;

namespace BanqueWindowsGUI
   
{
    /// <summary>
    /// Création d'un nouveau compte  externe à la banque
    /// </summary>
    public partial class FrmNouveauCompte : Form
    {
        Comptes comptes = new Comptes();
        ErrorProvider err = new ErrorProvider();
        public FrmNouveauCompte()
        {
            InitializeComponent();
        }

        public FrmNouveauCompte(Comptes comptesMaitre):this()
        {
            comptes = comptesMaitre;
        }

        private void FrmNouveauCompte_Load(object sender, EventArgs e)
        {
            btnValider.Enabled = false;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            //comptes.Add(new Compte() { CodeBanque = "30003", CodeClient = "2012", LibelleCompte = "bost tes" });
            // Pour ne pas sortir du dialog avec DialogResult.OK
            // Lorsque des erreurs subsistent 
            // Utiliser this.DialogResult = DialogResult.None

            if (IsSaisieValid())
            {
                btnValider.Enabled = true;
                Compte compte = new Compte();
                //comptes.Add(new Compte() { CodeBanque = codeBanqueTextBox.Text, CleRIB = cleRIBTextBox.Text, LibelleCompte = libellécompteTextBox.Text, CodeGuichet = codeGuichetTextBox.Text, CodeClient = "23456754",Numero = "0001" });
                compte.CleRIB = cleRIBTextBox.Text;
                compte.CodeBanque = codeBanqueTextBox.Text;
                compte.CodeClient = "23456754";
                compte.CodeGuichet = codeGuichetTextBox.Text;
                compte.LibelleCompte = libellécompteTextBox.Text;
                compte.Numero = numeroCompteTextBox.Text;
                comptes.Add(compte);
                DialogResult message = MessageBox.Show("Compte Ajouté !","Compte Ajouté",MessageBoxButtons.OK,MessageBoxIcon.Information);
                cleRIBTextBox.Clear();
                codeBanqueTextBox.Clear();
                codeGuichetTextBox.Clear();
                libellécompteTextBox.Clear();
                numeroCompteTextBox.Clear();
            }
                

        }

        private void btnAbandonner_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Méthode de vérification de la saisie avec génération d'erreur
        /// Complétion des champs.
        /// </summary>
        /// <returns></returns>
        #region
        private void CodeBanque()
        {
            char[] tabCodeBanque = codeBanqueTextBox.Text.ToCharArray();
            if (string.IsNullOrEmpty(codeBanqueTextBox.Text))
            {
                err.SetError(codeBanqueTextBox, "Champ vide !");
            }
            for (int i = 0; i < tabCodeBanque.Length; i++)
            {
                if (char.IsLetter(tabCodeBanque[i]))
                {
                    err.SetError(codeBanqueTextBox, "Lettres non acceptèe !");
                }
            }
            if (codeBanqueTextBox.Text.Length < 5 & !string.IsNullOrEmpty(codeBanqueTextBox.Text))
            {
                char pad = '0';
                string codeModifie = codeBanqueTextBox.Text.PadLeft(5, pad);
                codeBanqueTextBox.Text = codeModifie;
            }
        }
        private void CodeGuichet()
        {
            char[] tabCodeGuichet = codeGuichetTextBox.Text.ToCharArray();
            for (int i = 0; i < tabCodeGuichet.Length; i++)
            {
                if (char.IsLetter(tabCodeGuichet[i]))
                {
                    err.SetError(codeGuichetTextBox, "Lettres non acceptèe !");
                }
            }
            if (string.IsNullOrEmpty(codeGuichetTextBox.Text))
            {
                err.SetError(codeGuichetTextBox, "Champ vide !");
            }
            if (codeGuichetTextBox.Text.Length < 5 & !string.IsNullOrEmpty(codeGuichetTextBox.Text))
            {
                char pad = '0';
                string codeModifie = codeGuichetTextBox.Text.PadLeft(5, pad);
                codeGuichetTextBox.Text = codeModifie;
            }
        }
        private void NumeroDeCompte()
        {
            if (string.IsNullOrEmpty(numeroCompteTextBox.Text))
            {
                err.SetError(numeroCompteTextBox, "Champ vide !");
            }
            if (numeroCompteTextBox.Text.Length < 11 & !string.IsNullOrEmpty(numeroCompteTextBox.Text))
            {
                char pad = '0';
                string codeModifie = numeroCompteTextBox.Text.PadLeft(11, pad);
                numeroCompteTextBox.Text = codeModifie;
            }
        }
        #endregion

        /// <summary>
        /// Methode globale de vérification des champs. 
        /// Utilisée lors de l'évènement Click sur le boutton validation.
        /// </summary>
        /// <returns></returns>
        private bool IsSaisieValid()
        {
            char[] tabCodeBanque = codeBanqueTextBox.Text.ToCharArray();
            char[] tabCodeGuichet = codeGuichetTextBox.Text.ToCharArray();
            ///Code Banque
            if (string.IsNullOrEmpty(codeBanqueTextBox.Text))
            {
                err.SetError(codeBanqueTextBox, "Champ vide !");
            }
            for (int i = 0; i < tabCodeBanque.Length; i++)
            {
                if (char.IsLetter(tabCodeBanque[i]))
                {
                    err.SetError(codeBanqueTextBox, "Lettres non acceptèe !");
                }
            }
            ///Code Guichet
            if (string.IsNullOrEmpty(codeGuichetTextBox.Text))
            {
                err.SetError(codeBanqueTextBox, "Champ vide !");
            }
            for (int i = 0; i < tabCodeGuichet.Length; i++)
            {
                if (char.IsLetter(tabCodeGuichet[i]))
                {
                    err.SetError(codeGuichetTextBox, "Lettres non acceptèe !");
                }
            }

            if (string.IsNullOrEmpty(numeroCompteTextBox.Text))
            {
                err.SetError(numeroCompteTextBox, "Champ vide !");
            }
            if (string.IsNullOrEmpty(cleRIBTextBox.Text))
            {
                err.SetError(cleRIBTextBox, "Champ vide !");
            }
            if (string.IsNullOrEmpty(libellécompteTextBox.Text))
            {
                err.SetError(libellécompteTextBox, "Champ vide !");
                
            }
            return true;
        }

        /// <summary>
        /// Validation des champs.
        /// </summary>
        #region
        private void CodeBanqueTextBox_Validating(object sender, CancelEventArgs e)
        {
            CodeBanque();
        }

        private void CodeGuichetTextBox_Validating(object sender, CancelEventArgs e)
        {
            CodeGuichet();
        }

        private void NumeroCompteTextBox_Validating(object sender, CancelEventArgs e)
        {
            NumeroDeCompte();
        }
        private void LibellécompteTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(libellécompteTextBox.Text))
            {
                err.SetError(libellécompteTextBox, "Champ vide !");
            }
        }
        #endregion


        /// <summary>
        /// Validation de la cle rib.
        /// Une list stockPos récupère la position des Lettres contenues dans le compte.
        /// Le StringBuilder reconstruit la clé rib intermédiaire grâce à la variable Char lettre qui varie en fonction du tableau de conversion présenté sous forme de If.
        /// La clé intermédiaire obtenue est concaténée avec les champs code guichet et code banque.
        /// La clé intermédiaire est stockée dans textBoxVerif Todo>> mettre dans une variable
        /// La clé RIB est calculée grâce à la formule [K=97-MOD(100XcléIntermédiaire;97]
        /// Le calcul fonctionne pour l'exemple : code banque = 00005, code guichet = 00005, numéro de compte = 00000000005 cleRib =90 
        /// Si la clé est inférieur à 10 elle est complétez par un zero à gauche.
        /// </summary>

        private void CleRIBTextBox_Validating(object sender, CancelEventArgs e)
        {
            List<int> stockPos = new List<int>();
            char[] tabNumeroCompte = numeroCompteTextBox.Text.ToCharArray();
            string temp = numeroCompteTextBox.Text;

            for (int i = 0; i < tabNumeroCompte.Length; i++)
            {
                if (char.IsLetter(tabNumeroCompte[i]))
                {
                    stockPos.Add(i);
                }
            }
            foreach (int item in stockPos)
            {
                char lettre = tabNumeroCompte[item];
                StringBuilder str = new StringBuilder(temp);
                
                if (lettre == 'A' | lettre == 'J')
                {
                    lettre = '1';
                }
                if (lettre == 'B'| lettre == 'K'| lettre == 'S')
                {
                    lettre = '2';
                }
                if (lettre == 'C'| lettre == 'L'| lettre == 'T')
                {
                    lettre = '3';
                }
                if (lettre == 'D'| lettre == 'M'| lettre == 'U')
                {
                    lettre = '4';
                }
                if (lettre == 'E'| lettre == 'N'| lettre == 'V')
                {
                    lettre = '5';
                }
                if (lettre == 'F'| lettre == 'O'| lettre == 'W')
                {
                    lettre = '6';
                }
                if (lettre == 'G'| lettre == 'P'| lettre == 'X')
                {
                    lettre = '7';
                }
                if (lettre == 'H'| lettre == 'Q'| lettre == 'Y')
                {
                    lettre = '8';
                }
                if (lettre == 'I'| lettre == 'R'| lettre == 'Z')
                {
                    lettre = '9';
                }
                str[item] = lettre;
                temp = str.ToString();
                textBoxVerif.Text = temp;
            }
            string cleIntermediaire = codeBanqueTextBox.Text + codeGuichetTextBox.Text +textBoxVerif.Text ;
            long cleInter = Int64.Parse(cleIntermediaire);

            long cleRIB = 97-((100 * cleInter) %97) ;
            string cleRibdefinitive = cleRIB.ToString();
            if (cleRibdefinitive.Length<2)
            {
                char pad = '0';
                cleRibdefinitive.PadLeft(2, pad);
            }
            if (cleRibdefinitive!=cleRIBTextBox.Text)
            {
                err.SetError(cleRIBTextBox, "Clé nom valide !");
            }
            
        }

        private void LibellécompteTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsSaisieValid())
            {
                btnValider.Enabled = true;
            }
            
        }
    }
}
