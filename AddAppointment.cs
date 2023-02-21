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

            //TODO: Check for overlapping appointments

            //TODO: Check to see if the textboxes don't exceed database limits for each value being updated

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
            
            const string INSERTAPPOINTMENT = @"INSERT INTO client_schedule.appointment VALUES (NULL, @customerIndex, @currentUserId, @title,
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
