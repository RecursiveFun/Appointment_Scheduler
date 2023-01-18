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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Customers customers = new Customers();
            customers.ShowDialog();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //sequence needed to add customer
            //grab a new countryID
            //insert countryID, countryName, DateTime.Now(), User.userName, DateTime.Now(), User.userName
            //grab new cityID
            //insert cityID, cityName, countryID, DateTime.Now(), User.userName, DateTime.Now(), User.userName
            //grab new addressID
            //insert addressID, address, address2, phone, DateTime.Now(), User.userName, DateTime.Now(), User.userName
            //grab new customerID
            //insert customerID, customerName, addressID, 1, DateTime.Now(), User.userName, DateTime.Now(), User.userName
            //confirm that the insert was made and throw an error otherwise
            //update local lists and database tables
        }
    }
}
