/*  Notes:
 *  - listbox uses bindingSource to allow add/remove.
 * */

namespace Automat.View
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Windows.Forms;

    public partial class OverviewForm : Form
    {
        /* Common Public Members
         *  Contains all the methodes, controls and members not contained in the tabcontrol.
         * */

        /* COMMON FIELDS */

        private SaveNewDossierDelegate saveNewDossier;

        private DeleteDossierDelegate deleteDossier;

        private ShowPersonForm showPersonFormValue;

        private ExitAplicationDelegate exitApplication;

        private RefreshDossierListDelegate refreshDossierList;

        private GetAllPersonsDelegate getAllPersons;

        private BindingSource binding1;

        private List<Tuple<string, int>> contactpersonen;

        /* TAPPAGE 1 FIELDS */

        private SelectWithIdDelegate selectWithID;

        private SaveDossierDelegate saveDossier;

        private bool listboxDossiersSupressEvent = false;

        private byte[] rowVersion;

        private int id;

        /* TAPPAGE 2 FIELDS */

        private PersistLinkedPersonListDelegate persistLinkedPersonList;

        private List<Tuple<string, int>> personList;

        private ObservableCollection<Tuple<string, int>> linkedPersonList;

        /* COMMON CONSTRUCTOR */

        public OverviewForm()
        {
            this.InitializeComponent();
            this.toolStripStatusLabel1.Text = "Ready";
            this.binding1 = new BindingSource();
        }

        /* COMMON DELEGATES */

        public delegate int SaveNewDossierDelegate(out int id, string nummer, string titel, string stavaza);

        public delegate int DeleteDossierDelegate(int id, byte[] rowVersion);

        public delegate void ShowPersonForm(int? id);

        public delegate void ExitAplicationDelegate();

        public delegate void RefreshDossierListDelegate(bool showArchived);

        public delegate List<Tuple<string, int>> GetAllPersonsDelegate();

        /* TAPPAGE 1 DELEGATES */

        public delegate void SelectWithIdDelegate(int id);

        public delegate int SaveDossierDelegate(int id, string nummer, string titel, string stavaza, bool isArchived, string linkTofiles, byte[] rowVersion);

        /* TAPPAGE 2 DELEGATES */

        public delegate int PersistLinkedPersonListDelegate(int dossierId, List<Tuple<string, int>> linkedPersons);

        /* COMMON PROPERTIES */

        public SaveNewDossierDelegate SaveNewDossier { get => this.saveNewDossier; set => this.saveNewDossier = value; }

        public DeleteDossierDelegate DeleteDossier { get => this.deleteDossier; set => this.deleteDossier = value; }

        public ShowPersonForm ShowPersonFormValue { get => this.showPersonFormValue; set => this.showPersonFormValue = value; }

        public ExitAplicationDelegate ExitApplication { get => this.exitApplication; set => this.exitApplication = value; }

        public RefreshDossierListDelegate RefreshDossierList { get => this.refreshDossierList; set => this.refreshDossierList = value; }

        public GetAllPersonsDelegate GetAllPersons { get => this.getAllPersons; set => this.getAllPersons = value; }

        /* TAPPAGE 1 PROPERTIES */

        public SelectWithIdDelegate SelectWithID { get => this.selectWithID; set => this.selectWithID = value; }

        public SaveDossierDelegate SaveDossier { get => this.saveDossier; set => this.saveDossier = value; }

        /* TAPPAGE 2 PROPERTIES */

        public PersistLinkedPersonListDelegate PersistLinkedPersonList { get => this.persistLinkedPersonList; set => this.persistLinkedPersonList = value; }

        /* COMMON PUBLIC METHODES */

        public void Setdossier(int id, string nummer, string titel, string stavaza, bool isArchived, List<Tuple<string, int>> contactpersonen, string linkTofiles, byte[] rowVersion)
        {
            this.contactpersonen = contactpersonen;
            this.textBoxDossierNummer.Text = nummer;
            this.textBoxDossierTitel.Text = titel;
            this.textBoxStavaza.Text = stavaza;
            if (linkTofiles != string.Empty)
            {
                this.linkLabelfiles.Text = linkTofiles;
            }
            else
            {
                this.linkLabelfiles.Text = "Niet opgegeven";
            }

            this.checkBoxIsArchived.Checked = isArchived;

            this.comboBoxContactpersonen.DataSource = null;
            this.linkedPersonList = new ObservableCollection<Tuple<string, int>>(contactpersonen);
            this.binding1.DataSource = this.linkedPersonList;
            this.comboBoxContactpersonen.DataSource = this.binding1;
            this.comboBoxContactpersonen.DisplayMember = "Item1";
            this.comboBoxContactpersonen.ValueMember = "Item2";

            this.personList = this.GetAllPersons();
            this.listBoxAllPersons.DataSource = this.personList;
            this.listBoxAllPersons.DisplayMember = "Item1";
            this.listBoxAllPersons.ValueMember = "Item2";

            this.listBoxLinkedPersons.DataSource = this.binding1;
            this.listBoxLinkedPersons.DisplayMember = "Item1";
            this.listBoxLinkedPersons.ValueMember = "Item2";

            this.rowVersion = rowVersion;
            this.id = id;
        }

        public void SetStatusText(string statusText)
        {
            this.toolStripStatusLabel1.Text = statusText;
        }

        public bool IsShowingArchivedItems()
        {
            return this.toonArchiefToolStripMenuItem.Checked;
        }

        public void SetDossierList(object list, string displayMember, string valueMember)
        {
            this.listBoxDossiers.DisplayMember = displayMember;
            this.listBoxDossiers.ValueMember = valueMember;
            this.listBoxDossiers.DataSource = list;
        }

        /* TAPPAGE 2 PUBLIC METHODES */

        /* COMMON PRIVATE METHODES */

        private void NieuwDossierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int result = this.SaveNewDossier(out this.id, "Geen nummer", "Geen titel", string.Empty);
            if (result > 0)
            {
                this.toolStripStatusLabel1.Text = result.ToString() + " objects saved.";

                this.listBoxDossiers.SelectedValue = this.id;
            }
            else
            {
                this.toolStripStatusLabel1.Text = "Adding object failed.";
            }
        }

        private void DossierWissenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = this.listBoxDossiers.SelectedIndex;

            int result = this.DeleteDossier(this.id, this.rowVersion);
            if (result > 0)
            {
                this.toolStripStatusLabel1.Text = result.ToString() + " objects Deleted.";
            }
            else
            {
                this.toolStripStatusLabel1.Text = "deleting object failed.";
            }

            this.SetListboxDossiersIndex(index - 1);
        }

        private void OverzichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowPersonFormValue(null);
        }

        private void AfsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OverviewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.ExitApplication();
        }

        private void ToonArchiefToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.toonArchiefToolStripMenuItem.Checked = !this.toonArchiefToolStripMenuItem.Checked;
            this.RefreshDossierList(this.toonArchiefToolStripMenuItem.Checked);
        }

        /* TAPPAGE 1 PRIVATE METHODES */

        private void ListBoxDossiers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: issue: saving when changing selected dossier.

            // to prevent infinite recursion
            if (this.listboxDossiersSupressEvent)
            {
                return;
            }

            // Dossier is being saved, ignore this event.
            this.listboxDossiersSupressEvent = true;

            // doSaveDossier();
            this.listboxDossiersSupressEvent = false;

            int id = (int)this.listBoxDossiers.SelectedValue;
            this.SelectWithID(id);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            this.DoSaveDossier();
        }

        private void DoSaveDossier()
        {
            int id = (int)this.listBoxDossiers.SelectedValue;

            int result = this.SaveDossier(this.id, this.textBoxDossierNummer.Text, this.textBoxDossierTitel.Text, this.textBoxStavaza.Text, this.checkBoxIsArchived.Checked, this.linkLabelfiles.Text, this.rowVersion);

            this.toolStripStatusLabel1.Text = result.ToString() + " objects saved.";
            this.SetListboxDossiersById(id);
        }

        private void SetListboxDossiersById(int id)
        {
            foreach (Model.Dossier d in this.listBoxDossiers.Items)
            {
                if (d.Id == id)
                {
                    this.listBoxDossiers.SelectedIndex = this.listBoxDossiers.Items.IndexOf(d);
                    break;
                }
            }
        }

        private void CheckBoxIsArchived_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void SetListboxDossiersIndex(int index)
        {
            if (index < this.listBoxDossiers.Items.Count && index >= 0)
            {
                this.listBoxDossiers.SelectedIndex = index;
            }
            else
            {
                if (index < 0)
                {
                    this.listBoxDossiers.SelectedIndex = 0;
                }
                else
                {
                    this.listBoxDossiers.SelectedIndex = this.listBoxDossiers.Items.Count - 1;
                }
            }
        }

        private void LinkLabelContactpersonen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ShowPersonFormValue(this.id);
        }

        private void LinkLabelfiles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (System.IO.Directory.Exists(this.linkLabelfiles.Text))
                {
                    System.Diagnostics.Process.Start(this.linkLabelfiles.Text);

                    // System.Diagnostics.Process.Start(@"C:\temp");
                }
                else
                {
                    MessageBox.Show("De map " + this.linkLabelfiles.Text + " bestaat niet.", "Map niet gevonden.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ContextMenuStripFiles_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "toolStripMenuItemEdit")
            {
                Automat.Common.EditFileLocationForm editForm = new Common.EditFileLocationForm();
                editForm.FileLocation = this.linkLabelfiles.Text;
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    this.linkLabelfiles.Text = editForm.FileLocation;
                }
            }
        }

        /* TAPPAGE 2 PRIVATE METHODES */

        private void ButtonAddPerson_Click(object sender, EventArgs e)
        {
            if (this.listBoxAllPersons.SelectedItem != null)
            {
                Tuple<string, int> selectedPerson = (Tuple<string, int>)this.listBoxAllPersons.SelectedItem;
                if (!this.linkedPersonList.Contains(selectedPerson))
                {
                    this.binding1.Add(selectedPerson);
                }
            }
        }

        private void ButtonRemovePerson_Click(object sender, EventArgs e)
        {
            Tuple<string, int> selectedPerson = (Tuple<string, int>)this.listBoxLinkedPersons.SelectedItem;
            if (this.linkedPersonList.Contains(selectedPerson))
            {
                this.binding1.Remove(selectedPerson);
            }
        }

        private void ButtonSaveP2_Click(object sender, EventArgs e)
        {
            // some items are already in DB, some have been removed, some are new.
            int modifiedObjectsCount = this.PersistLinkedPersonList(this.id, this.linkedPersonList.ToList());

            this.toolStripStatusLabel1.Text = modifiedObjectsCount.ToString() + " persons modified.";
        }
    }
}
