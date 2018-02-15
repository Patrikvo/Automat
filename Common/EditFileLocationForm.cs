using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automat.Common
{
    public partial class EditFileLocationForm : Form
    {
        public EditFileLocationForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (fileLocation != "")
            {
                if (System.IO.Directory.Exists(fileLocation))
                {
                    this.folderBrowserDialog1.SelectedPath = fileLocation;
                }
            }

            DialogResult result =  this.folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileLocation = this.folderBrowserDialog1.SelectedPath;
            }

        }


        


        public string fileLocation
        {
            get { return textBoxFileLocation.Text; }
            set { textBoxFileLocation.Text = value; }
        }



    }
}
