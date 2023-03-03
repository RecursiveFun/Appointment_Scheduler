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
        //create private variables
        private ArrayList customerArray = new ArrayList();

        public AddAppointment()
        {
            InitializeComponent();

            //create and get a list of all customers to display in listbox as the customer selection
            BindingList<Customer> c = new BindingList<Customer>();
            c = DBConnection.GetAllCustomers();


            //display the customer name only
            CustomerList.DisplayMember = "Name";
            CustomerList.ValueMember = "CustomerID";

            //pull the name of each customer and put it into a new array
            foreach (var customer in c)
            {
                customerArray.Add(new Customer
                {
                    CustomerID = customer.CustomerID,
                    Name = customer.Name
                });
            }

            //set the DataSource of the listbox to the array of names
            CustomerList.DataSource = customerArray;

            
            //remove default selection
            CustomerList.ClearSelected();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            //variable for customerID
            int customerID;

            //check if a customer is selected from the list
            if (CustomerList.SelectedIndex != -1)
            {
                var selectedCustomer = (Customer)CustomerList.SelectedItem;
                customerID = selectedCustomer.CustomerID;
            }
            else
            {
                MessageBox.Show("Please select a customer from the list.");
                return;
            }


            //create db connection
            DBConnection.StartConnection();

            //create variables for insert command
            User currentUser = Login._CurrUser;
            string title = appointmentTitleTextBox.Text;
            string description = appointmentDescriptionTextBox.Text;
            string type = appointmentTypeTextBox.Text;
            DateTime start = startDatePicker.Value;
            DateTime end = endDatePicker.Value;
            string userName = currentUser.UserName;

            if (title.Length > 255)
            {
                MessageBox.Show("Title exceeds database limit of 255 characters.");
                return;
            }

            if (description.Length > 65535)
            {
                MessageBox.Show("Description exceeds database limit of 65,535 characters.");
                return;
            }

            if (type.Length > 65536)
            {
                MessageBox.Show("Type exceeds database limit of 65,535 characters.");
                return;
            }


            //get all appointments by id
            string allAppointmentsById = @"SELECT * FROM appointment WHERE customerId = @customerId";

            //Create select command
            MySqlCommand allCmd = new MySqlCommand(allAppointmentsById, DBConnection.conn);
            allCmd.Parameters.AddWithValue("@customerId", customerID);

            //execute the query and retrieve the results
            MySqlDataReader reader = allCmd.ExecuteReader();
            DataTable appointments = new DataTable();
            appointments.Load(reader);

            reader.Close();

            //check for overlapping appointments and business hours prior to insert command
            bool overlap = false;
            bool outsideHours = false;
            bool startGreaterThanEnd = false;

            foreach (DataRow appointment in appointments.Rows)
            {
                DateTime proposedStart = DateTime.Parse(appointment["start"].ToString());
                DateTime proposedEnd = DateTime.Parse(appointment["end"].ToString());
                proposedStart = proposedStart.ToLocalTime();
                proposedEnd = proposedEnd.ToLocalTime();

                //Check for overlapping appointments
                if ((start >= proposedStart && start < proposedEnd) ||
                    (end > proposedStart && end <= proposedEnd) ||
                    (start <= proposedStart && end >= proposedEnd))
                {
                    overlap = true;
                    break;
                }

                //check for business hours
                if (start.Hour < 9 || start.Hour >= 17 || start.DayOfWeek == DayOfWeek.Saturday ||
                    start.DayOfWeek == DayOfWeek.Sunday)
                {
                    outsideHours = true;
                    break;
                }

                //check if start date is less than end date
                if (start > end)
                {
                    startGreaterThanEnd = true;
                    break;
                }

            }

            //throw a MessageBox if the appointments overlap
            if (overlap)
            {
                MessageBox.Show("Sorry, the customer selected already has an appointment during that time. Please check the start and end times and try again.");
            }

            //throw a MessageBox if the appointment is outside business hours.
            else if (outsideHours)
            {
                MessageBox.Show("Sorry, this appointment is outside of normal business hours (Monday - Friday 9AM - 5PM EST.).");
            }

            else if (startGreaterThanEnd)
            {
                MessageBox.Show("Start time must be less than end time.");
            }

            else
            { 
                //insert new appointment into the database
                const string INSERTAPPOINTMENT =
                    @"INSERT INTO client_schedule.appointment VALUES (NULL, @customerIndex, @currentUserId, @title,
                    @description, 'not needed', 'not needed', @type, 'not needed', @start, @end, NOW(), @user, NOW(), @user)";

                //create insert commands
                MySqlCommand appCmd = new MySqlCommand(INSERTAPPOINTMENT, DBConnection.conn);
                appCmd.Parameters.AddWithValue("@customerIndex", customerID);
                appCmd.Parameters.AddWithValue("@currentUserId", currentUser.Id);
                appCmd.Parameters.AddWithValue("@title", title);
                appCmd.Parameters.AddWithValue("@description", description);
                appCmd.Parameters.AddWithValue("@type", type);
                appCmd.Parameters.AddWithValue("@user", userName);
                appCmd.Parameters.AddWithValue("@start", TimeZoneInfo.ConvertTimeToUtc(start));
                appCmd.Parameters.AddWithValue("@end", TimeZoneInfo.ConvertTimeToUtc(end));
                appCmd.ExecuteNonQuery();

                //close form/connection
                this.Close();
                Appointments appointmentForm = new Appointments();
                appointmentForm.Show();
                DBConnection.CloseConnection();
            }
        }
    }
}
