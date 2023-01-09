
namespace Appointment_Scheduler_Felix_Berinde
{
    partial class Scheduler
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
            this.customerButton = new System.Windows.Forms.Button();
            this.appointmentButton = new System.Windows.Forms.Button();
            this.calenderButton = new System.Windows.Forms.Button();
            this.logoffButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerButton
            // 
            this.customerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerButton.Location = new System.Drawing.Point(48, 223);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(810, 58);
            this.customerButton.TabIndex = 1;
            this.customerButton.Text = "Customer";
            this.customerButton.UseVisualStyleBackColor = true;
            // 
            // appointmentButton
            // 
            this.appointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentButton.Location = new System.Drawing.Point(48, 287);
            this.appointmentButton.Name = "appointmentButton";
            this.appointmentButton.Size = new System.Drawing.Size(810, 58);
            this.appointmentButton.TabIndex = 2;
            this.appointmentButton.Text = "Appointment";
            this.appointmentButton.UseVisualStyleBackColor = true;
            // 
            // calenderButton
            // 
            this.calenderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calenderButton.Location = new System.Drawing.Point(48, 351);
            this.calenderButton.Name = "calenderButton";
            this.calenderButton.Size = new System.Drawing.Size(810, 58);
            this.calenderButton.TabIndex = 3;
            this.calenderButton.Text = "Calender";
            this.calenderButton.UseVisualStyleBackColor = true;
            // 
            // logoffButton
            // 
            this.logoffButton.Location = new System.Drawing.Point(57, 603);
            this.logoffButton.Name = "logoffButton";
            this.logoffButton.Size = new System.Drawing.Size(75, 23);
            this.logoffButton.TabIndex = 4;
            this.logoffButton.Text = "Log Off";
            this.logoffButton.UseVisualStyleBackColor = true;
            this.logoffButton.Click += new System.EventHandler(this.logoffButton_Click);
            // 
            // Scheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 636);
            this.Controls.Add(this.logoffButton);
            this.Controls.Add(this.calenderButton);
            this.Controls.Add(this.appointmentButton);
            this.Controls.Add(this.customerButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(930, 675);
            this.MinimumSize = new System.Drawing.Size(930, 675);
            this.Name = "Scheduler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scheduler";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button appointmentButton;
        private System.Windows.Forms.Button calenderButton;
        private System.Windows.Forms.Button logoffButton;
    }
}