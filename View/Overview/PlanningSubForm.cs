namespace Automat.View.Overview
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Automat.Common;
    using Automat.Controller;

    public partial class PlanningSubForm : Form
    {
        public PlanningSubForm(OverviewController overviewController)
        {
            this.OverviewController = overviewController;
            this.InitializeComponent();
        }

        public OverviewController OverviewController { get; set; }

        public void DisplayEvents(List<Tripple<string, DateTime, int>> events)
        {
            Controller.PlanningController planningController = new PlanningController(null);
            // Fill Treeview
            this.treeViewEvents.SuspendLayout();
            this.treeViewEvents.Nodes.Clear();
            foreach (Tripple<string, DateTime, int> e in events)
            {
                TreeNode t;

                // find date node
                // string key = e.Item2.Year.ToString() + e.Item2.Month.ToString() + e.Item2.Day.ToString();
                string key = this.CreateDateNodeKey(e.Item2);

                // 'key' matches 'Name'-field in Node.
                if (this.treeViewEvents.Nodes.ContainsKey(key))
                {
                    t = this.treeViewEvents.Nodes[this.treeViewEvents.Nodes.IndexOfKey(key)];
                }
                else
                {
                    // add new date node
                    t = new TreeNode();
                    t.Name = key;
                    t.Text = e.Item2.ToShortDateString();
                    t.Tag = null;
                    t.ImageIndex = 1;
                    this.treeViewEvents.Nodes.Add(t);
                }

                int dossierId;
                string description;
                int responsible;
                DateTime deadline;
                DateTime? completetionDate;
                DateTime creationDate;

                if (planningController.GetEvent(e.Item3, out dossierId, out description, out responsible, out deadline, out completetionDate, out creationDate) == 1)
                {
                    TreeNode newEvent = new TreeNode();
                    newEvent.Name = e.Item3.ToString();
                    newEvent.Text = e.Item1;
                    newEvent.Tag = e.Item3;

                    if (completetionDate != null)
                    {
                        newEvent.ImageIndex = 2; // is done
                    }
                    else
                    {
                        if (deadline.Date.CompareTo(DateTime.Now.Date) < 0 )
                        {
                            newEvent.ImageIndex = 3; // late
                        }
                        else
                        {
                            newEvent.ImageIndex = 6;
                        }
                    }

                    t.Nodes.Add(newEvent);
                }
            }

            this.treeViewEvents.ExpandAll();

            this.treeViewEvents.ResumeLayout();

            this.monthCalendarTasks.RemoveAllBoldedDates();
            foreach (Tripple<string, DateTime, int> t in events)
            {
                this.monthCalendarTasks.AddBoldedDate(t.Item2);
            }

            this.monthCalendarTasks.UpdateBoldedDates();
        }

        private void Feedback(string feedback)
        {
            // TODO implement
        }

        private void ToolStripMenuItemAddEvent_Click_1(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;

            if (this.treeViewEvents.SelectedNode != null && this.treeViewEvents.SelectedNode.Tag == null)
            {
                // a date node is selected
                try
                {
                    string key = (string)this.treeViewEvents.SelectedNode.Text;
                    date = DateTime.Parse(key);
                }
                catch (InvalidCastException)
                {
                    this.Feedback("Taak toevoegen mislukt, ongeldige datum-node.");
                    return;
                }
            }

            if (this.OverviewController.ShowEventAddForm(date) == true)
            {
                this.Feedback("Taak Toegevoegd");
            }
            else
            {
                this.Feedback("Taak toevoegen geannulleerd.");
            }
        }

        private void ToolStripMenuItemRemove_Click_1(object sender, EventArgs e)
        {
            if (string.Equals(this.contextMenuStripEvents.SourceControl.Name, this.treeViewEvents.Name) == true)
            {
                if (this.treeViewEvents.SelectedNode.Tag != null)
                {
                    try
                    {
                        int id = (int)this.treeViewEvents.SelectedNode.Tag;

                        // remove Event with this ID.
                        int result = this.OverviewController.RemoveEvent(id, this.OverviewController.DossierId);
                        if (result == 1)
                        {
                            this.Feedback("Taak verwijderd");
                        }
                        else
                        {
                            this.Feedback("Taak verwijderen mislukt");
                        }
                    }
                    catch (InvalidCastException)
                    {
                        this.Feedback("Taak verwijderen mislukt, id niet gevonden.");
                    }
                }
            }
        }

        private void ToolStripMenuItemBewerken_Click_1(object sender, EventArgs e)
        {
            if (string.Equals(this.contextMenuStripEvents.SourceControl.Name, this.treeViewEvents.Name) == true)
            {
                if (this.treeViewEvents.SelectedNode.Tag != null)
                {
                    try
                    {
                        int id = (int)this.treeViewEvents.SelectedNode.Tag;

                        if (this.OverviewController.ShowEventUpdateForm(id) == true)
                        {
                            this.Feedback("Taak bewaart");
                        }
                        else
                        {
                            this.Feedback("Taak bewerken geannulleerd.");
                        }
                    }
                    catch (InvalidCastException)
                    {
                        this.Feedback("Taak bewerken mislukt, id niet gevonden.");
                    }
                }
            }
        }

        private void ContextMenuStripEvents_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.Equals(this.contextMenuStripEvents.SourceControl.Name, this.treeViewEvents.Name) == true)
            {
                this.toolStripMenuItemAddEvent.Visible = false;
                this.toolStripMenuItemBewerken.Visible = false;
                this.toolStripMenuItemRemove.Visible = false;

                if (this.treeViewEvents.SelectedNode != null && this.treeViewEvents.SelectedNode.Tag != null)
                {
                    // is Event node
                    this.toolStripMenuItemAddEvent.Visible = false;
                    this.toolStripMenuItemBewerken.Visible = true;
                    this.toolStripMenuItemRemove.Visible = true;
                }
                else
                {
                    // is date node or no node selected
                    this.toolStripMenuItemAddEvent.Visible = true;
                    this.toolStripMenuItemBewerken.Visible = false;
                    this.toolStripMenuItemRemove.Visible = false;
                }
            }
        }

        private string CreateDateNodeKey(DateTime date)
        {
            return date.Year.ToString() + date.Month.ToString() + date.Day.ToString();
        }

        private void MonthCalendarTasks_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (this.monthCalendarTasks.SelectionStart != null)
            {
                string key = this.CreateDateNodeKey(this.monthCalendarTasks.SelectionStart);

                // 'key' matches 'Name'-field in Node.
                if (this.treeViewEvents.Nodes.ContainsKey(key))
                {
                    TreeNode t = this.treeViewEvents.Nodes[this.treeViewEvents.Nodes.IndexOfKey(key)];
                    this.treeViewEvents.SelectedNode = t;
                    if (this.treeViewEvents.SelectedNode != null)
                    {
                        this.treeViewEvents.SelectedNode.EnsureVisible();
                    }

                    this.treeViewEvents.Select();
                }
            }
        }
    }
}
