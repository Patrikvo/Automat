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
            this.toolStripStatusLabel1.Text = "Ready";


        }


        public bool isShowingArchivedItems() { return this.toonArchiefToolStripMenuItem.Checked; }

        public void setDossierList(object list, string displayMember, string valueMember)
        {
            this.listBoxDossiers.DisplayMember = displayMember;
            this.listBoxDossiers.ValueMember = valueMember;
            this.listBoxDossiers.DataSource = list;

        }

        public void setdossier(int id, string nummer, string titel, string stavaza, bool isArchived, string contactpersonen, byte[] rowVersion)
        {
            this.textBoxDossierNummer.Text = nummer;
            this.textBoxDossierTitel.Text = titel;
            this.textBoxStavaza.Text = stavaza;

            this.checkBoxIsArchived.Checked = isArchived;

            this.linkLabelContactpersonen.Text = contactpersonen;

            this.rowVersion = rowVersion;
            this.id = id;
        }

        private byte[] rowVersion;



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
        public ShowPersonForm showPersonForm;
        public exitAplicationDelegate exitApplication;
        public RefreshDossierListDelegate refreshDossierList;


        public delegate void SelectWithIdDelegate(int id);
        public delegate int SaveDossierDelegate(int id, string nummer, string titel, string stavaza, bool isArchived, byte[] rowVersion);
        public delegate int SaveNewDossierDelegate(out int id, string nummer, string titel, string stavaza);
        public delegate int DeleteDossierDelegate(int id, byte[] rowVersion);
        public delegate void RefreshDossierListDelegate(bool showArchived);


        public delegate void ShowPersonForm(int? id);
        public delegate void exitAplicationDelegate();

        public  void setStatusText(string statusText)
        {
            this.toolStripStatusLabel1.Text = statusText;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int index = listBoxDossiers.SelectedIndex;

            int result = saveDossier(this.id, this.textBoxDossierNummer.Text, this.textBoxDossierTitel.Text, this.textBoxStavaza.Text, this.checkBoxIsArchived.Checked, this.rowVersion);

            this.toolStripStatusLabel1.Text = result.ToString() + " objects saved.";

            setListboxDossiersIndex(index);
 

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

            int result = deleteDossier(this.id, this.rowVersion);
            if (result > 0)
            {
                this.toolStripStatusLabel1.Text = result.ToString() + " objects Deleted.";
            }
            else
            {
                this.toolStripStatusLabel1.Text = "deleting object failed.";
            }

            setListboxDossiersIndex(index-1);

        }

        private void overzichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPersonForm(null);
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitApplication();
        }

        private void OverviewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            exitApplication();
        }

        private void toonArchiefToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toonArchiefToolStripMenuItem.Checked = !toonArchiefToolStripMenuItem.Checked;
            refreshDossierList(toonArchiefToolStripMenuItem.Checked);
        }

        private void checkBoxIsArchived_CheckedChanged(object sender, EventArgs e)
        {


        }


        private void setListboxDossiersIndex(int index)
        {
            if (index < listBoxDossiers.Items.Count && index >= 0)
            {
                listBoxDossiers.SelectedIndex = index;
            }
            else
            {
                if (index < 0) { listBoxDossiers.SelectedIndex = 0; }
                else { listBoxDossiers.SelectedIndex = listBoxDossiers.Items.Count - 1; }
            }
        }

        private void linkLabelContactpersonen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showPersonForm(this.id);
        }
    }
}
