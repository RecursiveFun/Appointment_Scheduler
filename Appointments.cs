using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appointment_Scheduler_Felix_Berinde
{
    public partial class Appointments : Form
    {
        public Appointments()
        {
            InitializeComponent();

            //create appointment list
            List<Appointment> tempList = new List<Appointment>();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modAppointmentButton_Click(object sender, EventArgs e)
        {
            //check for no selection
            if (appointmentsDGV.CurrentRow == null || !appointmentsDGV.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing Selected!", "Please make a selection.");
                return;
            }
            //get the selected row
             Appointment A = appointmentsDGV.CurrentRow.DataBoundItem as Appointment;

             //TODO: modify the selected appointment from the templist and database

        }

        private void deleteAppointmentButton_Click(object sender, EventArgs e)
        {
            //check for no selection
            if (appointmentsDGV.CurrentRow == null || !appointmentsDGV.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing Selected!", "Please make a selection.");
                return;
            }
            //get the selected row
            Appointment A = appointmentsDGV.CurrentRow.DataBoundItem as Appointment;

            //Confirm the delete with a MessageBox
            if (DialogResult.Yes == MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning))
            {
                //TODO: remove the selected appointment from the templist and database

            }
        }
    }
}
