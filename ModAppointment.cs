﻿using System;
using System.Collections;
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
    public partial class ModAppointment : Form
    {
        //TODO: Fix datepicker/timepicker to display the correct end datetime

        //create private variables
        private DateTime startDateTime;
        private DateTime endDateTime;
        private BindingList<Customer> customerArray = new BindingList<Customer>();
        public int _appointId = 0;

        public ModAppointment()
        {
            InitializeComponent();
        }

        public ModAppointment(Appointment appointment)
        {
            InitializeComponent();

            //set format for end and start time pickers
            startTimePicker.Format = DateTimePickerFormat.Time;
            endTimePicker.Format = DateTimePickerFormat.Time;
            startTimePicker.ShowUpDown = true;
            endTimePicker.ShowUpDown = true;

            //create and get a list of all customers to display in listbox as the customer selection
            customerArray = DBConnection.GetAllCustomers();

            //display the customer name only
            CustomerList.DisplayMember = "Name";
            CustomerList.ValueMember = "CustomerID";

            //set the DataSource of the listbox to the array of names
            CustomerList.DataSource = customerArray;

            //combine date picker and time picker for start and end appointment times
            startDateTime = startDatePicker.Value.Date + startTimePicker.Value.TimeOfDay;
            endDateTime = endDatePicker.Value.Date + endTimePicker.Value.TimeOfDay;

            //assign values
            _appointId = appointment.ID;
            startTimePicker.Value = appointment.Start;
            endTimePicker.Value = appointment.End;
            appointmentTitleTextBox.Text = appointment.Title;
            appointmentTypeTextBox.Text = appointment.Type;
            appointmentDescriptionTextBox.Text = appointment.Description;

            //set the selected item in the CustomerList to the customer associated with the appointment
            CustomerList.SelectedValue = appointment.CustomerID;

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

            //create variables for update commands
            User currentUser = Login._CurrUser;
            string title = appointmentTitleTextBox.Text;
            string description = appointmentDescriptionTextBox.Text;
            string type = appointmentTypeTextBox.Text;
            DateTime start = startDateTime;
            DateTime end = endDateTime;
            string userName = currentUser.UserName;

            //TODO: Insert statement and sql command

            //create insert statement







            //open db connection
            DBConnection.StartConnection();

            //create sql command





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
