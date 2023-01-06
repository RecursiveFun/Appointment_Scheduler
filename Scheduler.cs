using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Appointment_Scheduler_Felix_Berinde.Database;

namespace Appointment_Scheduler_Felix_Berinde
{
    public partial class Scheduler : Form
    {
        public Scheduler()
        {
            InitializeComponent();
        }

        private void logoffButton_Click(object sender, EventArgs e)
        {
            DBConnection.CloseConnection();
            Application.Exit();
        }
    }
}
