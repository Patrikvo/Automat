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
    public partial class PersonViewForm : Form
    {
        public PersonViewForm()
        {
            InitializeComponent();
            this.toolStripStatusLabel1.Text = "Ready";
        }


        public void setPersonList(object list, string displayMember, string valueMember)
        {
            
            this.listBoxPersons.DisplayMember = displayMember;
            this.listBoxPersons.ValueMember = valueMember;
            this.listBoxPersons.DataSource = list;
        }

        public void setPerson(int id, string name, string email, string organisation, string departement, byte[] rowVersion)
        {
            this.textBoxName.Text = name;
            this.textBoxEmail.Text = email;
            this.textBoxOrganisation.Text = organisation;
            this.textBoxDepartement.Text = departement;
            this.rowVersion = rowVersion;
            this.id = id;
        }

        private byte[] rowVersion;


        public SelectWithIdDelegate selectWithID;
        public SaveDelegate save;
        public SaveNewDelegate saveNew;
        public DeleteDelegate delete;

        public delegate void SelectWithIdDelegate(int id);
        public delegate int SaveDelegate(int id, string name, string email, string organisation, string departement, byte[] rowVersion);
        public delegate int SaveNewDelegate(out int id, string name, string email, string organisation, string departement);
        public delegate int DeleteDelegate(int id);
        



        private int id;





        private void listBoxPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)listBoxPersons.SelectedValue;
            selectWithID(id);
        }


        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            this.buttonSave.Enabled = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nieuwePersoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int result = saveNew(out id, "Geen Naam", "Geen email", "", "");
            if (result > 0)
            {
                this.toolStripStatusLabel1.Text = result.ToString() + " objects saved.";

                listBoxPersons.SelectedValue = this.id;
            }
            else
            {
                this.toolStripStatusLabel1.Text = "Adding person failed.";
            }
        }

        private void persoonWissenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = listBoxPersons.SelectedIndex;

            int result = delete(this.id);
            if (result > 0)
            {
                this.toolStripStatusLabel1.Text = result.ToString() + " person Deleted.";
            }
            else
            {
                this.toolStripStatusLabel1.Text = "deleting person failed.";
            }

            if (index > 0 && (index - 1) < listBoxPersons.Items.Count)
            {
                listBoxPersons.SelectedIndex = index - 1;
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            this.buttonSave.Enabled = true;
        }

        private void textBoxOrganisation_TextChanged(object sender, EventArgs e)
        {
            this.buttonSave.Enabled = true;
        }

        private void textBoxDepartement_TextChanged(object sender, EventArgs e)
        {
            this.buttonSave.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int index = listBoxPersons.SelectedIndex;

            int result = save(this.id, this.textBoxName.Text, this.textBoxEmail.Text, this.textBoxOrganisation.Text, this.textBoxDepartement.Text, this.rowVersion);
            this.toolStripStatusLabel1.Text = result.ToString() + " objects saved.";

            if (index < listBoxPersons.Items.Count && index >= 0)
            {
                listBoxPersons.SelectedIndex = index;
            }
        }
    }

}
