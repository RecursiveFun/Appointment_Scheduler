using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Appointment_Scheduler_Felix_Berinde.Database;
using MySql.Data.MySqlClient;


namespace Appointment_Scheduler_Felix_Berinde
{
    public partial class Customers : Form
    {
        //create temp customer list
        BindingList<AllCustomersGrid> allCusto = new BindingList<AllCustomersGrid>();

        public Customers()
        {
            InitializeComponent();

            //assign the customer class database table to the temp customer list
            allCusto = DBConnection.GetAllCustomersForm();

            //set the data source
            customersDGV.DataSource = allCusto;

            //see a full row selection
            customersDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //make grid readonly
            customersDGV.ReadOnly = true;

            //make grid only able to select one row
            customersDGV.MultiSelect = false;

            //remove bottom column
            customersDGV.AllowUserToAddRows = false;

            //remove row header
            customersDGV.RowHeadersVisible = false;

            //remove vertical scrollbar
            customersDGV.ScrollBars = ScrollBars.Vertical;

            //autosize each column evenly in the grid based on grid size
            customersDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customersDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            //remove the ID column from the grid
            customersDGV.Columns["ID"].Visible = false;

        }


        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomer customer = new AddCustomer();
            customer.Show();
            this.Close();
        }

        private void modCustomerButton_Click(object sender, EventArgs e)
        {
            //check for no selection
            if (customersDGV.CurrentRow == null || !customersDGV.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing Selected!", "Please make a selection.");
                return;
            }
            //close this form and open modCustomer 
            //get the selected row
            AllCustomersGrid c = customersDGV.CurrentRow.DataBoundItem as AllCustomersGrid;
            this.Close();
            ModCustomer customer = new ModCustomer(c);
            customer.Show();
            
        }

        private void customersDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //remove the default selection from the grid
            customersDGV.ClearSelection();
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            //check for no selection
            if (customersDGV.CurrentRow == null || !customersDGV.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing Selected!", "Please make a selection.");
                return;
            }
            //get the selected row
            AllCustomersGrid c = customersDGV.CurrentRow.DataBoundItem as AllCustomersGrid;

            //Confirm the delete with a MessageBox
            if (DialogResult.Yes == MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning))
            {
                //create db connection
                DBConnection.StartConnection();

                //get all appointments by id
                string allAppointmentsById = @"SELECT * FROM appointment WHERE customerId = @customerId";

                //Create select command
                MySqlCommand allCmd = new MySqlCommand(allAppointmentsById, DBConnection.conn);
                allCmd.Parameters.AddWithValue("@customerId", c.ID);

                //execute the query and retrieve the results
                MySqlDataReader reader = allCmd.ExecuteReader();
                DataTable appointments = new DataTable();
                appointments.Load(reader);

                reader.Close();

                if (appointments.Rows.Count > 0)
                {
                    MessageBox.Show(
                        "Sorry, Please delete any associated appointments with this customer before trying again.");
                }
                else
                {

                    //remove customer from local list
                    customersDGV.Rows.RemoveAt(customersDGV.SelectedRows[0].Index);
                    allCusto.Remove(c);

                    //open the connection
                    DBConnection.StartConnection();

                    //create variables for delete command
                    int ID = c.ID;
                    const string DELETECUSTOMER = @"DELETE FROM client_schedule.customer WHERE customerId = @ID;";

                    //create delete command
                    MySqlCommand deleteCustomerCmd = new MySqlCommand(DELETECUSTOMER, DBConnection.conn);
                    deleteCustomerCmd.Parameters.AddWithValue("@ID", ID);
                    deleteCustomerCmd.ExecuteNonQuery();

                    //close the connection
                    DBConnection.CloseConnection();

                    //refresh the grid
                    customersDGV.Refresh();
                }
            }
        }

    }
}
