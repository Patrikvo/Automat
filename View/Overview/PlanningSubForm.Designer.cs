namespace Automat.View.Overview
{
    partial class PlanningSubForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanningSubForm));
            this.treeViewEvents = new System.Windows.Forms.TreeView();
            this.contextMenuStripEvents = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAddEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBewerken = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListTreeview = new System.Windows.Forms.ImageList(this.components);
            this.monthCalendarTasks = new System.Windows.Forms.MonthCalendar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.contextMenuStripEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewEvents
            // 
            this.treeViewEvents.ContextMenuStrip = this.contextMenuStripEvents;
            this.treeViewEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewEvents.HotTracking = true;
            this.treeViewEvents.ImageIndex = 0;
            this.treeViewEvents.ImageList = this.imageListTreeview;
            this.treeViewEvents.Location = new System.Drawing.Point(0, 0);
            this.treeViewEvents.Name = "treeViewEvents";
            this.treeViewEvents.SelectedImageIndex = 0;
            this.treeViewEvents.Size = new System.Drawing.Size(605, 425);
            this.treeViewEvents.TabIndex = 5;
            // 
            // contextMenuStripEvents
            // 
            this.contextMenuStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddEvent,
            this.toolStripMenuItemBewerken,
            this.toolStripMenuItemRemove});
            this.contextMenuStripEvents.Name = "contextMenuStripEvents";
            this.contextMenuStripEvents.Size = new System.Drawing.Size(136, 70);
            this.contextMenuStripEvents.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStripEvents_Opening);
            // 
            // toolStripMenuItemAddEvent
            // 
            this.toolStripMenuItemAddEvent.Name = "toolStripMenuItemAddEvent";
            this.toolStripMenuItemAddEvent.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItemAddEvent.Text = "Toevoegen";
            this.toolStripMenuItemAddEvent.Click += new System.EventHandler(this.ToolStripMenuItemAddEvent_Click_1);
            // 
            // toolStripMenuItemBewerken
            // 
            this.toolStripMenuItemBewerken.Name = "toolStripMenuItemBewerken";
            this.toolStripMenuItemBewerken.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItemBewerken.Text = "Bewerken";
            this.toolStripMenuItemBewerken.Click += new System.EventHandler(this.ToolStripMenuItemBewerken_Click_1);
            // 
            // toolStripMenuItemRemove
            // 
            this.toolStripMenuItemRemove.Name = "toolStripMenuItemRemove";
            this.toolStripMenuItemRemove.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItemRemove.Text = "Verwijderen";
            this.toolStripMenuItemRemove.Click += new System.EventHandler(this.ToolStripMenuItemRemove_Click_1);
            // 
            // imageListTreeview
            // 
            this.imageListTreeview.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTreeview.ImageStream")));
            this.imageListTreeview.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTreeview.Images.SetKeyName(0, "blank.png");
            this.imageListTreeview.Images.SetKeyName(1, "Date.png");
            this.imageListTreeview.Images.SetKeyName(2, "accept.png");
            this.imageListTreeview.Images.SetKeyName(3, "cross.png");
            this.imageListTreeview.Images.SetKeyName(4, "exclamation.png");
            this.imageListTreeview.Images.SetKeyName(5, "house.png");
            this.imageListTreeview.Images.SetKeyName(6, "user.png");
            this.imageListTreeview.Images.SetKeyName(7, "user_gray.png");
            // 
            // monthCalendarTasks
            // 
            this.monthCalendarTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendarTasks.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.monthCalendarTasks.Location = new System.Drawing.Point(9, 7);
            this.monthCalendarTasks.MaxSelectionCount = 1;
            this.monthCalendarTasks.Name = "monthCalendarTasks";
            this.monthCalendarTasks.ShowWeekNumbers = true;
            this.monthCalendarTasks.TabIndex = 4;
            this.monthCalendarTasks.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendarTasks_DateSelected);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewEvents);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.monthCalendarTasks);
            this.splitContainer1.Size = new System.Drawing.Size(605, 607);
            this.splitContainer1.SplitterDistance = 425;
            this.splitContainer1.TabIndex = 6;
            // 
            // PlanningSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 607);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlanningSubForm";
            this.Text = "PlanningSubForm";
            this.contextMenuStripEvents.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeViewEvents;
        private System.Windows.Forms.MonthCalendar monthCalendarTasks;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEvents;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddEvent;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBewerken;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRemove;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ImageList imageListTreeview;
    }
}