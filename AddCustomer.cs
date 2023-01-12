using System;
using System.Windows.Forms;

namespace Appointment_Scheduler_Felix_Berinde
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Customers customers = new Customers();
            customers.ShowDialog();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
