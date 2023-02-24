using System;
using System.Windows.Forms;

namespace Appointment_Scheduler_Felix_Berinde
{
    public partial class Scheduler : Form
    {
        public Scheduler()
        {
            InitializeComponent();
            
        }

        private void Scheduler_Load(object sender, EventArgs e)
        {
            
        }

        private void logoffButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
        }

        private void appointmentButton_Click(object sender, EventArgs e)
        {
            Appointments appointment= new Appointments();
            appointment.Show();
        }

        private void calenderButton_Click(object sender, EventArgs e)
        {
            Calendars calendar = new Calendars();
            calendar.Show();
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            Reports report = new Reports();
            report.Show();
        }
    }
}
