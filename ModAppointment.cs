using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Appointment_Scheduler_Felix_Berinde.Database;
using MySql.Data.MySqlClient;

namespace Appointment_Scheduler_Felix_Berinde
{
    public partial class ModAppointment : Form
    {

        //create private variables
        public int _appointId = 0;
        public ModAppointment()
        {
            InitializeComponent();

        }

        public ModAppointment(Appointment appointment)
        {
            InitializeComponent();

            //assign values
            _appointId = appointment.ID;
            startDatePicker.Value = appointment.Start;
            endDatePicker.Value = appointment.End;
            appointmentTitleTextBox.Text = appointment.Title;
            appointmentTypeTextBox.Text = appointment.Type;
            appointmentDescriptionTextBox.Text = appointment.Description;

            //assign the customerNameLabel to the customer id

            //create a new list to extract customer name from the id
            BindingList<Customer> c = new BindingList<Customer>();
            DBConnection.StartConnection();
            c = DBConnection.GetAllCustomers();
            DBConnection.CloseConnection();

            //loop through list and find matching id to assign the correct customer name
            foreach(var customer in c)
            {
                if (customer.CustomerID == appointment.CustomerID)
                {
                    customerNameLabel.Text = customer.Name;
                }
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //TODO: Check for overlapping appointments

            //TODO: Check to see if the textboxes don't exceed database limits for each value being updated


            //create variables for update commands
            User currentUser = Login._CurrUser;
            string userName = currentUser.UserName;
            int userId = currentUser.Id;
            string title = appointmentTitleTextBox.Text;
            string description = appointmentDescriptionTextBox.Text;
            string type = appointmentTypeTextBox.Text;
            DateTime start = startDatePicker.Value;
            DateTime end = endDatePicker.Value;



            //create insert statement
            string UPDATEAPPOINTMENT = 
                @"UPDATE appointment
                    SET title = @title,
                    description = @description, 
                    type = @type, 
                    start = @start, 
                    end = @end 
                WHERE appointmentId = @appointmentId;";


            //open db connection
            DBConnection.StartConnection();

            //create sql command
            MySqlCommand updatecmd = new MySqlCommand(UPDATEAPPOINTMENT, DBConnection.conn);
            updatecmd.Parameters.AddWithValue(@"title", title);
            updatecmd.Parameters.AddWithValue(@"description", description);
            updatecmd.Parameters.AddWithValue(@"type", type);
            updatecmd.Parameters.AddWithValue(@"start", TimeZoneInfo.ConvertTimeToUtc(start));
            updatecmd.Parameters.AddWithValue(@"end", TimeZoneInfo.ConvertTimeToUtc(end));
            updatecmd.Parameters.AddWithValue(@"appointmentId", _appointId);
            updatecmd.ExecuteNonQuery();




            //close connection
            DBConnection.CloseConnection();

            //open customer form
            Appointments appointmentForm = new Appointments();
            appointmentForm.Show();

            //close this form
            this.Close();
        }
    }
}
