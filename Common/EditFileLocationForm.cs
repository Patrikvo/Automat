/*  Notes:
 *
 * */

namespace Automat.Common
{
    using System;
    using System.Windows.Forms;

    public partial class EditFileLocationForm : Form
    {
        public EditFileLocationForm()
        {
            this.InitializeComponent();
        }

        public string FileLocation
        {
            get { return this.textBoxFileLocation.Text; }
            set { this.textBoxFileLocation.Text = value; }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            if (this.FileLocation != string.Empty)
            {
                if (System.IO.Directory.Exists(this.FileLocation))
                {
                    this.folderBrowserDialog1.SelectedPath = this.FileLocation;
                }
            }

            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.FileLocation = this.folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
