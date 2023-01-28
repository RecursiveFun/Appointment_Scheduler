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
    public partial class Appointments : Form
    {

        //create temp customer list
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

            //autosize each column evenly in the grid based on grid size
            appointmentsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            appointmentsDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;


            //remove unneeded columns from the grid
            appointmentsDGV.Columns["ID"].Visible = false;
            appointmentsDGV.Columns["UserID"].Visible = false;
            appointmentsDGV.Columns["location"].Visible = false;
            appointmentsDGV.Columns["contact"].Visible = false;
            appointmentsDGV.Columns["url"].Visible = false;
            appointmentsDGV.Columns["createDate"].Visible = false;
            appointmentsDGV.Columns["lastUpdate"].Visible = false;
            appointmentsDGV.Columns["lastUpdatedBy"].Visible = false;
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
