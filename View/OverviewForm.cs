using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        // listbox uses bindingSource to allow add/remove. 


        public OverviewForm()
        {
            InitializeComponent();
            this.toolStripStatusLabel1.Text = "Ready";
            binding1 = new BindingSource();



        }


        public bool isShowingArchivedItems() { return this.toonArchiefToolStripMenuItem.Checked; }

        public void setDossierList(object list, string displayMember, string valueMember)
        {
            this.listBoxDossiers.DisplayMember = displayMember;
            this.listBoxDossiers.ValueMember = valueMember;
            this.listBoxDossiers.DataSource = list;

        }

        public void setdossier(int id, string nummer, string titel, string stavaza, bool isArchived, List<Tuple<string, int>> contactpersonen, string linkTofiles , byte[] rowVersion)
        {
            this.textBoxDossierNummer.Text = nummer;
            this.textBoxDossierTitel.Text = titel;
            this.textBoxStavaza.Text = stavaza;
            if (linkTofiles != "")
            {
                this.linkLabelfiles.Text = linkTofiles;
            }
            else
            {
                this.linkLabelfiles.Text = "Niet opgegeven";
            }
            this.checkBoxIsArchived.Checked = isArchived;

            this.comboBoxContactpersonen.DataSource = null;
            linkedPersonList = new ObservableCollection<Tuple<string, int>>(contactpersonen);
            binding1.DataSource = linkedPersonList;
            this.comboBoxContactpersonen.DataSource = binding1;
            this.comboBoxContactpersonen.DisplayMember = "Item1";
            this.comboBoxContactpersonen.ValueMember = "Item2";

            personList = this.getAllPersons();
            this.listBoxAllPersons.DataSource = personList;
            this.listBoxAllPersons.DisplayMember = "Item1";
            this.listBoxAllPersons.ValueMember = "Item2";

            
            this.listBoxLinkedPersons.DataSource = binding1;
            this.listBoxLinkedPersons.DisplayMember = "Item1";
            this.listBoxLinkedPersons.ValueMember = "Item2";
            
            
            this.rowVersion = rowVersion;
            this.id = id;
        }

        private byte[] rowVersion;



        private void listBoxDossiers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // to prevent infinite recursion
            if (listboxDossiersSupressEvent) { return; } // Dossier is being saved, ignore this event.
            listboxDossiersSupressEvent = true;
       //     doSaveDossier();
            listboxDossiersSupressEvent = false;

            int id = (int)listBoxDossiers.SelectedValue;
            selectWithID(id);
        }
        bool listboxDossiersSupressEvent = false;


        private int id;

        public SelectWithIdDelegate selectWithID;
        public SaveDossierDelegate saveDossier;
        public SaveNewDossierDelegate saveNewDossier;
        public DeleteDossierDelegate deleteDossier;
        public ShowPersonForm showPersonForm;
        public exitAplicationDelegate exitApplication;
        public RefreshDossierListDelegate refreshDossierList;
        public GetAllPersonsDelegate getAllPersons;

        public delegate void SelectWithIdDelegate(int id);
        public delegate int SaveDossierDelegate(int id, string nummer, string titel, string stavaza, bool isArchived, string linkTofiles, byte[] rowVersion);
        public delegate int SaveNewDossierDelegate(out int id, string nummer, string titel, string stavaza);
        public delegate int DeleteDossierDelegate(int id, byte[] rowVersion);
        public delegate void RefreshDossierListDelegate(bool showArchived);
        public delegate List<Tuple<string, int>> GetAllPersonsDelegate();
 
        public delegate void ShowPersonForm(int? id);
        public delegate void exitAplicationDelegate();

        public  void setStatusText(string statusText)
        {
            this.toolStripStatusLabel1.Text = statusText;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            doSaveDossier();

        }

        private void doSaveDossier()
        {
            int index = listBoxDossiers.SelectedIndex;

            int result = saveDossier(this.id, this.textBoxDossierNummer.Text, this.textBoxDossierTitel.Text, this.textBoxStavaza.Text, this.checkBoxIsArchived.Checked, this.linkLabelfiles.Text, this.rowVersion);

            this.toolStripStatusLabel1.Text = result.ToString() + " objects saved.";

            setListboxDossiersIndex(index);
        }

        private void nieuwDossierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listboxDossiersSupressEvent = true;
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

        private void linkLabelfiles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {


                if (System.IO.Directory.Exists(this.linkLabelfiles.Text))
                {
                    System.Diagnostics.Process.Start(this.linkLabelfiles.Text);
                    //System.Diagnostics.Process.Start(@"C:\temp");
                }
                else
                {
                    MessageBox.Show("De map " + this.linkLabelfiles.Text + " bestaat niet.", "Map niet gevonden.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void contextMenuStripFiles_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "toolStripMenuItemEdit")
            {
                Automat.Common.EditFileLocationForm editForm = new Common.EditFileLocationForm();
                editForm.fileLocation = this.linkLabelfiles.Text;
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    this.linkLabelfiles.Text = editForm.fileLocation;
                }
            }
        }

        


        private List<Tuple<string, int>> personList;
        private ObservableCollection<Tuple<string, int>> linkedPersonList;
        private BindingSource binding1;

        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            if (listBoxAllPersons.SelectedItem != null)
            {
                Tuple<string, int> selectedPerson = (Tuple<string, int>)listBoxAllPersons.SelectedItem;
                if (!linkedPersonList.Contains(selectedPerson))
                {
                    binding1.Add(selectedPerson);
                }
            }
        }

        private void buttonRemovePerson_Click(object sender, EventArgs e)
        {
            Tuple<string, int> selectedPerson = (Tuple<string, int>)listBoxLinkedPersons.SelectedItem;
            if (linkedPersonList.Contains(selectedPerson))
            {
                binding1.Remove(selectedPerson);
            }
        }


        private void buttonSaveP2_Click(object sender, EventArgs e)
        {
            // TODO sychornise linkedPersonList with DB. 
            // some items are already in DB, some have been removed, some are new.






        }


    } 
}
