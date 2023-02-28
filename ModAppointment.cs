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
        public int CustomerId = 0;

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
                    CustomerId = customer.CustomerID;
                    break;
                }
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            //create db connection
            DBConnection.StartConnection();

            //create variables for update commands
            User currentUser = Login._CurrUser;
            string userName = currentUser.UserName;
            int userId = currentUser.Id;
            string title = appointmentTitleTextBox.Text;
            string description = appointmentDescriptionTextBox.Text;
            string type = appointmentTypeTextBox.Text;
            DateTime start = startDatePicker.Value;
            DateTime end = endDatePicker.Value;

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
            allCmd.Parameters.AddWithValue("@customerId", CustomerId);

            //execute the query and retrieve the results
            MySqlDataReader reader = allCmd.ExecuteReader();
            DataTable appointments = new DataTable();
            appointments.Load(reader);

            reader.Close();

            //check for overlapping appointments and business hours prior to insert command
            bool overlap = false;
            bool outsideHours = false;

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

            }

            //throw a MessageBox if the appointments overlap
            if (overlap)
            {
                MessageBox.Show(
                    "Sorry, the customer selected already has an appointment during that time. Please check the start and end times and try again.");
            }

            //throw a MessageBox if the appointment is outside business hours.
            else if (outsideHours)
            {
                MessageBox.Show(
                    "Sorry, this appointment is outside of normal business hours (Monday - Friday 9AM - 5PM EST.).");
            }

            else
            {

                //create insert statement
                string UPDATEAPPOINTMENT =
                    @"UPDATE appointment
                    SET title = @title,
                        description = @description, 
                        type = @type, 
                        start = @start, 
                        end = @end 
                    WHERE appointmentId = @appointmentId;";



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
}
