/*  Notes:
 *
 * */

namespace Automat.View
{
    using System;
    using System.Windows.Forms;

    public partial class PersonViewForm : Form
    {
        private SelectWithIdDelegate selectWithID;

        private SaveDelegate save;

        private SaveNewDelegate saveNew;

        private DeleteDelegate delete;

        private byte[] rowVersion;

        private int id;

        public PersonViewForm()
        {
            this.InitializeComponent();
            this.toolStripStatusLabel1.Text = "Ready";
        }

        public delegate void SelectWithIdDelegate(int id);

        public delegate int SaveDelegate(int id, string name, string email, string organisation, string departement, byte[] rowVersion);

        public delegate int SaveNewDelegate(out int id, string name, string email, string organisation, string departement);

        public delegate int DeleteDelegate(int id);

        public SelectWithIdDelegate SelectWithID { get => this.selectWithID; set => this.selectWithID = value; }

        public SaveDelegate Save { get => this.save; set => this.save = value; }

        public SaveNewDelegate SaveNew { get => this.saveNew; set => this.saveNew = value; }

        public DeleteDelegate Delete { get => this.delete; set => this.delete = value; }

        public byte[] RowVersion { get => this.rowVersion; set => this.rowVersion = value; }

        public void SetPersonList(object list, string displayMember, string valueMember)
        {
            this.listBoxPersons.DisplayMember = displayMember;
            this.listBoxPersons.ValueMember = valueMember;
            this.listBoxPersons.DataSource = list;
        }

        public void SetPerson(int id, string name, string email, string organisation, string departement, byte[] rowVersion)
        {
            this.textBoxName.Text = name;
            this.textBoxEmail.Text = email;
            this.textBoxOrganisation.Text = organisation;
            this.textBoxDepartement.Text = departement;
            this.RowVersion = rowVersion;
            this.id = id;
        }

        private void ListBoxPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)this.listBoxPersons.SelectedValue;
            this.SelectWithID(id);
        }

        private void LabelName_Click(object sender, EventArgs e)
        {
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            this.buttonSave.Enabled = true;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NieuwePersoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Persoon wissen?", "Persoon verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                int result = this.SaveNew(out this.id, "Geen Naam", "Geen email", string.Empty, string.Empty);
                if (result > 0)
                {
                    this.toolStripStatusLabel1.Text = result.ToString() + " objects saved.";

                    this.listBoxPersons.SelectedValue = this.id;
                }
                else
                {
                    this.toolStripStatusLabel1.Text = "Adding person failed.";
                }
            }
            else
            {
                this.toolStripStatusLabel1.Text = "Verwijderen geannulleerd";
            }
        }

        private void PersoonWissenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = this.listBoxPersons.SelectedIndex;

            int result = this.Delete(this.id);
            if (result > 0)
            {
                this.toolStripStatusLabel1.Text = result.ToString() + " person Deleted.";
            }
            else
            {
                this.toolStripStatusLabel1.Text = "deleting person failed.";
            }

            if (index > 0 && (index - 1) < this.listBoxPersons.Items.Count)
            {
                this.listBoxPersons.SelectedIndex = index - 1;
            }
        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            this.buttonSave.Enabled = true;
        }

        private void TextBoxOrganisation_TextChanged(object sender, EventArgs e)
        {
            this.buttonSave.Enabled = true;
        }

        private void TextBoxDepartement_TextChanged(object sender, EventArgs e)
        {
            this.buttonSave.Enabled = true;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            int index = this.listBoxPersons.SelectedIndex;

            int result = this.Save(this.id, this.textBoxName.Text, this.textBoxEmail.Text, this.textBoxOrganisation.Text, this.textBoxDepartement.Text, this.RowVersion);
            this.toolStripStatusLabel1.Text = result.ToString() + " objects saved.";

            if (index < this.listBoxPersons.Items.Count && index >= 0)
            {
                this.listBoxPersons.SelectedIndex = index;
            }
        }
    }
}
