﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Appointment_Scheduler_Felix_Berinde.Database;
using MySql.Data.MySqlClient;

namespace Appointment_Scheduler_Felix_Berinde
{
    public partial class Appointments : Form
    {

        //create local appointment list
        BindingList<Appointment> allAppoint = new BindingList<Appointment>();

        public Appointments()
        {
            InitializeComponent();
            //assign the customer class database table to the temp customer list
             allAppoint = DBConnection.GetAllAppointments();

            //set the data source
            appointmentsDGV.DataSource = allAppoint;

            //see a full row selection
            appointmentsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //make grid readonly
            appointmentsDGV.ReadOnly = true;

            //make grid only able to select one row
            appointmentsDGV.MultiSelect = false;

            //remove bottom column
            appointmentsDGV.AllowUserToAddRows = false;

            //remove row header
            appointmentsDGV.RowHeadersVisible = false;

            //remove vertical scrollbar
            appointmentsDGV.ScrollBars = ScrollBars.Vertical;


            //remove unneeded columns from the grid
            appointmentsDGV.Columns["ID"].Visible = false;
            appointmentsDGV.Columns["UserID"].Visible = false;
            appointmentsDGV.Columns["location"].Visible = false;
            appointmentsDGV.Columns["contact"].Visible = false;
            appointmentsDGV.Columns["url"].Visible = false;
            appointmentsDGV.Columns["createDate"].Visible = false;
            appointmentsDGV.Columns["lastUpdate"].Visible = false;
            appointmentsDGV.Columns["lastUpdatedBy"].Visible = false;
            appointmentsDGV.Columns["createdBy"].Visible = false;

            //change width of certain columns so they display nicer
            appointmentsDGV.Columns["CustomerID"].Width = 75;
            appointmentsDGV.Columns["Start"].Width = 120;
            appointmentsDGV.Columns["End"].Width = 120;
            appointmentsDGV.Columns["Type"].Width = 80;


            //Change column format in grid for datetimes to display the time
            appointmentsDGV.Columns[9].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm:ss";
            appointmentsDGV.Columns[10].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm:ss";

            //loop through all the appointments and convert from UTC to users local time
            for (int index = 0; index < appointmentsDGV.Rows.Count; index++)
            {
                DataGridViewRow row = appointmentsDGV.Rows[index];

                // Convert "Start" time to local time
                DateTime startUtc = (DateTime)row.Cells["Start"].Value;
                DateTime startLocal = TimeZoneInfo.ConvertTimeFromUtc(startUtc, TimeZoneInfo.Local);
                string startLocalString = startLocal.ToString();
                row.Cells["Start"].Value = startLocalString;

                // Convert "End" time to local time
                DateTime endUtc = (DateTime)row.Cells["End"].Value;
                DateTime endLocal = TimeZoneInfo.ConvertTimeFromUtc(endUtc, TimeZoneInfo.Local);
                string endLocalString = endLocal.ToString();
                row.Cells["End"].Value = endLocalString;
            }


        }

        private void appointmentsDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //remove default selection from grid
            appointmentsDGV.ClearSelection();
        }

        private void addAppointmentButton_Click(object sender, EventArgs e)
        {
            AddAppointment a = new AddAppointment();
            a.Show();
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

             this.Close();
             ModAppointment appointment = new ModAppointment(A);
             appointment.Show();

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
                //remove appointment from local list
                appointmentsDGV.Rows.RemoveAt(appointmentsDGV.SelectedRows[0].Index);
                allAppoint.Remove(A);

                //open the connection
                DBConnection.StartConnection();

                //create variables for delete command
                int ID = A.ID;
                const string DELETEAPPOINTMENT = @"DELETE FROM client_schedule.appointment WHERE appointmentId = @ID;";

                //create delete command
                MySqlCommand deleteAppointmentCmd = new MySqlCommand(DELETEAPPOINTMENT, DBConnection.conn);
                deleteAppointmentCmd.Parameters.AddWithValue("@ID", ID);
                deleteAppointmentCmd.ExecuteNonQuery();

                //close the connection
                DBConnection.CloseConnection();

                //refresh the grid to show that the deletion worked
                appointmentsDGV.Refresh();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
