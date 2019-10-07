﻿/*  Notes:
 *  - listbox uses bindingSource to allow add/remove.
 * */

namespace Automat.View
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Windows.Forms;
    using Automat.Common;
    using Automat.Controller;
    using Automat.View.Overview;

    public partial class OverviewForm : Form
    {
        /* Common Public Members
         *  Contains all the methodes, controls and members not contained in the tabcontrol.
         * */

        /* COMMON FIELDS */

        private OverviewController overviewController;

        private BindingSource binding1;
        private BindingSource bindingEvents;

        private List<Tuple<string, int>> contactpersonen;

        private Overview.PlanningSubForm planningSubForm;

        /* TAPPAGE 1 FIELDS */

        private bool listboxDossiersSupressEvent = false;

        private byte[] rowVersion;

        private int id;

        private bool suppressSave = false;

        /* TAPPAGE 2 FIELDS */

        private List<Tuple<string, int>> personList;

        private ObservableCollection<Tuple<string, int>> linkedPersonList;

        /* COMMON CONSTRUCTOR */

        public OverviewForm(OverviewController overviewController, PlanningSubForm planningSubForm)
        {
            this.overviewController = overviewController;
            this.InitializeComponent();
            this.toolStripStatusLabel1.Text = "Ready";
            this.binding1 = new BindingSource();
            this.bindingEvents = new BindingSource();

            planningSubForm.TopLevel = false;
            planningSubForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(planningSubForm);
            planningSubForm.Show();
            this.planningSubForm = planningSubForm;
        }

        /* COMMON PROPERTIES */

        /* TAPPAGE 1 PROPERTIES */

        /* TAPPAGE 2 PROPERTIES */

        /* COMMON PUBLIC METHODES */

        public void Setdossier(
                                int id,
                                string nummer,
                                string titel,
                                string stavaza,
                                bool isArchived,
                                List<Tuple<string, int>> contactpersonen,
                                string linkTofiles,
                                string procedure,
                                string type,
                                bool isEuropeanPublished,
                                string procuringEntityName,
                                string contractTypeName,
                                List<Tripple<string, DateTime, int>> events,
                                byte[] rowVersion)
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

            this.personList = this.overviewController.GetAllPersons();
            this.listBoxAllPersons.DataSource = this.personList;
            this.listBoxAllPersons.DisplayMember = "Item1";
            this.listBoxAllPersons.ValueMember = "Item2";

            this.listBoxLinkedPersons.DataSource = this.binding1;
            this.listBoxLinkedPersons.DisplayMember = "Item1";
            this.listBoxLinkedPersons.ValueMember = "Item2";

            this.comboBoxProcedure.DataSource = this.overviewController.GetAllProcedures();
            this.comboBoxProcedure.SelectedIndex = this.comboBoxProcedure.Items.IndexOf(procedure);

            this.comboBoxType.DataSource = Rules.DossierRules.GetProcedureTypeNames(true);
            this.comboBoxType.SelectedIndex = this.comboBoxType.Items.IndexOf(type);

            this.checkBoxIsEuropeanPublished.Checked = isEuropeanPublished;

            this.comboBoxProcuringEntity.DataSource = Rules.DossierRules.GetProcuringEntityNames();
            this.comboBoxProcuringEntity.SelectedIndex = this.comboBoxProcuringEntity.Items.IndexOf(procuringEntityName);

            this.comboBoxTypeOfContract.DataSource = Rules.DossierRules.GetContractTypes();
            this.comboBoxTypeOfContract.SelectedIndex = this.comboBoxTypeOfContract.Items.IndexOf(contractTypeName);
            this.DisplayEvents(events);

            this.planningSubForm.DisplayEvents(events);

            this.rowVersion = rowVersion;
            this.id = id;
        }

        public void DisplayEvents(List<Tripple<string, DateTime, int>> events)
        {
            this.planningSubForm.DisplayEvents(events);
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
            this.suppressSave = true;
            this.listBoxDossiers.DisplayMember = displayMember;
            this.listBoxDossiers.ValueMember = valueMember;
            this.listBoxDossiers.DataSource = list;
            this.suppressSave = false;
        }

        /* TAPPAGE 2 PUBLIC METHODES */

        /* COMMON PRIVATE METHODES */

        private void NieuwDossierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listboxDossiersSupressEvent = true;
            int result = this.overviewController.SaveNewDossier(out this.id, "Geen nummer", "Geen titel", string.Empty);
            this.listboxDossiersSupressEvent = false;
            if (result > 0)
            {
                this.toolStripStatusLabel1.Text = result.ToString() + " objects saved.";

                this.suppressSave = true;
                this.listBoxDossiers.SelectedValue = this.id;
                this.suppressSave = false;
            }
            else
            {
                this.toolStripStatusLabel1.Text = "Adding object failed.";
            }
        }

        private void DossierWissenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Dossier wissen?", "Dossier verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                this.suppressSave = true;
                int index = this.listBoxDossiers.SelectedIndex;

                int result = this.overviewController.DeleteDossier(this.id, this.rowVersion);
                if (result > 0)
                {
                    this.toolStripStatusLabel1.Text = result.ToString() + " objects Deleted.";
                }
                else
                {
                    this.toolStripStatusLabel1.Text = "deleting object failed.";
                }

                this.SetListboxDossiersIndex(index - 1);
                this.suppressSave = false;
            }
            else
            {
                this.toolStripStatusLabel1.Text = "Verwijderen geannulleerd";
            }
        }

        private void OverzichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.overviewController.ShowPersonForm(null);
        }

        private void AfsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OverviewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.overviewController.ExitApplication();
        }

        private void ToonArchiefToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.toonArchiefToolStripMenuItem.Checked = !this.toonArchiefToolStripMenuItem.Checked;
            this.overviewController.RefreshDossierList(this.toonArchiefToolStripMenuItem.Checked);
        }

        /* TAPPAGE 1 PRIVATE METHODES */

        private void ListBoxDossiers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // to prevent infinite recursion
            if (this.listboxDossiersSupressEvent)
            {
                return;
            }

            // Dossier is being saved, ignore this event.
            this.listboxDossiersSupressEvent = true;

            if (!this.suppressSave)
            {
                this.DoSaveDossier();
            }

            this.listboxDossiersSupressEvent = false;

            int id = (int)this.listBoxDossiers.SelectedValue;
            this.overviewController.ShowWithID(id);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            this.DoSaveDossier();
        }

        private void DoSaveDossier()
        {
            int id = -1;
            if (this.listBoxDossiers.SelectedValue != null)
            {
                id = (int)this.listBoxDossiers.SelectedValue;
            }

            int result = this.overviewController.SaveDossier(
                                                                this.id,
                                                                this.textBoxDossierNummer.Text,
                                                                this.textBoxDossierTitel.Text,
                                                                this.textBoxStavaza.Text,
                                                                this.checkBoxIsArchived.Checked,
                                                                this.linkLabelfiles.Text,
                                                                (string)this.comboBoxProcedure.SelectedItem,
                                                                (string)this.comboBoxType.SelectedItem,
                                                                this.checkBoxIsEuropeanPublished.Checked,
                                                                (string)this.comboBoxProcuringEntity.SelectedItem,
                                                                (string)this.comboBoxTypeOfContract.SelectedItem,
                                                                this.rowVersion);

            this.toolStripStatusLabel1.Text = result.ToString() + " objects saved.";
            if (this.listBoxDossiers.SelectedValue != null)
            {
                this.SetListboxDossiersById(id);
            }
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
            this.overviewController.ShowPersonForm(this.id);
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
            int modifiedObjectsCount = this.overviewController.PersistLinkedPersonList(this.id, this.linkedPersonList.ToList());

            this.toolStripStatusLabel1.Text = modifiedObjectsCount.ToString() + " persons modified.";
        }

        private void TextBoxStavaza_TextChanged(object sender, EventArgs e)
        {
        }

        private void ToonOverzichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.overviewController.ShowPlanningForm();
        }
    }
}
