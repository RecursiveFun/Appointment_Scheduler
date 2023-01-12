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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Customers customers = new Customers();
            customers.ShowDialog();
        }

        private void resetButton_Click(object sender, EventArgs e)
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
