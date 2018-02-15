namespace Automat.View
{
    partial class PersonViewForm
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxOrganisation = new System.Windows.Forms.TextBox();
            this.textBoxDepartement = new System.Windows.Forms.TextBox();
            this.listBoxPersons = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelOrganisation = new System.Windows.Forms.Label();
            this.labelDepartement = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.persoonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nieuwePersoonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.persoonWissenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(13, 22);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(278, 20);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(13, 69);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(278, 20);
            this.textBoxEmail.TabIndex = 1;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxOrganisation
            // 
            this.textBoxOrganisation.Location = new System.Drawing.Point(13, 113);
            this.textBoxOrganisation.Name = "textBoxOrganisation";
            this.textBoxOrganisation.Size = new System.Drawing.Size(278, 20);
            this.textBoxOrganisation.TabIndex = 2;
            this.textBoxOrganisation.TextChanged += new System.EventHandler(this.textBoxOrganisation_TextChanged);
            // 
            // textBoxDepartement
            // 
            this.textBoxDepartement.Location = new System.Drawing.Point(13, 158);
            this.textBoxDepartement.Name = "textBoxDepartement";
            this.textBoxDepartement.Size = new System.Drawing.Size(278, 20);
            this.textBoxDepartement.TabIndex = 3;
            this.textBoxDepartement.TextChanged += new System.EventHandler(this.textBoxDepartement_TextChanged);
            // 
            // listBoxPersons
            // 
            this.listBoxPersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPersons.FormattingEnabled = true;
            this.listBoxPersons.Location = new System.Drawing.Point(0, 0);
            this.listBoxPersons.Name = "listBoxPersons";
            this.listBoxPersons.Size = new System.Drawing.Size(153, 292);
            this.listBoxPersons.TabIndex = 4;
            this.listBoxPersons.SelectedIndexChanged += new System.EventHandler(this.listBoxPersons_SelectedIndexChanged);
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
            this.splitContainer1.Panel1.Controls.Add(this.listBoxPersons);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonSave);
            this.splitContainer1.Panel2.Controls.Add(this.buttonClose);
            this.splitContainer1.Panel2.Controls.Add(this.labelDepartement);
            this.splitContainer1.Panel2.Controls.Add(this.labelOrganisation);
            this.splitContainer1.Panel2.Controls.Add(this.labelEmail);
            this.splitContainer1.Panel2.Controls.Add(this.labelName);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxOrganisation);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxName);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxDepartement);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxEmail);
            this.splitContainer1.Size = new System.Drawing.Size(460, 292);
            this.splitContainer1.SplitterDistance = 153;
            this.splitContainer1.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 322);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(460, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(10, 6);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Naam";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(10, 53);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email";
            // 
            // labelOrganisation
            // 
            this.labelOrganisation.AutoSize = true;
            this.labelOrganisation.Location = new System.Drawing.Point(10, 97);
            this.labelOrganisation.Name = "labelOrganisation";
            this.labelOrganisation.Size = new System.Drawing.Size(60, 13);
            this.labelOrganisation.TabIndex = 6;
            this.labelOrganisation.Text = "Organisatie";
            // 
            // labelDepartement
            // 
            this.labelDepartement.AutoSize = true;
            this.labelDepartement.Location = new System.Drawing.Point(10, 142);
            this.labelDepartement.Name = "labelDepartement";
            this.labelDepartement.Size = new System.Drawing.Size(68, 13);
            this.labelDepartement.TabIndex = 7;
            this.labelDepartement.Text = "Departement";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(135, 252);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Sluiten";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(216, 252);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Opslaan";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.persoonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(460, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // persoonToolStripMenuItem
            // 
            this.persoonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nieuwePersoonToolStripMenuItem,
            this.persoonWissenToolStripMenuItem});
            this.persoonToolStripMenuItem.Name = "persoonToolStripMenuItem";
            this.persoonToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.persoonToolStripMenuItem.Text = "Persoon";
            // 
            // nieuwePersoonToolStripMenuItem
            // 
            this.nieuwePersoonToolStripMenuItem.Name = "nieuwePersoonToolStripMenuItem";
            this.nieuwePersoonToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.nieuwePersoonToolStripMenuItem.Text = "Nieuwe Persoon";
            this.nieuwePersoonToolStripMenuItem.Click += new System.EventHandler(this.nieuwePersoonToolStripMenuItem_Click);
            // 
            // persoonWissenToolStripMenuItem
            // 
            this.persoonWissenToolStripMenuItem.Name = "persoonWissenToolStripMenuItem";
            this.persoonWissenToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.persoonWissenToolStripMenuItem.Text = "Persoon Wissen";
            this.persoonWissenToolStripMenuItem.Click += new System.EventHandler(this.persoonWissenToolStripMenuItem_Click);
            // 
            // PersonViewForm
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(460, 344);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "PersonViewForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Persoon";
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

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxOrganisation;
        private System.Windows.Forms.TextBox textBoxDepartement;
        private System.Windows.Forms.ListBox listBoxPersons;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelDepartement;
        private System.Windows.Forms.Label labelOrganisation;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem persoonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nieuwePersoonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem persoonWissenToolStripMenuItem;
    }
}