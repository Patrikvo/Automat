namespace Automat.Common
{
    using System;
    using System.Windows.Forms;
    using Automat.Controller;

    public partial class EventForm : Form
    {
        private int id = -1;

        public EventForm()
        {
            this.InitializeComponent();
        }

        public int DossierID { get; set; }

        public void SetDeadlineDate(DateTime date)
        {
            if (date != null)
            {
                this.dateTimePickerDeadline.Value = date;
            }
        }

        public bool ShowEvent(int id)
        {
            Controller.PlanningController planningController = new PlanningController(null);
            bool result = true;
            try
            {
                // edit Event with this ID.
                int dossierId;
                string description;
                int responsible;
                DateTime deadline;

                if (planningController.GetEvent(id, out dossierId, out description, out responsible, out deadline) == 1)
                {
                    this.textBoxOnderwerp.Text = description;
                    this.dateTimePickerDeadline.Value = deadline;

                    if (responsible == 1)
                    {
                        this.radioButtonDossierbeheerder.Checked = true;
                    }
                    else if (responsible == 2)
                    {
                        this.radioButtonKlant.Checked = true;
                    }
                    else if (responsible == 3)
                    {
                        this.radioButtonExtern.Checked = true;
                    }
                }
                else
                {
                    this.toolStripStatusLabel1.Text = "Taak lezen mislukt";
                    result = false;
                }

                this.id = id;
                this.DossierID = dossierId;
            }
            catch (InvalidCastException)
            {
                this.statusStrip1.Text = "Taak bewerken mislukt, id niet gevonden.";
                result = false;
            }

            this.buttonAddEvent.Text = "Bewaren";

            return result;
        }

        private bool StoreEvent()
        {
            Controller.PlanningController planningController = new PlanningController(null);
            int responsible = 1;
            if (this.radioButtonDossierbeheerder.Checked == true)
            {
                responsible = 1;
            }
            else if (this.radioButtonKlant.Checked == true)
            {
                responsible = 2;
            }
            else if (this.radioButtonExtern.Checked == true)
            {
                responsible = 3;
            }

            int result = 0;
            if (this.id >= 0)
            {
                // update
                result = planningController.UpdateEvent(this.id, this.DossierID, this.textBoxOnderwerp.Text, responsible, this.dateTimePickerDeadline.Value);
            }
            else
            {
                // new event
                result = planningController.AddEvent(this.DossierID, this.textBoxOnderwerp.Text, responsible, this.dateTimePickerDeadline.Value);
            }

            return result > 0;
        }

        private void ButtonEventCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ButtonAddEvent_Click(object sender, EventArgs e)
        {
            this.StoreEvent();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TextBoxOnderwerp_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxOnderwerp.Text.Length == 0)
            {
                this.buttonAddEvent.Enabled = false;
            }
            else
            {
                this.buttonAddEvent.Enabled = true;
            }
        }

        private void CheckBoxEventCompleted_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxEventCompleted.Checked == true)
            {
                this.dateTimePickerEventCompleted.Value = DateTime.Today;
                this.dateTimePickerEventCompleted.Visible = true;
            }
            else
            {
                this.dateTimePickerEventCompleted.Visible = false;
            }
        }
    }
}
