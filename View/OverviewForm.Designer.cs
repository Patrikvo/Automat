namespace Automat.View
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
            this.components = new System.ComponentModel.Container();
            this.listBoxDossiers = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.linkLabelfiles = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxContactpersonen = new System.Windows.Forms.ComboBox();
            this.textBoxDossierNummer = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBoxIsArchived = new System.Windows.Forms.CheckBox();
            this.textBoxDossierTitel = new System.Windows.Forms.TextBox();
            this.textBoxStavaza = new System.Windows.Forms.TextBox();
            this.labelContactpersoon = new System.Windows.Forms.Label();
            this.labelDossierNummer = new System.Windows.Forms.Label();
            this.labelDossierTitel = new System.Windows.Forms.Label();
            this.labelStavaza = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.contextMenuStripFiles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStripFiles.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(742, 638);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(477, 638);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.linkLabelfiles);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.comboBoxContactpersonen);
            this.tabPage1.Controls.Add(this.textBoxDossierNummer);
            this.tabPage1.Controls.Add(this.buttonSave);
            this.tabPage1.Controls.Add(this.checkBoxIsArchived);
            this.tabPage1.Controls.Add(this.textBoxDossierTitel);
            this.tabPage1.Controls.Add(this.textBoxStavaza);
            this.tabPage1.Controls.Add(this.labelContactpersoon);
            this.tabPage1.Controls.Add(this.labelDossierNummer);
            this.tabPage1.Controls.Add(this.labelDossierTitel);
            this.tabPage1.Controls.Add(this.labelStavaza);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(469, 612);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Voorblad";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // linkLabelfiles
            // 
            this.linkLabelfiles.AutoEllipsis = true;
            this.linkLabelfiles.AutoSize = true;
            this.linkLabelfiles.ContextMenuStrip = this.contextMenuStripFiles;
            this.linkLabelfiles.Location = new System.Drawing.Point(97, 110);
            this.linkLabelfiles.Name = "linkLabelfiles";
            this.linkLabelfiles.Size = new System.Drawing.Size(83, 13);
            this.linkLabelfiles.TabIndex = 13;
            this.linkLabelfiles.TabStop = true;
            this.linkLabelfiles.Text = "Naar bestanden";
            this.linkLabelfiles.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelfiles_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxContactpersonen
            // 
            this.comboBoxContactpersonen.DisplayMember = "Item1";
            this.comboBoxContactpersonen.FormattingEnabled = true;
            this.comboBoxContactpersonen.Location = new System.Drawing.Point(100, 86);
            this.comboBoxContactpersonen.Name = "comboBoxContactpersonen";
            this.comboBoxContactpersonen.Size = new System.Drawing.Size(280, 21);
            this.comboBoxContactpersonen.TabIndex = 11;
            this.comboBoxContactpersonen.ValueMember = "Item2";
            // 
            // textBoxDossierNummer
            // 
            this.textBoxDossierNummer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDossierNummer.Location = new System.Drawing.Point(100, 29);
            this.textBoxDossierNummer.Name = "textBoxDossierNummer";
            this.textBoxDossierNummer.Size = new System.Drawing.Size(361, 20);
            this.textBoxDossierNummer.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(386, 583);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Opslaan";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // checkBoxIsArchived
            // 
            this.checkBoxIsArchived.AutoSize = true;
            this.checkBoxIsArchived.Location = new System.Drawing.Point(18, 589);
            this.checkBoxIsArchived.Name = "checkBoxIsArchived";
            this.checkBoxIsArchived.Size = new System.Drawing.Size(90, 17);
            this.checkBoxIsArchived.TabIndex = 8;
            this.checkBoxIsArchived.Text = "Gearchiveerd";
            this.checkBoxIsArchived.UseVisualStyleBackColor = true;
            this.checkBoxIsArchived.CheckedChanged += new System.EventHandler(this.checkBoxIsArchived_CheckedChanged);
            // 
            // textBoxDossierTitel
            // 
            this.textBoxDossierTitel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDossierTitel.Location = new System.Drawing.Point(100, 55);
            this.textBoxDossierTitel.Name = "textBoxDossierTitel";
            this.textBoxDossierTitel.Size = new System.Drawing.Size(361, 20);
            this.textBoxDossierTitel.TabIndex = 1;
            // 
            // textBoxStavaza
            // 
            this.textBoxStavaza.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStavaza.Location = new System.Drawing.Point(18, 155);
            this.textBoxStavaza.Multiline = true;
            this.textBoxStavaza.Name = "textBoxStavaza";
            this.textBoxStavaza.Size = new System.Drawing.Size(443, 422);
            this.textBoxStavaza.TabIndex = 2;
            // 
            // labelContactpersoon
            // 
            this.labelContactpersoon.AutoSize = true;
            this.labelContactpersoon.Location = new System.Drawing.Point(12, 89);
            this.labelContactpersoon.Name = "labelContactpersoon";
            this.labelContactpersoon.Size = new System.Drawing.Size(82, 13);
            this.labelContactpersoon.TabIndex = 9;
            this.labelContactpersoon.Text = "Contactpersoon";
            // 
            // labelDossierNummer
            // 
            this.labelDossierNummer.AutoSize = true;
            this.labelDossierNummer.Location = new System.Drawing.Point(15, 32);
            this.labelDossierNummer.Name = "labelDossierNummer";
            this.labelDossierNummer.Size = new System.Drawing.Size(79, 13);
            this.labelDossierNummer.TabIndex = 3;
            this.labelDossierNummer.Text = "Dossiernummer";
            // 
            // labelDossierTitel
            // 
            this.labelDossierTitel.AutoSize = true;
            this.labelDossierTitel.Location = new System.Drawing.Point(35, 58);
            this.labelDossierTitel.Name = "labelDossierTitel";
            this.labelDossierTitel.Size = new System.Drawing.Size(59, 13);
            this.labelDossierTitel.TabIndex = 4;
            this.labelDossierTitel.Text = "Onderwerp";
            // 
            // labelStavaza
            // 
            this.labelStavaza.AutoSize = true;
            this.labelStavaza.Location = new System.Drawing.Point(15, 139);
            this.labelStavaza.Name = "labelStavaza";
            this.labelStavaza.Size = new System.Drawing.Size(88, 13);
            this.labelStavaza.TabIndex = 5;
            this.labelStavaza.Text = "Stand van zaken";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(469, 612);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.toolStripSeparator1.Size = new System.Drawing.Size(118, 6);
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
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
            this.nieuwDossierToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.nieuwDossierToolStripMenuItem1.Text = "Nieuw Dossier";
            this.nieuwDossierToolStripMenuItem1.Click += new System.EventHandler(this.nieuwDossierToolStripMenuItem_Click);
            // 
            // dossierWissenToolStripMenuItem
            // 
            this.dossierWissenToolStripMenuItem.Name = "dossierWissenToolStripMenuItem";
            this.dossierWissenToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.dossierWissenToolStripMenuItem.Text = "Dossier wissen";
            this.dossierWissenToolStripMenuItem.Click += new System.EventHandler(this.dossierWissenToolStripMenuItem_Click);
            // 
            // toonArchiefToolStripMenuItem
            // 
            this.toonArchiefToolStripMenuItem.Name = "toonArchiefToolStripMenuItem";
            this.toonArchiefToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
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
            this.overzichtToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.overzichtToolStripMenuItem.Text = "Overzicht";
            this.overzichtToolStripMenuItem.Click += new System.EventHandler(this.overzichtToolStripMenuItem_Click);
            // 
            // contextMenuStripFiles
            // 
            this.contextMenuStripFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEdit});
            this.contextMenuStripFiles.Name = "contextMenuStripFiles";
            this.contextMenuStripFiles.Size = new System.Drawing.Size(153, 48);
            this.contextMenuStripFiles.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripFiles_ItemClicked);
            // 
            // toolStripMenuItemEdit
            // 
            this.toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            this.toolStripMenuItemEdit.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemEdit.Text = "Bewerken";
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStripFiles.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxContactpersonen;
        private System.Windows.Forms.LinkLabel linkLabelfiles;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFiles;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit;
    }
}