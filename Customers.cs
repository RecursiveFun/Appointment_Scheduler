using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Appointment_Scheduler_Felix_Berinde.Database;


namespace Appointment_Scheduler_Felix_Berinde
{
    public partial class Customers : Form
    {
        //create temp customer list
        List<AllCustomersGrid> allCusto = new List<AllCustomersGrid>();

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
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AddCustomer customer = new AddCustomer();
            customer.ShowDialog();
        }

        private void modCustomerButton_Click(object sender, EventArgs e)
        {
            //check for no selection
            if (customersDGV.CurrentRow == null || !customersDGV.CurrentRow.Selected)
            {
                MessageBox.Show("Nothing Selected!", "Please make a selection.");
                return;
            }
            this.Close();
            ModCustomer customer = new ModCustomer();
            customer.ShowDialog();
        }

        private void customersDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
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
                
                //TODO: remove the selected customer from database
                

                //allCusto.Remove(c);
                //customersDGV.Refresh();
            }
        }

    }
}
