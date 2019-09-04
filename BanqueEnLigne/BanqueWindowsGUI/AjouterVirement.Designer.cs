namespace BanqueWindowsGUI
{
    partial class AjouterVirement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddCompte = new System.Windows.Forms.Button();
            this.btnListeComptes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddCompte
            // 
            this.buttonAddCompte.Location = new System.Drawing.Point(88, 47);
            this.buttonAddCompte.Name = "buttonAddCompte";
            this.buttonAddCompte.Size = new System.Drawing.Size(131, 85);
            this.buttonAddCompte.TabIndex = 0;
            this.buttonAddCompte.Text = "Ajouter un nouveau compte";
            this.buttonAddCompte.UseVisualStyleBackColor = true;
            this.buttonAddCompte.Click += new System.EventHandler(this.ButtonAddCompte_Click);
            // 
            // btnListeComptes
            // 
            this.btnListeComptes.Location = new System.Drawing.Point(261, 47);
            this.btnListeComptes.Name = "btnListeComptes";
            this.btnListeComptes.Size = new System.Drawing.Size(131, 85);
            this.btnListeComptes.TabIndex = 1;
            this.btnListeComptes.Text = "Choisir un Compte ";
            this.btnListeComptes.UseVisualStyleBackColor = true;
            this.btnListeComptes.Click += new System.EventHandler(this.BtnListeComptes_Click);
            // 
            // AjouterVirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListeComptes);
            this.Controls.Add(this.buttonAddCompte);
            this.Name = "AjouterVirement";
            this.Text = "AjouterVirement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddCompte;
        private System.Windows.Forms.Button btnListeComptes;
    }
}