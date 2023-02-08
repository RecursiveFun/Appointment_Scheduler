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
using MySql.Data.MySqlClient;

namespace Appointment_Scheduler_Felix_Berinde
{
    public partial class AddAppointment : Form
    {
        private DateTime startDate;
        private DateTime endDate;

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
            ArrayList customerArray = new ArrayList();
            foreach (var customer in c)
            {
                customerArray.Add(customer.Name);
            }
            //set the DataSource of the listbox to the array of names
            CustomerList.DataSource = customerArray;

            //combine date picker and time picker for start and end appointment times
            startDate = startDatePicker.Value.Date + startTimePicker.Value.TimeOfDay;
            endDate = endDatePicker.Value.Date + endTimePicker.Value.TimeOfDay;


        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //TODO: Fix customerIndex as this solution for the indexing problem is no good
            
            //create customer index of selected customer array to mirror the customer BindingList index when creating the appointment
            int customerIndex = -1;

            //set customerIndex to the selected lists index
            customerIndex = CustomerList.SelectedIndex;

            //create db connection
            DBConnection.StartConnection();

            //create variables for insert command
            User currentUser = Login._CurrUser;
            string title = appointmentTitleTextBox.Text;
            string description = appointmentDescriptionTextBox.Text;
            string type = appointmentTypeTextBox.Text;
            DateTime start = startDate;
            DateTime end = endDate;
            
            const string INSERTAPPOINTMENT = @"INSERT INTO client_schedule.appointment VALUES (NULL, @customerIndex, @currentUserId, @title,
            @description, 'not needed', 'not needed', @type, 'not needed', @start, @end, NOW(), 'user', NOW(), 'user')";

            //create insert commands
            MySqlCommand appCmd = new MySqlCommand(INSERTAPPOINTMENT, DBConnection.conn);
            appCmd.Parameters.AddWithValue("@customerIndex", customerIndex);
            appCmd.Parameters.AddWithValue("@currentUserId", currentUser.Id);
            appCmd.Parameters.AddWithValue("@title", title);
            appCmd.Parameters.AddWithValue("@description", description);
            appCmd.Parameters.AddWithValue("@type", type);
            appCmd.Parameters.AddWithValue("@start", start);
            appCmd.Parameters.AddWithValue("@end", end);
            appCmd.ExecuteNonQuery();

            //close form/connection
            this.Close();
            Appointments appointmentForm = new Appointments();
            appointmentForm.Show();
            DBConnection.CloseConnection();
        }
    }
}
