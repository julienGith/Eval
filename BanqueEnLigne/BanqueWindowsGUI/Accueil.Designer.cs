﻿namespace BanqueWindowsGUI
{
    partial class Accueil
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnNouveauVirementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionsDesVirementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnNouveauVirementToolStripMenuItem,
            this.gestionsDesVirementsToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // ajouterUnNouveauVirementToolStripMenuItem
            // 
            this.ajouterUnNouveauVirementToolStripMenuItem.Name = "ajouterUnNouveauVirementToolStripMenuItem";
            this.ajouterUnNouveauVirementToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.ajouterUnNouveauVirementToolStripMenuItem.Text = "Ajouter un nouveau virement";
            this.ajouterUnNouveauVirementToolStripMenuItem.Click += new System.EventHandler(this.AjouterUnNouveauVirementToolStripMenuItem_Click);
            // 
            // gestionsDesVirementsToolStripMenuItem
            // 
            this.gestionsDesVirementsToolStripMenuItem.Name = "gestionsDesVirementsToolStripMenuItem";
            this.gestionsDesVirementsToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.gestionsDesVirementsToolStripMenuItem.Text = "Gestions des Virements";
            this.gestionsDesVirementsToolStripMenuItem.Click += new System.EventHandler(this.GestionsDesVirementsToolStripMenuItem_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnNouveauVirementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionsDesVirementsToolStripMenuItem;
    }
}