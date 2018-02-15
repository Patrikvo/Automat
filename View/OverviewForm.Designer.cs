﻿namespace Automat.View
{
    partial class OverviewForm
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
            this.listBoxDossiers = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.linkLabelContactpersonen = new System.Windows.Forms.LinkLabel();
            this.labelContactpersoon = new System.Windows.Forms.Label();
            this.checkBoxIsArchived = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelStavaza = new System.Windows.Forms.Label();
            this.labelDossierTitel = new System.Windows.Forms.Label();
            this.labelDossierNummer = new System.Windows.Forms.Label();
            this.textBoxStavaza = new System.Windows.Forms.TextBox();
            this.textBoxDossierTitel = new System.Windows.Forms.TextBox();
            this.textBoxDossierNummer = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dossierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nieuwDossierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dossierWissenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toonArchiefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.persoonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overzichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxDossiers
            // 
            this.listBoxDossiers.DisplayMember = "Name";
            this.listBoxDossiers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxDossiers.FormattingEnabled = true;
            this.listBoxDossiers.Location = new System.Drawing.Point(0, 0);
            this.listBoxDossiers.Name = "listBoxDossiers";
            this.listBoxDossiers.Size = new System.Drawing.Size(261, 638);
            this.listBoxDossiers.TabIndex = 0;
            this.listBoxDossiers.ValueMember = "Id";
            this.listBoxDossiers.SelectedIndexChanged += new System.EventHandler(this.listBoxDossiers_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBoxDossiers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.linkLabelContactpersonen);
            this.splitContainer1.Panel2.Controls.Add(this.labelContactpersoon);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxIsArchived);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSave);
            this.splitContainer1.Panel2.Controls.Add(this.labelStavaza);
            this.splitContainer1.Panel2.Controls.Add(this.labelDossierTitel);
            this.splitContainer1.Panel2.Controls.Add(this.labelDossierNummer);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxStavaza);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxDossierTitel);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxDossierNummer);
            this.splitContainer1.Size = new System.Drawing.Size(742, 638);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.TabIndex = 1;
            // 
            // linkLabelContactpersonen
            // 
            this.linkLabelContactpersonen.AutoSize = true;
            this.linkLabelContactpersonen.Location = new System.Drawing.Point(98, 73);
            this.linkLabelContactpersonen.Name = "linkLabelContactpersonen";
            this.linkLabelContactpersonen.Size = new System.Drawing.Size(55, 13);
            this.linkLabelContactpersonen.TabIndex = 10;
            this.linkLabelContactpersonen.TabStop = true;
            this.linkLabelContactpersonen.Text = "onbekend";
            this.linkLabelContactpersonen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelContactpersonen_LinkClicked);
            // 
            // labelContactpersoon
            // 
            this.labelContactpersoon.AutoSize = true;
            this.labelContactpersoon.Location = new System.Drawing.Point(10, 73);
            this.labelContactpersoon.Name = "labelContactpersoon";
            this.labelContactpersoon.Size = new System.Drawing.Size(82, 13);
            this.labelContactpersoon.TabIndex = 9;
            this.labelContactpersoon.Text = "Contactpersoon";
            // 
            // checkBoxIsArchived
            // 
            this.checkBoxIsArchived.AutoSize = true;
            this.checkBoxIsArchived.Location = new System.Drawing.Point(13, 610);
            this.checkBoxIsArchived.Name = "checkBoxIsArchived";
            this.checkBoxIsArchived.Size = new System.Drawing.Size(90, 17);
            this.checkBoxIsArchived.TabIndex = 8;
            this.checkBoxIsArchived.Text = "Gearchiveerd";
            this.checkBoxIsArchived.UseVisualStyleBackColor = true;
            this.checkBoxIsArchived.CheckedChanged += new System.EventHandler(this.checkBoxIsArchived_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(384, 604);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Opslaan";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelStavaza
            // 
            this.labelStavaza.AutoSize = true;
            this.labelStavaza.Location = new System.Drawing.Point(10, 105);
            this.labelStavaza.Name = "labelStavaza";
            this.labelStavaza.Size = new System.Drawing.Size(88, 13);
            this.labelStavaza.TabIndex = 5;
            this.labelStavaza.Text = "Stand van zaken";
            // 
            // labelDossierTitel
            // 
            this.labelDossierTitel.AutoSize = true;
            this.labelDossierTitel.Location = new System.Drawing.Point(30, 42);
            this.labelDossierTitel.Name = "labelDossierTitel";
            this.labelDossierTitel.Size = new System.Drawing.Size(59, 13);
            this.labelDossierTitel.TabIndex = 4;
            this.labelDossierTitel.Text = "Onderwerp";
            // 
            // labelDossierNummer
            // 
            this.labelDossierNummer.AutoSize = true;
            this.labelDossierNummer.Location = new System.Drawing.Point(10, 16);
            this.labelDossierNummer.Name = "labelDossierNummer";
            this.labelDossierNummer.Size = new System.Drawing.Size(79, 13);
            this.labelDossierNummer.TabIndex = 3;
            this.labelDossierNummer.Text = "Dossiernummer";
            // 
            // textBoxStavaza
            // 
            this.textBoxStavaza.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStavaza.Location = new System.Drawing.Point(13, 121);
            this.textBoxStavaza.Multiline = true;
            this.textBoxStavaza.Name = "textBoxStavaza";
            this.textBoxStavaza.Size = new System.Drawing.Size(446, 477);
            this.textBoxStavaza.TabIndex = 2;
            // 
            // textBoxDossierTitel
            // 
            this.textBoxDossierTitel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDossierTitel.Location = new System.Drawing.Point(95, 39);
            this.textBoxDossierTitel.Name = "textBoxDossierTitel";
            this.textBoxDossierTitel.Size = new System.Drawing.Size(364, 20);
            this.textBoxDossierTitel.TabIndex = 1;
            // 
            // textBoxDossierNummer
            // 
            this.textBoxDossierNummer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDossierNummer.Location = new System.Drawing.Point(95, 13);
            this.textBoxDossierNummer.Name = "textBoxDossierNummer";
            this.textBoxDossierNummer.Size = new System.Drawing.Size(364, 20);
            this.textBoxDossierNummer.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 668);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(742, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.dossierToolStripMenuItem,
            this.persoonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.afsluitenToolStripMenuItem});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.bestandToolStripMenuItem.Text = "Bestand";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.afsluitenToolStripMenuItem.Text = "Afsluiten";
            this.afsluitenToolStripMenuItem.Click += new System.EventHandler(this.afsluitenToolStripMenuItem_Click);
            // 
            // dossierToolStripMenuItem
            // 
            this.dossierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nieuwDossierToolStripMenuItem1,
            this.dossierWissenToolStripMenuItem,
            this.toonArchiefToolStripMenuItem});
            this.dossierToolStripMenuItem.Name = "dossierToolStripMenuItem";
            this.dossierToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.dossierToolStripMenuItem.Text = "Dossier";
            // 
            // nieuwDossierToolStripMenuItem1
            // 
            this.nieuwDossierToolStripMenuItem1.Name = "nieuwDossierToolStripMenuItem1";
            this.nieuwDossierToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.nieuwDossierToolStripMenuItem1.Text = "Nieuw Dossier";
            this.nieuwDossierToolStripMenuItem1.Click += new System.EventHandler(this.nieuwDossierToolStripMenuItem_Click);
            // 
            // dossierWissenToolStripMenuItem
            // 
            this.dossierWissenToolStripMenuItem.Name = "dossierWissenToolStripMenuItem";
            this.dossierWissenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dossierWissenToolStripMenuItem.Text = "Dossier wissen";
            this.dossierWissenToolStripMenuItem.Click += new System.EventHandler(this.dossierWissenToolStripMenuItem_Click);
            // 
            // toonArchiefToolStripMenuItem
            // 
            this.toonArchiefToolStripMenuItem.Name = "toonArchiefToolStripMenuItem";
            this.toonArchiefToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.toonArchiefToolStripMenuItem.Text = "Toon Archief";
            this.toonArchiefToolStripMenuItem.Click += new System.EventHandler(this.toonArchiefToolStripMenuItem_Click);
            // 
            // persoonToolStripMenuItem
            // 
            this.persoonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overzichtToolStripMenuItem});
            this.persoonToolStripMenuItem.Name = "persoonToolStripMenuItem";
            this.persoonToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.persoonToolStripMenuItem.Text = "Persoon";
            // 
            // overzichtToolStripMenuItem
            // 
            this.overzichtToolStripMenuItem.Name = "overzichtToolStripMenuItem";
            this.overzichtToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.overzichtToolStripMenuItem.Text = "Overzicht";
            this.overzichtToolStripMenuItem.Click += new System.EventHandler(this.overzichtToolStripMenuItem_Click);
            // 
            // OverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 690);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OverviewForm";
            this.Text = "OverviewForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OverviewForm_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDossiers;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelStavaza;
        private System.Windows.Forms.Label labelDossierTitel;
        private System.Windows.Forms.Label labelDossierNummer;
        private System.Windows.Forms.TextBox textBoxStavaza;
        private System.Windows.Forms.TextBox textBoxDossierTitel;
        private System.Windows.Forms.TextBox textBoxDossierNummer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem dossierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nieuwDossierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dossierWissenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem persoonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overzichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toonArchiefToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxIsArchived;
        private System.Windows.Forms.Label labelContactpersoon;
        private System.Windows.Forms.LinkLabel linkLabelContactpersonen;
    }
}