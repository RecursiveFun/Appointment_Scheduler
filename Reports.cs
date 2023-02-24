using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Appointment_Scheduler_Felix_Berinde.Database;
using MySql.Data.MySqlClient;

namespace Appointment_Scheduler_Felix_Berinde
{
    public partial class Reports : Form
    {

        PrintDocument document = new PrintDocument();
        PrintDialog dialog = new PrintDialog();

        private DataTable dt = new DataTable();

        public Reports()
        {
            InitializeComponent();
            DBConnection.StartConnection();
            string sqlString = "SELECT * FROM appointment";
            MySqlCommand cmd = new MySqlCommand(sqlString, DBConnection.conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            adp.Fill(dt);



            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void appointmentTypeButton_Click(object sender, EventArgs e)
        {
            reportsTextBox.Text = "Report: Number of each appointment type by month.\r\n\r\n";

            //create an array with each month
            string[] Months = new string[] {"January","February","March","April","May","June","July","August","September","October","November","December"};

            //loop through the array
            foreach (string month in Months)
            {
                //create a dictionary to keep track of the count of each type
                Dictionary<string, int> typeCount = new Dictionary<string, int>();

                reportsTextBox.Text = reportsTextBox.Text + month +":\r\n";

                //loop through each row of the appointments datatable
                foreach (DataRow row in dt.Rows)
                {
                    //extract type and start date of each row
                    string type = (string)row["type"];
                    DateTime start = Convert.ToDateTime(row["start"]);

                    //if current month contains an appointment increase count for the specific type
                    if (start.ToString("MMMM") == month)
                    {

                        if (typeCount.ContainsKey(type))
                        {
                            typeCount[type]++;
                        }
                        else
                        {
                            typeCount[type] = 1;
                        }
                    }
                }

                //display each type and their count
                foreach (string type in typeCount.Keys)
                {
                    int count = typeCount[type];
                    reportsTextBox.Text += "\t" + type + ": " + count + "\r\n";
                }
                //add a new line for each month
                reportsTextBox.Text += "\r\n";

            }
        }

        private void schedulesButton_Click(object sender, EventArgs e)
        {
            reportsTextBox.Text = "Report: Consultant by ID and each of their appointments.\r\n\r\n";

            //loop through each row
            foreach (DataRow row in dt.Rows)
            {
                //grab data needed for report
                int id = (int)row["userId"];
                string title = (string)row["title"];
                string type = (string)row["type"];
                DateTime start = (DateTime)row["start"];
                DateTime end = (DateTime)row["end"];

                //create a string with formatting
                string appointmentInfo = string.Format("ID: {0},   Title: {1},   Type: {2},   Start: {3},   End: {4}   \r\n", id,
                    title, type, start.ToLocalTime().ToString(), end.ToLocalTime().ToString());

                //add string to end of textbox
                reportsTextBox.Text += appointmentInfo;
            }
        }

        private void activeCustomersButton_Click(object sender, EventArgs e)
        {
            reportsTextBox.Text = "Report: All active customers and their ID.\r\n\r\n";

            //create a binding list
            BindingList<Customer> c = new BindingList<Customer>();
            //get customers from db
            c = DBConnection.GetAllCustomers();

            //loop through each customer
            foreach (Customer customer in c)
            {
                //check to see if customer is active
                if (customer.isActive)
                {
                    //display active customers and their id
                    reportsTextBox.Text += customer.Name + ":   " + customer.CustomerID + "\r\n";
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dialog.Document = document;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                document.Print();
            }
        }


        void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(reportsTextBox.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, 20, 20);
        }

    }
}
