﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Appointment_Scheduler_Felix_Berinde.Database;
using MySql.Data.MySqlClient;

namespace Appointment_Scheduler_Felix_Berinde
{
    public partial class Calendars : Form
    {
        Timer _timer = new Timer();

        private DateTime currentDate;

        private DataTable dt = new DataTable();

        public Calendars()
        {
            InitializeComponent();
            //assign time on load to avoid a flash of the placeholder
            localTime.Text = DateTime.Now.ToLongTimeString();

            //create a variable for today and make it bold
            currentDate = DateTime.Now;
            calendarSelector.AddBoldedDate(currentDate);

            //make grid readonly
            calendarDGV.ReadOnly = true;

            //make grid only able to select one row
            calendarDGV.MultiSelect = false;

            //remove bottom column
            calendarDGV.AllowUserToAddRows = false;

            //remove row header
            calendarDGV.RowHeadersVisible = false;

            //remove vertical scrollbar
            calendarDGV.ScrollBars = ScrollBars.Vertical;

            //see a full row selection
            calendarDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;



            //day is set as default
            handleDay();
        }


        private void getData(string s)
        {
            //start connection
            DBConnection.StartConnection();
            //create command
            MySqlCommand cmd = new MySqlCommand(s, DBConnection.conn);
            cmd.Parameters.AddWithValue("@currentDate", currentDate.Date);
            //grab data
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            //insert data into datatable
            adp.Fill(dt);
            //close connection
            DBConnection.CloseConnection();
        }

        private void handleDay()
        {
            calendarSelector.RemoveAllBoldedDates();
            calendarSelector.AddBoldedDate(currentDate);
            calendarSelector.UpdateBoldedDates();
            dt.Clear();
            getData("SELECT * FROM appointment WHERE DATE(start) = @currentDate;");
            calendarDGV.DataSource = dt;
        }

        private void handleAll()
        {
            //get current year
            var now = DateTime.Now.Year;
            //remove all bold dates
            calendarSelector.RemoveAllBoldedDates();

            /*Nested lambdas: The first lambda iterates through the previous 10 years and the next ten years of the current year.
            The inner lambda iterates through every day of the year and adds each day to be included in the bolded dates with an array of datetime objects.
            The same can be accomplished with two for loops, but this is much shorter syntax and easier to read*/
            calendarSelector.BoldedDates = Enumerable.Range(now - 10, now + 10).SelectMany(year => Enumerable.Range(1, 365).Select(dayOfYear => new DateTime(year, 1, 1).AddDays(dayOfYear - 1))).ToArray();

            //update the dates
            calendarSelector.UpdateBoldedDates();

            //clear datatable before adding new data
            dt.Clear();

            //get appointments
            getData("SELECT * FROM appointment");

            //assign the datasource to the datatable
            calendarDGV.DataSource = dt;
        }

        private void handleWeek()
        {
            //start connection
            DBConnection.StartConnection();

            string s = "SELECT * FROM appointment WHERE DATE(start) >= @startDate AND DATE(end) <= @endDate;";

            //create command
            MySqlCommand cmd = new MySqlCommand(s, DBConnection.conn);

            //remove bolded dates
            calendarSelector.RemoveAllBoldedDates();

            //clear datatable
            dt.Clear();

            //get the day of the week
            int dow = (int)currentDate.DayOfWeek;

            //subtract the day of week to get start date
            string startDate = currentDate.AddDays(-dow).ToString("yyyy-MM-dd");
            DateTime tempDate = Convert.ToDateTime(startDate);

            //for each day of the week bold the day
            for (int i = 0; i < 7; i++)
            {
                calendarSelector.AddBoldedDate(tempDate.AddDays(i));
            }
            //update the bolded dates
            calendarSelector.UpdateBoldedDates();
            string endDate = currentDate.AddDays(7 - dow).ToString("yyyy-MM-dd");

            //start and end date parameters
            cmd.Parameters.AddWithValue("@startDate", startDate);
            cmd.Parameters.AddWithValue("@endDate", endDate);

            //grab data
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            //insert data into datatable
            adp.Fill(dt);
            //close connection
            DBConnection.CloseConnection();

        }

        private void handleMonth()
        {
            //start connection
            DBConnection.StartConnection();

            string s = "SELECT * FROM appointment WHERE DATE(start) >= @startDate AND DATE(end) <= @endDate;";
            //create command
            MySqlCommand cmd = new MySqlCommand(s, DBConnection.conn);

            //remove bolded dates
            calendarSelector.RemoveAllBoldedDates();
            //clear datatable
            dt.Clear();

            //create variables
            int mo = currentDate.Month;
            int yr = currentDate.Year;
            int daysInMonth = DateTime.DaysInMonth(yr, mo);

            //create start and end dates
            DateTime startDate = new DateTime(yr, mo, 1);
            DateTime endDate = new DateTime(yr, mo, daysInMonth);

            //add bolded dates
            for (int i = 0; i < daysInMonth; i++)
            {
                calendarSelector.AddBoldedDate(startDate.AddDays(i));
            }
            calendarSelector.UpdateBoldedDates();
            
            
            //start and end date parameters
            cmd.Parameters.AddWithValue("@startDate", startDate);
            cmd.Parameters.AddWithValue("@endDate", endDate);

            //grab data
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            //insert data into datatable
            adp.Fill(dt);
            //close connection
            DBConnection.CloseConnection();
        }


        private void Calendars_Load(object sender, EventArgs e)
        {
            //1 sec interval
            _timer.Interval = 1000;
            _timer.Tick += new EventHandler(this.timer_Tick);

            //start timer
            _timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            localTime.Text = DateTime.Now.ToLongTimeString();
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DayButton_CheckedChanged(object sender, EventArgs e)
        {
            handleDay();
        }

        private void weeklyButton_CheckedChanged(object sender, EventArgs e)
        {
            handleWeek();
        }

        private void monthlyButton_CheckedChanged(object sender, EventArgs e)
        {
            handleMonth();
        }

        private void calendarDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            calendarDGV.ClearSelection();
        }

        private void allButton_CheckedChanged(object sender, EventArgs e)
        {
            handleAll();
        }
    }
}
