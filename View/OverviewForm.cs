using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automat.View
{
    public partial class OverviewForm : Form
    {
        public OverviewForm()
        {
            InitializeComponent();

            

        }

        public void setDossierList(object list, string displayMember, string valueMember)
        {
            this.listBoxDossiers.DataSource = list;
            this.listBoxDossiers.DisplayMember = displayMember;
            this.listBoxDossiers.ValueMember = valueMember;
        }

        public void setdossier(int id, string nummer, string titel, string stavaza)
        {
            this.textBoxDossierNummer.Text = nummer;
            this.textBoxDossierTitel.Text = titel;
            this.textBoxStavaza.Text = stavaza;
            this.id = id;
        }

        private void listBoxDossiers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)listBoxDossiers.SelectedValue;
            selectWithID(id);
        }



        private int id;

        public SelectWithIdDelegate selectWithID;
        public SaveDossierDelegate saveDossier;
        public SaveNewDossierDelegate saveNewDossier;
        public DeleteDossierDelegate deleteDossier;

        public delegate void SelectWithIdDelegate(int id);
        public delegate int SaveDossierDelegate(int id, string nummer, string titel, string stavaza);
        public delegate int SaveNewDossierDelegate(out int id, string nummer, string titel, string stavaza);
        public delegate int DeleteDossierDelegate(int id);


        private void buttonSave_Click(object sender, EventArgs e)
        {
            int index = listBoxDossiers.SelectedIndex;

            int result = saveDossier(this.id, this.textBoxDossierNummer.Text, this.textBoxDossierTitel.Text, this.textBoxStavaza.Text);
            this.toolStripStatusLabel1.Text = result.ToString() + " objects saved.";

            if (index < listBoxDossiers.Items.Count && index >= 0)
            {
                listBoxDossiers.SelectedIndex = index;
            }

        }

        private void nieuwDossierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int result = saveNewDossier(out this.id, "Geen nummer", "Geen titel", "");
            if (result > 0)
            {
                this.toolStripStatusLabel1.Text = result.ToString() + " objects saved.";

                listBoxDossiers.SelectedValue = this.id;
            }
            else
            {
                this.toolStripStatusLabel1.Text = "Adding object failed.";
            }
        }

        private void dossierWissenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = listBoxDossiers.SelectedIndex;

            int result = deleteDossier(this.id);
            if (result > 0)
            {
                this.toolStripStatusLabel1.Text = result.ToString() + " objects Deleted.";
            }
            else
            {
                this.toolStripStatusLabel1.Text = "deleting object failed.";
            }

            if (index > 0 && (index -1) < listBoxDossiers.Items.Count)
            {
                listBoxDossiers.SelectedIndex = index -1 ; 
            }

        }
    }
}
