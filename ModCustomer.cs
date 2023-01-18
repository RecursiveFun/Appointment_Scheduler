using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appointment_Scheduler_Felix_Berinde
{
    public partial class ModCustomer : Form
    {
        public ModCustomer()
        {
            InitializeComponent();
        }

        //param loaded constructor
        public ModCustomer(Customer customer)
        {
            //TODO: load customer data for modification form

            //customerNameTextBox.Text = 
            //customerAddressTextBox.Text =
            //customerAddress2TextBox.Text = 
            //customerCityTextBox.Text = 
            //customerCountryTextBox.Text = 
            //customerPhoneTextBox.Text = 
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Customers customers = new Customers();
            customers.ShowDialog();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //Confirm the reset with a MessageBox
            if (DialogResult.Yes == MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning))
            {
                customerNameTextBox.Text = string.Empty;
                customerAddressTextBox.Text = string.Empty;
                customerAddress2TextBox.Text = string.Empty;
                customerCityTextBox.Text = string.Empty;
                customerCountryTextBox.Text = string.Empty;
                customerPhoneTextBox.Text = string.Empty;
            }
        }
    }
}
