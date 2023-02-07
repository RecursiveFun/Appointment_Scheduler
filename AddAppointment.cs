using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Appointment_Scheduler_Felix_Berinde.Database;

namespace Appointment_Scheduler_Felix_Berinde
{
    public partial class AddAppointment : Form
    {
        public AddAppointment()
        {
            InitializeComponent();

            //set format for end and start time pickers
            startTimePicker.Format = DateTimePickerFormat.Time;
            endTimePicker.Format = DateTimePickerFormat.Time;
            startTimePicker.ShowUpDown = true;
            endTimePicker.ShowUpDown = true;


            //create and get a list of all customers to display in listbox as the customer selection
            BindingList<Customer> c = new BindingList<Customer>();
            c = DBConnection.GetAllCustomers();

            //pull the name of each customer and put it into a new array
            ArrayList array = new ArrayList();
            foreach (var customer in c)
            {
                array.Add(customer.Name);
            }
            //set the DataSource of the listbox to the array of names
            CustomerList.DataSource = array;

            //combine date picker and time picker for start and end appointment times
            DateTime startDate = startDatePicker.Value.Date + startTimePicker.Value.TimeOfDay;
            DateTime endDate = endDatePicker.Value.Date + endTimePicker.Value.TimeOfDay;


        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Appointments appointment = new Appointments();
            appointment.ShowDialog();
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //customer index  of selected customer array to mirror the customer BindingList index when creating the appointment
            int customerIndex = -1;

            //testing index of selected customer array to mirror the customer BindingList index when creating the appointment
            customerIndex = CustomerList.SelectedIndex;
            appointmentTitleTextBox.Text = CurrentUser.UserID.ToString();
        }
    }
}
