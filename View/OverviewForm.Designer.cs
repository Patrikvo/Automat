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
            this.comboBoxProcuringEntity = new System.Windows.Forms.ComboBox();
            this.labelProcuringEntity = new System.Windows.Forms.Label();
            this.labelTypeOfContract = new System.Windows.Forms.Label();
            this.comboBoxTypeOfContract = new System.Windows.Forms.ComboBox();
            this.checkBoxIsEuropeanPublished = new System.Windows.Forms.CheckBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxProcedure = new System.Windows.Forms.ComboBox();
            this.labelProcedure = new System.Windows.Forms.Label();
            this.linkLabelfiles = new System.Windows.Forms.LinkLabel();
            this.contextMenuStripFiles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tabPageContact = new System.Windows.Forms.TabPage();
            this.buttonSaveP2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRemovePerson = new System.Windows.Forms.Button();
            this.buttonAddPerson = new System.Windows.Forms.Button();
            this.listBoxAllPersons = new System.Windows.Forms.ListBox();
            this.listBoxLinkedPersons = new System.Windows.Forms.ListBox();
            this.tabPagePlanning = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxAddEvent = new System.Windows.Forms.GroupBox();
            this.radioButtonExtern = new System.Windows.Forms.RadioButton();
            this.radioButtonKlant = new System.Windows.Forms.RadioButton();
            this.radioButtonDossierbeheerder = new System.Windows.Forms.RadioButton();
            this.labelDeadline = new System.Windows.Forms.Label();
            this.buttonAddEvent = new System.Windows.Forms.Button();
            this.textBoxOnderwerp = new System.Windows.Forms.TextBox();
            this.labelOnderwerp = new System.Windows.Forms.Label();
            this.dateTimePickerDeadline = new System.Windows.Forms.DateTimePicker();
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
            this.planningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toonOverzichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contextMenuStripFiles.SuspendLayout();
            this.tabPageContact.SuspendLayout();
            this.tabPagePlanning.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxAddEvent.SuspendLayout();
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
            this.listBoxDossiers.ScrollAlwaysVisible = true;
            this.listBoxDossiers.Size = new System.Drawing.Size(261, 638);
            this.listBoxDossiers.TabIndex = 0;
            this.listBoxDossiers.ValueMember = "Id";
            this.listBoxDossiers.SelectedIndexChanged += new System.EventHandler(this.ListBoxDossiers_SelectedIndexChanged);
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
            this.tabControl1.Controls.Add(this.tabPageContact);
            this.tabControl1.Controls.Add(this.tabPagePlanning);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(477, 638);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxProcuringEntity);
            this.tabPage1.Controls.Add(this.labelProcuringEntity);
            this.tabPage1.Controls.Add(this.labelTypeOfContract);
            this.tabPage1.Controls.Add(this.comboBoxTypeOfContract);
            this.tabPage1.Controls.Add(this.checkBoxIsEuropeanPublished);
            this.tabPage1.Controls.Add(this.comboBoxType);
            this.tabPage1.Controls.Add(this.comboBoxProcedure);
            this.tabPage1.Controls.Add(this.labelProcedure);
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
            // comboBoxProcuringEntity
            // 
            this.comboBoxProcuringEntity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProcuringEntity.FormattingEnabled = true;
            this.comboBoxProcuringEntity.Location = new System.Drawing.Point(100, 171);
            this.comboBoxProcuringEntity.Name = "comboBoxProcuringEntity";
            this.comboBoxProcuringEntity.Size = new System.Drawing.Size(361, 21);
            this.comboBoxProcuringEntity.TabIndex = 21;
            // 
            // labelProcuringEntity
            // 
            this.labelProcuringEntity.AutoSize = true;
            this.labelProcuringEntity.Location = new System.Drawing.Point(72, 174);
            this.labelProcuringEntity.Name = "labelProcuringEntity";
            this.labelProcuringEntity.Size = new System.Drawing.Size(22, 13);
            this.labelProcuringEntity.TabIndex = 20;
            this.labelProcuringEntity.Text = "AO";
            // 
            // labelTypeOfContract
            // 
            this.labelTypeOfContract.AutoSize = true;
            this.labelTypeOfContract.Location = new System.Drawing.Point(27, 147);
            this.labelTypeOfContract.Name = "labelTypeOfContract";
            this.labelTypeOfContract.Size = new System.Drawing.Size(67, 13);
            this.labelTypeOfContract.TabIndex = 19;
            this.labelTypeOfContract.Text = "Contracttype";
            // 
            // comboBoxTypeOfContract
            // 
            this.comboBoxTypeOfContract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeOfContract.FormattingEnabled = true;
            this.comboBoxTypeOfContract.Location = new System.Drawing.Point(100, 144);
            this.comboBoxTypeOfContract.Name = "comboBoxTypeOfContract";
            this.comboBoxTypeOfContract.Size = new System.Drawing.Size(361, 21);
            this.comboBoxTypeOfContract.TabIndex = 18;
            // 
            // checkBoxIsEuropeanPublished
            // 
            this.checkBoxIsEuropeanPublished.AutoSize = true;
            this.checkBoxIsEuropeanPublished.Location = new System.Drawing.Point(291, 8);
            this.checkBoxIsEuropeanPublished.Name = "checkBoxIsEuropeanPublished";
            this.checkBoxIsEuropeanPublished.Size = new System.Drawing.Size(122, 17);
            this.checkBoxIsEuropeanPublished.TabIndex = 17;
            this.checkBoxIsEuropeanPublished.Text = "Europese procedure";
            this.checkBoxIsEuropeanPublished.UseVisualStyleBackColor = true;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(419, 6);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(42, 21);
            this.comboBoxType.TabIndex = 16;
            // 
            // comboBoxProcedure
            // 
            this.comboBoxProcedure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProcedure.FormattingEnabled = true;
            this.comboBoxProcedure.Location = new System.Drawing.Point(100, 117);
            this.comboBoxProcedure.Name = "comboBoxProcedure";
            this.comboBoxProcedure.Size = new System.Drawing.Size(361, 21);
            this.comboBoxProcedure.Sorted = true;
            this.comboBoxProcedure.TabIndex = 15;
            // 
            // labelProcedure
            // 
            this.labelProcedure.AutoSize = true;
            this.labelProcedure.Location = new System.Drawing.Point(38, 120);
            this.labelProcedure.Name = "labelProcedure";
            this.labelProcedure.Size = new System.Drawing.Size(56, 13);
            this.labelProcedure.TabIndex = 14;
            this.labelProcedure.Text = "Procedure";
            // 
            // linkLabelfiles
            // 
            this.linkLabelfiles.AutoEllipsis = true;
            this.linkLabelfiles.AutoSize = true;
            this.linkLabelfiles.ContextMenuStrip = this.contextMenuStripFiles;
            this.linkLabelfiles.Location = new System.Drawing.Point(97, 204);
            this.linkLabelfiles.Name = "linkLabelfiles";
            this.linkLabelfiles.Size = new System.Drawing.Size(83, 13);
            this.linkLabelfiles.TabIndex = 13;
            this.linkLabelfiles.TabStop = true;
            this.linkLabelfiles.Text = "Naar bestanden";
            this.linkLabelfiles.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelfiles_LinkClicked);
            // 
            // contextMenuStripFiles
            // 
            this.contextMenuStripFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEdit});
            this.contextMenuStripFiles.Name = "contextMenuStripFiles";
            this.contextMenuStripFiles.Size = new System.Drawing.Size(126, 26);
            this.contextMenuStripFiles.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenuStripFiles_ItemClicked);
            // 
            // toolStripMenuItemEdit
            // 
            this.toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            this.toolStripMenuItemEdit.Size = new System.Drawing.Size(125, 22);
            this.toolStripMenuItemEdit.Text = "Bewerken";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxContactpersonen
            // 
            this.comboBoxContactpersonen.DisplayMember = "Item1";
            this.comboBoxContactpersonen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContactpersonen.FormattingEnabled = true;
            this.comboBoxContactpersonen.Location = new System.Drawing.Point(100, 90);
            this.comboBoxContactpersonen.Name = "comboBoxContactpersonen";
            this.comboBoxContactpersonen.Size = new System.Drawing.Size(280, 21);
            this.comboBoxContactpersonen.TabIndex = 11;
            this.comboBoxContactpersonen.ValueMember = "Item2";
            // 
            // textBoxDossierNummer
            // 
            this.textBoxDossierNummer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDossierNummer.Location = new System.Drawing.Point(100, 33);
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
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // checkBoxIsArchived
            // 
            this.checkBoxIsArchived.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxIsArchived.AutoSize = true;
            this.checkBoxIsArchived.Location = new System.Drawing.Point(18, 589);
            this.checkBoxIsArchived.Name = "checkBoxIsArchived";
            this.checkBoxIsArchived.Size = new System.Drawing.Size(99, 17);
            this.checkBoxIsArchived.TabIndex = 8;
            this.checkBoxIsArchived.Text = "Is gearchiveerd";
            this.checkBoxIsArchived.UseVisualStyleBackColor = true;
            this.checkBoxIsArchived.CheckedChanged += new System.EventHandler(this.CheckBoxIsArchived_CheckedChanged);
            // 
            // textBoxDossierTitel
            // 
            this.textBoxDossierTitel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDossierTitel.Location = new System.Drawing.Point(100, 59);
            this.textBoxDossierTitel.Name = "textBoxDossierTitel";
            this.textBoxDossierTitel.Size = new System.Drawing.Size(361, 20);
            this.textBoxDossierTitel.TabIndex = 1;
            // 
            // textBoxStavaza
            // 
            this.textBoxStavaza.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStavaza.Location = new System.Drawing.Point(18, 233);
            this.textBoxStavaza.Multiline = true;
            this.textBoxStavaza.Name = "textBoxStavaza";
            this.textBoxStavaza.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxStavaza.Size = new System.Drawing.Size(443, 344);
            this.textBoxStavaza.TabIndex = 2;
            this.textBoxStavaza.WordWrap = false;
            this.textBoxStavaza.TextChanged += new System.EventHandler(this.TextBoxStavaza_TextChanged);
            // 
            // labelContactpersoon
            // 
            this.labelContactpersoon.AutoSize = true;
            this.labelContactpersoon.Location = new System.Drawing.Point(12, 93);
            this.labelContactpersoon.Name = "labelContactpersoon";
            this.labelContactpersoon.Size = new System.Drawing.Size(82, 13);
            this.labelContactpersoon.TabIndex = 9;
            this.labelContactpersoon.Text = "Contactpersoon";
            // 
            // labelDossierNummer
            // 
            this.labelDossierNummer.AutoSize = true;
            this.labelDossierNummer.Location = new System.Drawing.Point(15, 36);
            this.labelDossierNummer.Name = "labelDossierNummer";
            this.labelDossierNummer.Size = new System.Drawing.Size(79, 13);
            this.labelDossierNummer.TabIndex = 3;
            this.labelDossierNummer.Text = "Dossiernummer";
            // 
            // labelDossierTitel
            // 
            this.labelDossierTitel.AutoSize = true;
            this.labelDossierTitel.Location = new System.Drawing.Point(35, 62);
            this.labelDossierTitel.Name = "labelDossierTitel";
            this.labelDossierTitel.Size = new System.Drawing.Size(59, 13);
            this.labelDossierTitel.TabIndex = 4;
            this.labelDossierTitel.Text = "Onderwerp";
            // 
            // labelStavaza
            // 
            this.labelStavaza.AutoSize = true;
            this.labelStavaza.Location = new System.Drawing.Point(15, 217);
            this.labelStavaza.Name = "labelStavaza";
            this.labelStavaza.Size = new System.Drawing.Size(88, 13);
            this.labelStavaza.TabIndex = 5;
            this.labelStavaza.Text = "Stand van zaken";
            // 
            // tabPageContact
            // 
            this.tabPageContact.Controls.Add(this.buttonSaveP2);
            this.tabPageContact.Controls.Add(this.label2);
            this.tabPageContact.Controls.Add(this.label1);
            this.tabPageContact.Controls.Add(this.buttonRemovePerson);
            this.tabPageContact.Controls.Add(this.buttonAddPerson);
            this.tabPageContact.Controls.Add(this.listBoxAllPersons);
            this.tabPageContact.Controls.Add(this.listBoxLinkedPersons);
            this.tabPageContact.Location = new System.Drawing.Point(4, 22);
            this.tabPageContact.Name = "tabPageContact";
            this.tabPageContact.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageContact.Size = new System.Drawing.Size(469, 612);
            this.tabPageContact.TabIndex = 1;
            this.tabPageContact.Text = "Contact";
            this.tabPageContact.UseVisualStyleBackColor = true;
            // 
            // buttonSaveP2
            // 
            this.buttonSaveP2.Location = new System.Drawing.Point(386, 228);
            this.buttonSaveP2.Name = "buttonSaveP2";
            this.buttonSaveP2.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveP2.TabIndex = 6;
            this.buttonSaveP2.Text = "Save";
            this.buttonSaveP2.UseVisualStyleBackColor = true;
            this.buttonSaveP2.Click += new System.EventHandler(this.ButtonSaveP2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alle Personen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gekoppelde personen";
            // 
            // buttonRemovePerson
            // 
            this.buttonRemovePerson.Location = new System.Drawing.Point(220, 122);
            this.buttonRemovePerson.Name = "buttonRemovePerson";
            this.buttonRemovePerson.Size = new System.Drawing.Size(25, 23);
            this.buttonRemovePerson.TabIndex = 3;
            this.buttonRemovePerson.Text = "->";
            this.buttonRemovePerson.UseVisualStyleBackColor = true;
            this.buttonRemovePerson.Click += new System.EventHandler(this.ButtonRemovePerson_Click);
            // 
            // buttonAddPerson
            // 
            this.buttonAddPerson.Location = new System.Drawing.Point(220, 93);
            this.buttonAddPerson.Name = "buttonAddPerson";
            this.buttonAddPerson.Size = new System.Drawing.Size(25, 23);
            this.buttonAddPerson.TabIndex = 2;
            this.buttonAddPerson.Text = "<-";
            this.buttonAddPerson.UseVisualStyleBackColor = true;
            this.buttonAddPerson.Click += new System.EventHandler(this.ButtonAddPerson_Click);
            // 
            // listBoxAllPersons
            // 
            this.listBoxAllPersons.FormattingEnabled = true;
            this.listBoxAllPersons.Location = new System.Drawing.Point(251, 49);
            this.listBoxAllPersons.Name = "listBoxAllPersons";
            this.listBoxAllPersons.ScrollAlwaysVisible = true;
            this.listBoxAllPersons.Size = new System.Drawing.Size(210, 173);
            this.listBoxAllPersons.TabIndex = 1;
            // 
            // listBoxLinkedPersons
            // 
            this.listBoxLinkedPersons.FormattingEnabled = true;
            this.listBoxLinkedPersons.Location = new System.Drawing.Point(6, 49);
            this.listBoxLinkedPersons.Name = "listBoxLinkedPersons";
            this.listBoxLinkedPersons.ScrollAlwaysVisible = true;
            this.listBoxLinkedPersons.Size = new System.Drawing.Size(208, 173);
            this.listBoxLinkedPersons.TabIndex = 0;
            // 
            // tabPagePlanning
            // 
            this.tabPagePlanning.Controls.Add(this.panel1);
            this.tabPagePlanning.Controls.Add(this.groupBoxAddEvent);
            this.tabPagePlanning.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlanning.Name = "tabPagePlanning";
            this.tabPagePlanning.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlanning.Size = new System.Drawing.Size(469, 612);
            this.tabPagePlanning.TabIndex = 2;
            this.tabPagePlanning.Text = "Planning";
            this.tabPagePlanning.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listBoxTasks);
            this.panel1.Location = new System.Drawing.Point(3, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 473);
            this.panel1.TabIndex = 2;
            // 
            // groupBoxAddEvent
            // 
            this.groupBoxAddEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAddEvent.Controls.Add(this.radioButtonExtern);
            this.groupBoxAddEvent.Controls.Add(this.radioButtonKlant);
            this.groupBoxAddEvent.Controls.Add(this.radioButtonDossierbeheerder);
            this.groupBoxAddEvent.Controls.Add(this.labelDeadline);
            this.groupBoxAddEvent.Controls.Add(this.buttonAddEvent);
            this.groupBoxAddEvent.Controls.Add(this.textBoxOnderwerp);
            this.groupBoxAddEvent.Controls.Add(this.labelOnderwerp);
            this.groupBoxAddEvent.Controls.Add(this.dateTimePickerDeadline);
            this.groupBoxAddEvent.Location = new System.Drawing.Point(6, 6);
            this.groupBoxAddEvent.Name = "groupBoxAddEvent";
            this.groupBoxAddEvent.Size = new System.Drawing.Size(455, 121);
            this.groupBoxAddEvent.TabIndex = 1;
            this.groupBoxAddEvent.TabStop = false;
            this.groupBoxAddEvent.Text = "Toevoegen";
            // 
            // radioButtonExtern
            // 
            this.radioButtonExtern.AutoSize = true;
            this.radioButtonExtern.Location = new System.Drawing.Point(6, 91);
            this.radioButtonExtern.Name = "radioButtonExtern";
            this.radioButtonExtern.Size = new System.Drawing.Size(55, 17);
            this.radioButtonExtern.TabIndex = 7;
            this.radioButtonExtern.TabStop = true;
            this.radioButtonExtern.Text = "Extern";
            this.radioButtonExtern.UseVisualStyleBackColor = true;
            // 
            // radioButtonKlant
            // 
            this.radioButtonKlant.AutoSize = true;
            this.radioButtonKlant.Location = new System.Drawing.Point(6, 68);
            this.radioButtonKlant.Name = "radioButtonKlant";
            this.radioButtonKlant.Size = new System.Drawing.Size(49, 17);
            this.radioButtonKlant.TabIndex = 6;
            this.radioButtonKlant.Text = "Klant";
            this.radioButtonKlant.UseVisualStyleBackColor = true;
            // 
            // radioButtonDossierbeheerder
            // 
            this.radioButtonDossierbeheerder.AutoSize = true;
            this.radioButtonDossierbeheerder.Checked = true;
            this.radioButtonDossierbeheerder.Location = new System.Drawing.Point(6, 45);
            this.radioButtonDossierbeheerder.Name = "radioButtonDossierbeheerder";
            this.radioButtonDossierbeheerder.Size = new System.Drawing.Size(108, 17);
            this.radioButtonDossierbeheerder.TabIndex = 5;
            this.radioButtonDossierbeheerder.TabStop = true;
            this.radioButtonDossierbeheerder.Text = "Dossierbeheerder";
            this.radioButtonDossierbeheerder.UseVisualStyleBackColor = true;
            // 
            // labelDeadline
            // 
            this.labelDeadline.AutoSize = true;
            this.labelDeadline.Location = new System.Drawing.Point(194, 51);
            this.labelDeadline.Name = "labelDeadline";
            this.labelDeadline.Size = new System.Drawing.Size(49, 13);
            this.labelDeadline.TabIndex = 4;
            this.labelDeadline.Text = "Deadline";
            // 
            // buttonAddEvent
            // 
            this.buttonAddEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddEvent.Location = new System.Drawing.Point(374, 92);
            this.buttonAddEvent.Name = "buttonAddEvent";
            this.buttonAddEvent.Size = new System.Drawing.Size(75, 23);
            this.buttonAddEvent.TabIndex = 3;
            this.buttonAddEvent.Text = "Toevoegen";
            this.buttonAddEvent.UseVisualStyleBackColor = true;
            this.buttonAddEvent.Click += new System.EventHandler(this.buttonAddEvent_Click);
            // 
            // textBoxOnderwerp
            // 
            this.textBoxOnderwerp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOnderwerp.Location = new System.Drawing.Point(71, 19);
            this.textBoxOnderwerp.Name = "textBoxOnderwerp";
            this.textBoxOnderwerp.Size = new System.Drawing.Size(378, 20);
            this.textBoxOnderwerp.TabIndex = 2;
            // 
            // labelOnderwerp
            // 
            this.labelOnderwerp.AutoSize = true;
            this.labelOnderwerp.Location = new System.Drawing.Point(6, 22);
            this.labelOnderwerp.Name = "labelOnderwerp";
            this.labelOnderwerp.Size = new System.Drawing.Size(59, 13);
            this.labelOnderwerp.TabIndex = 1;
            this.labelOnderwerp.Text = "Onderwerp";
            // 
            // dateTimePickerDeadline
            // 
            this.dateTimePickerDeadline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDeadline.Location = new System.Drawing.Point(249, 45);
            this.dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            this.dateTimePickerDeadline.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDeadline.TabIndex = 0;
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
            this.persoonToolStripMenuItem,
            this.planningToolStripMenuItem});
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
            this.afsluitenToolStripMenuItem.Click += new System.EventHandler(this.AfsluitenToolStripMenuItem_Click);
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
            this.nieuwDossierToolStripMenuItem1.Click += new System.EventHandler(this.NieuwDossierToolStripMenuItem_Click);
            // 
            // dossierWissenToolStripMenuItem
            // 
            this.dossierWissenToolStripMenuItem.Name = "dossierWissenToolStripMenuItem";
            this.dossierWissenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dossierWissenToolStripMenuItem.Text = "Dossier wissen";
            this.dossierWissenToolStripMenuItem.Click += new System.EventHandler(this.DossierWissenToolStripMenuItem_Click);
            // 
            // toonArchiefToolStripMenuItem
            // 
            this.toonArchiefToolStripMenuItem.Name = "toonArchiefToolStripMenuItem";
            this.toonArchiefToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.toonArchiefToolStripMenuItem.Text = "Toon Archief";
            this.toonArchiefToolStripMenuItem.Click += new System.EventHandler(this.ToonArchiefToolStripMenuItem_Click);
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
            this.overzichtToolStripMenuItem.Click += new System.EventHandler(this.OverzichtToolStripMenuItem_Click);
            // 
            // planningToolStripMenuItem
            // 
            this.planningToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toonOverzichtToolStripMenuItem});
            this.planningToolStripMenuItem.Name = "planningToolStripMenuItem";
            this.planningToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.planningToolStripMenuItem.Text = "Planning";
            // 
            // toonOverzichtToolStripMenuItem
            // 
            this.toonOverzichtToolStripMenuItem.Name = "toonOverzichtToolStripMenuItem";
            this.toonOverzichtToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.toonOverzichtToolStripMenuItem.Text = "Toon Overzicht";
            this.toonOverzichtToolStripMenuItem.Click += new System.EventHandler(this.toonOverzichtToolStripMenuItem_Click);
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.Location = new System.Drawing.Point(0, 0);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(461, 471);
            this.listBoxTasks.TabIndex = 0;
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
            this.contextMenuStripFiles.ResumeLayout(false);
            this.tabPageContact.ResumeLayout(false);
            this.tabPageContact.PerformLayout();
            this.tabPagePlanning.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBoxAddEvent.ResumeLayout(false);
            this.groupBoxAddEvent.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageContact;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxContactpersonen;
        private System.Windows.Forms.LinkLabel linkLabelfiles;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFiles;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit;
        private System.Windows.Forms.Button buttonRemovePerson;
        private System.Windows.Forms.Button buttonAddPerson;
        private System.Windows.Forms.ListBox listBoxAllPersons;
        private System.Windows.Forms.ListBox listBoxLinkedPersons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveP2;
        private System.Windows.Forms.ComboBox comboBoxProcedure;
        private System.Windows.Forms.Label labelProcedure;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.CheckBox checkBoxIsEuropeanPublished;
        private System.Windows.Forms.Label labelTypeOfContract;
        private System.Windows.Forms.ComboBox comboBoxTypeOfContract;
        private System.Windows.Forms.ComboBox comboBoxProcuringEntity;
        private System.Windows.Forms.Label labelProcuringEntity;
        private System.Windows.Forms.TabPage tabPagePlanning;
        private System.Windows.Forms.GroupBox groupBoxAddEvent;
        private System.Windows.Forms.RadioButton radioButtonKlant;
        private System.Windows.Forms.RadioButton radioButtonDossierbeheerder;
        private System.Windows.Forms.Label labelDeadline;
        private System.Windows.Forms.Button buttonAddEvent;
        private System.Windows.Forms.TextBox textBoxOnderwerp;
        private System.Windows.Forms.Label labelOnderwerp;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeadline;
        private System.Windows.Forms.RadioButton radioButtonExtern;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem planningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toonOverzichtToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxTasks;
    }
}