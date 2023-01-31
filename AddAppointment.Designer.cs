
namespace Appointment_Scheduler_Felix_Berinde
{
    partial class AddAppointment
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
            this.CustomerList = new System.Windows.Forms.ListBox();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.appointmentTypeLabel = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.appointmentTitleTextBox = new System.Windows.Forms.TextBox();
            this.appointmentTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomerList
            // 
            this.CustomerList.FormattingEnabled = true;
            this.CustomerList.Location = new System.Drawing.Point(12, 22);
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.Size = new System.Drawing.Size(106, 43);
            this.CustomerList.TabIndex = 0;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(167, 22);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 20);
            this.startDatePicker.TabIndex = 1;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(167, 48);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 20);
            this.endDatePicker.TabIndex = 2;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(129, 22);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(32, 13);
            this.startLabel.TabIndex = 3;
            this.startLabel.Text = "Start:";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(129, 48);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(29, 13);
            this.endLabel.TabIndex = 4;
            this.endLabel.Text = "End:";
            // 
            // startTimePicker
            // 
            this.startTimePicker.Location = new System.Drawing.Point(373, 22);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(83, 20);
            this.startTimePicker.TabIndex = 5;
            // 
            // endTimePicker
            // 
            this.endTimePicker.Location = new System.Drawing.Point(373, 48);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(83, 20);
            this.endTimePicker.TabIndex = 6;
            // 
            // appointmentTypeLabel
            // 
            this.appointmentTypeLabel.AutoSize = true;
            this.appointmentTypeLabel.Location = new System.Drawing.Point(280, 87);
            this.appointmentTypeLabel.Name = "appointmentTypeLabel";
            this.appointmentTypeLabel.Size = new System.Drawing.Size(96, 13);
            this.appointmentTypeLabel.TabIndex = 7;
            this.appointmentTypeLabel.Text = "Appointment Type:";
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(382, 84);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(74, 20);
            this.typeTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Appointment Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 137);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(444, 145);
            this.descriptionTextBox.TabIndex = 10;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(382, 288);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 11;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 288);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Customer:";
            // 
            // appointmentTitleTextBox
            // 
            this.appointmentTitleTextBox.Location = new System.Drawing.Point(110, 84);
            this.appointmentTitleTextBox.Name = "appointmentTitleTextBox";
            this.appointmentTitleTextBox.Size = new System.Drawing.Size(164, 20);
            this.appointmentTitleTextBox.TabIndex = 15;
            // 
            // appointmentTitleLabel
            // 
            this.appointmentTitleLabel.AutoSize = true;
            this.appointmentTitleLabel.Location = new System.Drawing.Point(12, 87);
            this.appointmentTitleLabel.Name = "appointmentTitleLabel";
            this.appointmentTitleLabel.Size = new System.Drawing.Size(92, 13);
            this.appointmentTitleLabel.TabIndex = 14;
            this.appointmentTitleLabel.Text = "Appointment Title:";
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 324);
            this.Controls.Add(this.appointmentTitleTextBox);
            this.Controls.Add(this.appointmentTitleLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.appointmentTypeLabel);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.CustomerList);
            this.Name = "AddAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CustomerList;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Label appointmentTypeLabel;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox appointmentTitleTextBox;
        private System.Windows.Forms.Label appointmentTitleLabel;
    }
}