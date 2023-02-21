
namespace Appointment_Scheduler_Felix_Berinde
{
    partial class ModAppointment
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
            this.appointmentTitleTextBox = new System.Windows.Forms.TextBox();
            this.appointmentTitleLabel = new System.Windows.Forms.Label();
            this.customerListLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.appointmentDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.appointmentDescriptionLabel = new System.Windows.Forms.Label();
            this.appointmentTypeTextBox = new System.Windows.Forms.TextBox();
            this.appointmentTypeLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // appointmentTitleTextBox
            // 
            this.appointmentTitleTextBox.Location = new System.Drawing.Point(110, 88);
            this.appointmentTitleTextBox.Name = "appointmentTitleTextBox";
            this.appointmentTitleTextBox.Size = new System.Drawing.Size(164, 20);
            this.appointmentTitleTextBox.TabIndex = 31;
            // 
            // appointmentTitleLabel
            // 
            this.appointmentTitleLabel.AutoSize = true;
            this.appointmentTitleLabel.Location = new System.Drawing.Point(12, 91);
            this.appointmentTitleLabel.Name = "appointmentTitleLabel";
            this.appointmentTitleLabel.Size = new System.Drawing.Size(92, 13);
            this.appointmentTitleLabel.TabIndex = 30;
            this.appointmentTitleLabel.Text = "Appointment Title:";
            // 
            // customerListLabel
            // 
            this.customerListLabel.AutoSize = true;
            this.customerListLabel.Location = new System.Drawing.Point(12, 10);
            this.customerListLabel.Name = "customerListLabel";
            this.customerListLabel.Size = new System.Drawing.Size(54, 13);
            this.customerListLabel.TabIndex = 29;
            this.customerListLabel.Text = "Customer:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 292);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 28;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(382, 292);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 27;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // appointmentDescriptionTextBox
            // 
            this.appointmentDescriptionTextBox.Location = new System.Drawing.Point(12, 141);
            this.appointmentDescriptionTextBox.Multiline = true;
            this.appointmentDescriptionTextBox.Name = "appointmentDescriptionTextBox";
            this.appointmentDescriptionTextBox.Size = new System.Drawing.Size(444, 145);
            this.appointmentDescriptionTextBox.TabIndex = 26;
            // 
            // appointmentDescriptionLabel
            // 
            this.appointmentDescriptionLabel.AutoSize = true;
            this.appointmentDescriptionLabel.Location = new System.Drawing.Point(12, 125);
            this.appointmentDescriptionLabel.Name = "appointmentDescriptionLabel";
            this.appointmentDescriptionLabel.Size = new System.Drawing.Size(125, 13);
            this.appointmentDescriptionLabel.TabIndex = 25;
            this.appointmentDescriptionLabel.Text = "Appointment Description:";
            // 
            // appointmentTypeTextBox
            // 
            this.appointmentTypeTextBox.Location = new System.Drawing.Point(382, 88);
            this.appointmentTypeTextBox.Name = "appointmentTypeTextBox";
            this.appointmentTypeTextBox.Size = new System.Drawing.Size(74, 20);
            this.appointmentTypeTextBox.TabIndex = 24;
            // 
            // appointmentTypeLabel
            // 
            this.appointmentTypeLabel.AutoSize = true;
            this.appointmentTypeLabel.Location = new System.Drawing.Point(280, 91);
            this.appointmentTypeLabel.Name = "appointmentTypeLabel";
            this.appointmentTypeLabel.Size = new System.Drawing.Size(96, 13);
            this.appointmentTypeLabel.TabIndex = 23;
            this.appointmentTypeLabel.Text = "Appointment Type:";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(178, 52);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(29, 13);
            this.endLabel.TabIndex = 20;
            this.endLabel.Text = "End:";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(178, 26);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(32, 13);
            this.startLabel.TabIndex = 19;
            this.startLabel.Text = "Start:";
            // 
            // endDatePicker
            // 
            this.endDatePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDatePicker.Location = new System.Drawing.Point(216, 52);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(240, 20);
            this.endDatePicker.TabIndex = 18;
            // 
            // startDatePicker
            // 
            this.startDatePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDatePicker.Location = new System.Drawing.Point(216, 26);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(241, 20);
            this.startDatePicker.TabIndex = 17;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(11, 26);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(81, 24);
            this.customerNameLabel.TabIndex = 32;
            this.customerNameLabel.Text = "#custID?";
            // 
            // ModAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 324);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.appointmentTitleTextBox);
            this.Controls.Add(this.appointmentTitleLabel);
            this.Controls.Add(this.customerListLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.appointmentDescriptionTextBox);
            this.Controls.Add(this.appointmentDescriptionLabel);
            this.Controls.Add(this.appointmentTypeTextBox);
            this.Controls.Add(this.appointmentTypeLabel);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(485, 363);
            this.MinimumSize = new System.Drawing.Size(485, 363);
            this.Name = "ModAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox appointmentTitleTextBox;
        private System.Windows.Forms.Label appointmentTitleLabel;
        private System.Windows.Forms.Label customerListLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox appointmentDescriptionTextBox;
        private System.Windows.Forms.Label appointmentDescriptionLabel;
        private System.Windows.Forms.TextBox appointmentTypeTextBox;
        private System.Windows.Forms.Label appointmentTypeLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label customerNameLabel;
    }
}