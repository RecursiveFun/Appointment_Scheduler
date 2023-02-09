
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
            this.appointmentTypeTextBox = new System.Windows.Forms.TextBox();
            this.appointmentDescriptionLabel = new System.Windows.Forms.Label();
            this.appointmentDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.customerListLabel = new System.Windows.Forms.Label();
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
            // appointmentTypeTextBox
            // 
            this.appointmentTypeTextBox.Location = new System.Drawing.Point(382, 84);
            this.appointmentTypeTextBox.Name = "appointmentTypeTextBox";
            this.appointmentTypeTextBox.Size = new System.Drawing.Size(74, 20);
            this.appointmentTypeTextBox.TabIndex = 8;
            // 
            // appointmentDescriptionLabel
            // 
            this.appointmentDescriptionLabel.AutoSize = true;
            this.appointmentDescriptionLabel.Location = new System.Drawing.Point(12, 121);
            this.appointmentDescriptionLabel.Name = "appointmentDescriptionLabel";
            this.appointmentDescriptionLabel.Size = new System.Drawing.Size(125, 13);
            this.appointmentDescriptionLabel.TabIndex = 9;
            this.appointmentDescriptionLabel.Text = "Appointment Description:";
            // 
            // appointmentDescriptionTextBox
            // 
            this.appointmentDescriptionTextBox.Location = new System.Drawing.Point(12, 137);
            this.appointmentDescriptionTextBox.Multiline = true;
            this.appointmentDescriptionTextBox.Name = "appointmentDescriptionTextBox";
            this.appointmentDescriptionTextBox.Size = new System.Drawing.Size(444, 145);
            this.appointmentDescriptionTextBox.TabIndex = 10;
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
            // customerListLabel
            // 
            this.customerListLabel.AutoSize = true;
            this.customerListLabel.Location = new System.Drawing.Point(12, 6);
            this.customerListLabel.Name = "customerListLabel";
            this.customerListLabel.Size = new System.Drawing.Size(54, 13);
            this.customerListLabel.TabIndex = 13;
            this.customerListLabel.Text = "Customer:";
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
            this.Controls.Add(this.customerListLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.appointmentDescriptionTextBox);
            this.Controls.Add(this.appointmentDescriptionLabel);
            this.Controls.Add(this.appointmentTypeTextBox);
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
        private System.Windows.Forms.TextBox appointmentTypeTextBox;
        private System.Windows.Forms.Label appointmentDescriptionLabel;
        private System.Windows.Forms.TextBox appointmentDescriptionTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label customerListLabel;
        private System.Windows.Forms.TextBox appointmentTitleTextBox;
        private System.Windows.Forms.Label appointmentTitleLabel;
    }
}