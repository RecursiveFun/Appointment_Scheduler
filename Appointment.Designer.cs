﻿
namespace Appointment_Scheduler_Felix_Berinde
{
    partial class Appointment
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
            this.AppointmentLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deleteAppointmentButton = new System.Windows.Forms.Button();
            this.modAppointmentButton = new System.Windows.Forms.Button();
            this.addAppointmentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentLabel
            // 
            this.AppointmentLabel.AutoSize = true;
            this.AppointmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentLabel.Location = new System.Drawing.Point(215, 8);
            this.AppointmentLabel.Name = "AppointmentLabel";
            this.AppointmentLabel.Size = new System.Drawing.Size(126, 24);
            this.AppointmentLabel.TabIndex = 9;
            this.AppointmentLabel.Text = "Appointments";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(220, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(578, 589);
            this.dataGridView1.TabIndex = 8;
            // 
            // deleteAppointmentButton
            // 
            this.deleteAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAppointmentButton.Location = new System.Drawing.Point(21, 476);
            this.deleteAppointmentButton.Name = "deleteAppointmentButton";
            this.deleteAppointmentButton.Size = new System.Drawing.Size(155, 83);
            this.deleteAppointmentButton.TabIndex = 7;
            this.deleteAppointmentButton.Text = "Delete Appointment";
            this.deleteAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // modAppointmentButton
            // 
            this.modAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modAppointmentButton.Location = new System.Drawing.Point(21, 279);
            this.modAppointmentButton.Name = "modAppointmentButton";
            this.modAppointmentButton.Size = new System.Drawing.Size(155, 83);
            this.modAppointmentButton.TabIndex = 6;
            this.modAppointmentButton.Text = "Modify Appointment";
            this.modAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // addAppointmentButton
            // 
            this.addAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAppointmentButton.Location = new System.Drawing.Point(21, 91);
            this.addAppointmentButton.Name = "addAppointmentButton";
            this.addAppointmentButton.Size = new System.Drawing.Size(155, 83);
            this.addAppointmentButton.TabIndex = 5;
            this.addAppointmentButton.Text = "Add Appointment";
            this.addAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 632);
            this.Controls.Add(this.AppointmentLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteAppointmentButton);
            this.Controls.Add(this.modAppointmentButton);
            this.Controls.Add(this.addAppointmentButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(835, 671);
            this.MinimumSize = new System.Drawing.Size(835, 671);
            this.Name = "Appointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppointmentLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deleteAppointmentButton;
        private System.Windows.Forms.Button modAppointmentButton;
        private System.Windows.Forms.Button addAppointmentButton;
    }
}