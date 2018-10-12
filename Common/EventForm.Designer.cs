namespace Automat.Common
{
    partial class EventForm
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
            this.buttonEventCancel = new System.Windows.Forms.Button();
            this.radioButtonExtern = new System.Windows.Forms.RadioButton();
            this.radioButtonKlant = new System.Windows.Forms.RadioButton();
            this.radioButtonDossierbeheerder = new System.Windows.Forms.RadioButton();
            this.labelDeadline = new System.Windows.Forms.Label();
            this.buttonAddEvent = new System.Windows.Forms.Button();
            this.textBoxOnderwerp = new System.Windows.Forms.TextBox();
            this.labelOnderwerp = new System.Windows.Forms.Label();
            this.dateTimePickerDeadline = new System.Windows.Forms.DateTimePicker();
            this.checkBoxEventCompleted = new System.Windows.Forms.CheckBox();
            this.dateTimePickerEventCompleted = new System.Windows.Forms.DateTimePicker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEventCancel
            // 
            this.buttonEventCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEventCancel.Location = new System.Drawing.Point(431, 94);
            this.buttonEventCancel.Name = "buttonEventCancel";
            this.buttonEventCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonEventCancel.TabIndex = 8;
            this.buttonEventCancel.Text = "Annuleren";
            this.buttonEventCancel.UseVisualStyleBackColor = true;
            this.buttonEventCancel.Click += new System.EventHandler(this.ButtonEventCancel_Click);
            // 
            // radioButtonExtern
            // 
            this.radioButtonExtern.AutoSize = true;
            this.radioButtonExtern.Location = new System.Drawing.Point(10, 84);
            this.radioButtonExtern.Name = "radioButtonExtern";
            this.radioButtonExtern.Size = new System.Drawing.Size(55, 17);
            this.radioButtonExtern.TabIndex = 7;
            this.radioButtonExtern.TabStop = true;
            this.radioButtonExtern.Text = "Extern";
            this.radioButtonExtern.UseVisualStyleBackColor = true;
            // 
            // radioButtonKlant
            // 
            this.radioButtonKlant.AutoSize = true;
            this.radioButtonKlant.Location = new System.Drawing.Point(10, 61);
            this.radioButtonKlant.Name = "radioButtonKlant";
            this.radioButtonKlant.Size = new System.Drawing.Size(49, 17);
            this.radioButtonKlant.TabIndex = 6;
            this.radioButtonKlant.Text = "Klant";
            this.radioButtonKlant.UseVisualStyleBackColor = true;
            // 
            // radioButtonDossierbeheerder
            // 
            this.radioButtonDossierbeheerder.AutoSize = true;
            this.radioButtonDossierbeheerder.Checked = true;
            this.radioButtonDossierbeheerder.Location = new System.Drawing.Point(10, 38);
            this.radioButtonDossierbeheerder.Name = "radioButtonDossierbeheerder";
            this.radioButtonDossierbeheerder.Size = new System.Drawing.Size(108, 17);
            this.radioButtonDossierbeheerder.TabIndex = 5;
            this.radioButtonDossierbeheerder.TabStop = true;
            this.radioButtonDossierbeheerder.Text = "Dossierbeheerder";
            this.radioButtonDossierbeheerder.UseVisualStyleBackColor = true;
            // 
            // labelDeadline
            // 
            this.labelDeadline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDeadline.AutoSize = true;
            this.labelDeadline.Location = new System.Drawing.Point(332, 44);
            this.labelDeadline.Name = "labelDeadline";
            this.labelDeadline.Size = new System.Drawing.Size(49, 13);
            this.labelDeadline.TabIndex = 4;
            this.labelDeadline.Text = "Deadline";
            // 
            // buttonAddEvent
            // 
            this.buttonAddEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddEvent.Enabled = false;
            this.buttonAddEvent.Location = new System.Drawing.Point(512, 94);
            this.buttonAddEvent.Name = "buttonAddEvent";
            this.buttonAddEvent.Size = new System.Drawing.Size(75, 23);
            this.buttonAddEvent.TabIndex = 3;
            this.buttonAddEvent.Text = "Toevoegen";
            this.buttonAddEvent.UseVisualStyleBackColor = true;
            this.buttonAddEvent.Click += new System.EventHandler(this.ButtonAddEvent_Click);
            // 
            // textBoxOnderwerp
            // 
            this.textBoxOnderwerp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOnderwerp.Location = new System.Drawing.Point(75, 12);
            this.textBoxOnderwerp.Name = "textBoxOnderwerp";
            this.textBoxOnderwerp.Size = new System.Drawing.Size(512, 20);
            this.textBoxOnderwerp.TabIndex = 2;
            this.textBoxOnderwerp.TextChanged += new System.EventHandler(this.TextBoxOnderwerp_TextChanged);
            // 
            // labelOnderwerp
            // 
            this.labelOnderwerp.AutoSize = true;
            this.labelOnderwerp.Location = new System.Drawing.Point(10, 15);
            this.labelOnderwerp.Name = "labelOnderwerp";
            this.labelOnderwerp.Size = new System.Drawing.Size(59, 13);
            this.labelOnderwerp.TabIndex = 1;
            this.labelOnderwerp.Text = "Onderwerp";
            // 
            // dateTimePickerDeadline
            // 
            this.dateTimePickerDeadline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDeadline.Location = new System.Drawing.Point(387, 38);
            this.dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            this.dateTimePickerDeadline.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDeadline.TabIndex = 0;
            // 
            // checkBoxEventCompleted
            // 
            this.checkBoxEventCompleted.AutoSize = true;
            this.checkBoxEventCompleted.Location = new System.Drawing.Point(295, 71);
            this.checkBoxEventCompleted.Name = "checkBoxEventCompleted";
            this.checkBoxEventCompleted.Size = new System.Drawing.Size(86, 17);
            this.checkBoxEventCompleted.TabIndex = 9;
            this.checkBoxEventCompleted.Text = "Afgehandeld";
            this.checkBoxEventCompleted.UseVisualStyleBackColor = true;
            this.checkBoxEventCompleted.CheckedChanged += new System.EventHandler(this.CheckBoxEventCompleted_CheckedChanged);
            // 
            // dateTimePickerEventCompleted
            // 
            this.dateTimePickerEventCompleted.Location = new System.Drawing.Point(387, 68);
            this.dateTimePickerEventCompleted.Name = "dateTimePickerEventCompleted";
            this.dateTimePickerEventCompleted.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEventCompleted.TabIndex = 10;
            this.dateTimePickerEventCompleted.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 137);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(599, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 159);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dateTimePickerEventCompleted);
            this.Controls.Add(this.checkBoxEventCompleted);
            this.Controls.Add(this.buttonEventCancel);
            this.Controls.Add(this.radioButtonExtern);
            this.Controls.Add(this.radioButtonKlant);
            this.Controls.Add(this.dateTimePickerDeadline);
            this.Controls.Add(this.radioButtonDossierbeheerder);
            this.Controls.Add(this.labelOnderwerp);
            this.Controls.Add(this.labelDeadline);
            this.Controls.Add(this.textBoxOnderwerp);
            this.Controls.Add(this.buttonAddEvent);
            this.Name = "EventForm";
            this.Text = "Taak";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEventCancel;
        private System.Windows.Forms.RadioButton radioButtonExtern;
        private System.Windows.Forms.RadioButton radioButtonKlant;
        private System.Windows.Forms.RadioButton radioButtonDossierbeheerder;
        private System.Windows.Forms.Label labelDeadline;
        private System.Windows.Forms.Button buttonAddEvent;
        private System.Windows.Forms.TextBox textBoxOnderwerp;
        private System.Windows.Forms.Label labelOnderwerp;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeadline;
        private System.Windows.Forms.CheckBox checkBoxEventCompleted;
        private System.Windows.Forms.DateTimePicker dateTimePickerEventCompleted;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}