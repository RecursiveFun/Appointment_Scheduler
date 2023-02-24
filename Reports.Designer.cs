
namespace Appointment_Scheduler_Felix_Berinde
{
    partial class Reports
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
            this.backButton = new System.Windows.Forms.Button();
            this.reportsTextBox = new System.Windows.Forms.TextBox();
            this.appointmentTypeButton = new System.Windows.Forms.Button();
            this.schedulesButton = new System.Windows.Forms.Button();
            this.activeCustomersButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 515);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Go Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // reportsTextBox
            // 
            this.reportsTextBox.Location = new System.Drawing.Point(12, 52);
            this.reportsTextBox.Multiline = true;
            this.reportsTextBox.Name = "reportsTextBox";
            this.reportsTextBox.ReadOnly = true;
            this.reportsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.reportsTextBox.Size = new System.Drawing.Size(557, 457);
            this.reportsTextBox.TabIndex = 12;
            // 
            // appointmentTypeButton
            // 
            this.appointmentTypeButton.Location = new System.Drawing.Point(12, 23);
            this.appointmentTypeButton.Name = "appointmentTypeButton";
            this.appointmentTypeButton.Size = new System.Drawing.Size(121, 23);
            this.appointmentTypeButton.TabIndex = 13;
            this.appointmentTypeButton.Text = "Appointment Types";
            this.appointmentTypeButton.UseVisualStyleBackColor = true;
            this.appointmentTypeButton.Click += new System.EventHandler(this.appointmentTypeButton_Click);
            // 
            // schedulesButton
            // 
            this.schedulesButton.Location = new System.Drawing.Point(231, 23);
            this.schedulesButton.Name = "schedulesButton";
            this.schedulesButton.Size = new System.Drawing.Size(121, 23);
            this.schedulesButton.TabIndex = 14;
            this.schedulesButton.Text = "Consultant Schedules";
            this.schedulesButton.UseVisualStyleBackColor = true;
            this.schedulesButton.Click += new System.EventHandler(this.schedulesButton_Click);
            // 
            // activeCustomersButton
            // 
            this.activeCustomersButton.Location = new System.Drawing.Point(448, 23);
            this.activeCustomersButton.Name = "activeCustomersButton";
            this.activeCustomersButton.Size = new System.Drawing.Size(121, 23);
            this.activeCustomersButton.TabIndex = 15;
            this.activeCustomersButton.Text = "Active Customers";
            this.activeCustomersButton.UseVisualStyleBackColor = true;
            this.activeCustomersButton.Click += new System.EventHandler(this.activeCustomersButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 550);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.activeCustomersButton);
            this.Controls.Add(this.schedulesButton);
            this.Controls.Add(this.appointmentTypeButton);
            this.Controls.Add(this.reportsTextBox);
            this.Controls.Add(this.backButton);
            this.MaximumSize = new System.Drawing.Size(597, 589);
            this.MinimumSize = new System.Drawing.Size(597, 589);
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox reportsTextBox;
        private System.Windows.Forms.Button appointmentTypeButton;
        private System.Windows.Forms.Button schedulesButton;
        private System.Windows.Forms.Button activeCustomersButton;
        private System.Windows.Forms.Button button1;
    }
}