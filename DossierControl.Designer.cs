namespace Automat
{
    partial class DossierControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDossierNummer = new System.Windows.Forms.Label();
            this.textBoxStandvanzaken = new System.Windows.Forms.TextBox();
            this.buttonOpslaan = new System.Windows.Forms.Button();
            this.buttonOngedaanMaken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDossierNummer
            // 
            this.labelDossierNummer.AutoSize = true;
            this.labelDossierNummer.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDossierNummer.Location = new System.Drawing.Point(0, 0);
            this.labelDossierNummer.Name = "labelDossierNummer";
            this.labelDossierNummer.Size = new System.Drawing.Size(73, 13);
            this.labelDossierNummer.TabIndex = 1;
            this.labelDossierNummer.Text = "2018_001234";
            // 
            // textBoxStandvanzaken
            // 
            this.textBoxStandvanzaken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxStandvanzaken.Location = new System.Drawing.Point(3, 28);
            this.textBoxStandvanzaken.Multiline = true;
            this.textBoxStandvanzaken.Name = "textBoxStandvanzaken";
            this.textBoxStandvanzaken.Size = new System.Drawing.Size(671, 171);
            this.textBoxStandvanzaken.TabIndex = 3;
            // 
            // buttonOpslaan
            // 
            this.buttonOpslaan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpslaan.Enabled = false;
            this.buttonOpslaan.Location = new System.Drawing.Point(680, 28);
            this.buttonOpslaan.Name = "buttonOpslaan";
            this.buttonOpslaan.Size = new System.Drawing.Size(75, 23);
            this.buttonOpslaan.TabIndex = 4;
            this.buttonOpslaan.Text = "Opslaan";
            this.buttonOpslaan.UseVisualStyleBackColor = true;
            // 
            // buttonOngedaanMaken
            // 
            this.buttonOngedaanMaken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOngedaanMaken.Location = new System.Drawing.Point(680, 57);
            this.buttonOngedaanMaken.Name = "buttonOngedaanMaken";
            this.buttonOngedaanMaken.Size = new System.Drawing.Size(75, 23);
            this.buttonOngedaanMaken.TabIndex = 5;
            this.buttonOngedaanMaken.Text = "Ongedaan maken";
            this.buttonOngedaanMaken.UseVisualStyleBackColor = true;
            this.buttonOngedaanMaken.Click += new System.EventHandler(this.buttonOngedaanMaken_Click);
            // 
            // DossierControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonOngedaanMaken);
            this.Controls.Add(this.buttonOpslaan);
            this.Controls.Add(this.textBoxStandvanzaken);
            this.Controls.Add(this.labelDossierNummer);
            this.Name = "DossierControl";
            this.Size = new System.Drawing.Size(758, 207);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDossierNummer;
        private System.Windows.Forms.TextBox textBoxStandvanzaken;
        private System.Windows.Forms.Button buttonOpslaan;
        private System.Windows.Forms.Button buttonOngedaanMaken;
    }
}
