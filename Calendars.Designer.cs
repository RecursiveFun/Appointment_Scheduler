
namespace Appointment_Scheduler_Felix_Berinde
{
    partial class Calendars
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
            this.DayButton = new System.Windows.Forms.RadioButton();
            this.monthlyButton = new System.Windows.Forms.RadioButton();
            this.weeklyButton = new System.Windows.Forms.RadioButton();
            this.calendarDGV = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.calendarSelector = new System.Windows.Forms.MonthCalendar();
            this.localTimeLacbel = new System.Windows.Forms.Label();
            this.localTime = new System.Windows.Forms.Label();
            this.allButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.calendarDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DayButton
            // 
            this.DayButton.AutoSize = true;
            this.DayButton.Location = new System.Drawing.Point(40, 120);
            this.DayButton.Name = "DayButton";
            this.DayButton.Size = new System.Drawing.Size(44, 17);
            this.DayButton.TabIndex = 0;
            this.DayButton.TabStop = true;
            this.DayButton.Text = "Day";
            this.DayButton.UseVisualStyleBackColor = true;
            this.DayButton.CheckedChanged += new System.EventHandler(this.DayButton_CheckedChanged);
            // 
            // monthlyButton
            // 
            this.monthlyButton.AutoSize = true;
            this.monthlyButton.Location = new System.Drawing.Point(39, 195);
            this.monthlyButton.Name = "monthlyButton";
            this.monthlyButton.Size = new System.Drawing.Size(62, 17);
            this.monthlyButton.TabIndex = 2;
            this.monthlyButton.TabStop = true;
            this.monthlyButton.Text = "Monthly";
            this.monthlyButton.UseVisualStyleBackColor = true;
            this.monthlyButton.CheckedChanged += new System.EventHandler(this.monthlyButton_CheckedChanged);
            // 
            // weeklyButton
            // 
            this.weeklyButton.AutoSize = true;
            this.weeklyButton.Location = new System.Drawing.Point(39, 158);
            this.weeklyButton.Name = "weeklyButton";
            this.weeklyButton.Size = new System.Drawing.Size(61, 17);
            this.weeklyButton.TabIndex = 1;
            this.weeklyButton.TabStop = true;
            this.weeklyButton.Text = "Weekly";
            this.weeklyButton.UseVisualStyleBackColor = true;
            this.weeklyButton.CheckedChanged += new System.EventHandler(this.weeklyButton_CheckedChanged);
            // 
            // calendarDGV
            // 
            this.calendarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calendarDGV.Location = new System.Drawing.Point(257, 18);
            this.calendarDGV.Name = "calendarDGV";
            this.calendarDGV.Size = new System.Drawing.Size(815, 731);
            this.calendarDGV.TabIndex = 3;
            this.calendarDGV.TabStop = false;
            this.calendarDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.calendarDGV_DataBindingComplete);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 729);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Go Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // calendarSelector
            // 
            this.calendarSelector.Location = new System.Drawing.Point(18, 271);
            this.calendarSelector.Name = "calendarSelector";
            this.calendarSelector.TabIndex = 5;
            this.calendarSelector.TabStop = false;
            // 
            // localTimeLacbel
            // 
            this.localTimeLacbel.AutoSize = true;
            this.localTimeLacbel.Location = new System.Drawing.Point(15, 18);
            this.localTimeLacbel.Name = "localTimeLacbel";
            this.localTimeLacbel.Size = new System.Drawing.Size(62, 13);
            this.localTimeLacbel.TabIndex = 6;
            this.localTimeLacbel.Text = "Local Time:";
            // 
            // localTime
            // 
            this.localTime.AutoSize = true;
            this.localTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localTime.Location = new System.Drawing.Point(33, 45);
            this.localTime.Name = "localTime";
            this.localTime.Size = new System.Drawing.Size(186, 39);
            this.localTime.TabIndex = 7;
            this.localTime.Text = "#localTime";
            // 
            // allButton
            // 
            this.allButton.AutoSize = true;
            this.allButton.Location = new System.Drawing.Point(39, 231);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(36, 17);
            this.allButton.TabIndex = 8;
            this.allButton.TabStop = true;
            this.allButton.Text = "All";
            this.allButton.UseVisualStyleBackColor = true;
            this.allButton.CheckedChanged += new System.EventHandler(this.allButton_CheckedChanged);
            // 
            // Calendars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 761);
            this.Controls.Add(this.allButton);
            this.Controls.Add(this.localTime);
            this.Controls.Add(this.localTimeLacbel);
            this.Controls.Add(this.calendarSelector);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.calendarDGV);
            this.Controls.Add(this.weeklyButton);
            this.Controls.Add(this.monthlyButton);
            this.Controls.Add(this.DayButton);
            this.MaximumSize = new System.Drawing.Size(1100, 800);
            this.MinimumSize = new System.Drawing.Size(1100, 800);
            this.Name = "Calendars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.Calendars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calendarDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton DayButton;
        private System.Windows.Forms.RadioButton monthlyButton;
        private System.Windows.Forms.RadioButton weeklyButton;
        private System.Windows.Forms.DataGridView calendarDGV;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.MonthCalendar calendarSelector;
        private System.Windows.Forms.Label localTimeLacbel;
        private System.Windows.Forms.Label localTime;
        private System.Windows.Forms.RadioButton allButton;
    }
}