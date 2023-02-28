using System;
using System.Windows.Forms;
using Appointment_Scheduler_Felix_Berinde.Database;
using MySql.Data.MySqlClient;

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
            Customers customers = new Customers();
            customers.Show();
            this.Close();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //check if textboxes are empty (keep address2 optional)
            if (customerNameTextBox.Text == string.Empty || customerAddressTextBox.Text == string.Empty
                                                         || customerCityTextBox.Text == string.Empty
                                                         || customerCountryTextBox.Text == string.Empty
                                                         || customerPhoneTextBox.Text == string.Empty)
            {
                MessageBox.Show(
                    "Name, Address, City, Country, and/or Phone are blank. Please add missing values before trying to submit again. (Address 2 is optional)");
            }
            else if (customerNameTextBox.Text.Length >= 45)
            {
                MessageBox.Show("Customer Name must be 45 characters or less.");
            }
            else if (customerAddressTextBox.Text.Length >= 50 || customerAddress2TextBox.Text.Length >= 50)
            {
                MessageBox.Show("Customer address fields must be 50 characters or less.");
            }
            else if (customerCityTextBox.Text.Length > 50)
            {
                MessageBox.Show("Customer City must be 50 characters or less.");
            }
            else if (customerPhoneTextBox.Text.Length > 20)
            {
                MessageBox.Show("Customer Phone number must be 20 characters or less.");
            }
            else if (customerCountryTextBox.Text.Length > 50)
            {
                MessageBox.Show("Customer Country must be 50 characters or less.");
            }
            else
            {
                //create db connection
                DBConnection.StartConnection();

                //create variables for insert commands
                User currentUser = Login._CurrUser;
                string country = customerCountryTextBox.Text;
                string city = customerCityTextBox.Text;
                string address = customerAddressTextBox.Text;
                string address2 = customerAddress2TextBox.Text;
                string postalCode = customerPostalCodeTextBox.Text;
                string customer = customerNameTextBox.Text;
                string phone = customerPhoneTextBox.Text;
                string userName = currentUser.UserName;
                

                const string INSERTCOUNTRY =
                    @"INSERT INTO client_schedule.country VALUES (NULL, @country, NOW(), @user, NOW(), @user)";
                const string INSERTCITY = @"INSERT INTO city VALUES (NULL, @city, @countryId, NOW(), @user, NOW(), @user) ";
                const string INSERTADDRESS = @"INSERT INTO address VALUES (NULL, @address, @address2, 
                                   @cityId, @postalCode, @phone, NOW(), @user, NOW(), @user)";
                const string INSERTCUSTOMER =
                    @"INSERT INTO customer VALUES (NULL, @customerName, @addressId, 1, NOW(), @user, NOW(), @user)";


                //create insert commands
                MySqlCommand countryCmd = new MySqlCommand(INSERTCOUNTRY, DBConnection.conn);
                countryCmd.Parameters.AddWithValue("@country", country);
                countryCmd.Parameters.AddWithValue("@user", userName);
                countryCmd.ExecuteNonQuery();
                int countryId = (int)countryCmd.LastInsertedId;

                MySqlCommand cityCmd = new MySqlCommand(INSERTCITY, DBConnection.conn);
                cityCmd.Parameters.AddWithValue("@countryId", countryId);
                cityCmd.Parameters.AddWithValue("@city", city);
                cityCmd.Parameters.AddWithValue("@user", userName);
                cityCmd.ExecuteNonQuery();
                int cityId = (int)cityCmd.LastInsertedId;

                MySqlCommand addressCmd = new MySqlCommand(INSERTADDRESS, DBConnection.conn);
                addressCmd.Parameters.AddWithValue("@cityId", cityId);
                addressCmd.Parameters.AddWithValue("@address", address);
                addressCmd.Parameters.AddWithValue("@address2", address2);
                addressCmd.Parameters.AddWithValue("@postalCode", postalCode);
                addressCmd.Parameters.AddWithValue("@phone", phone);
                addressCmd.Parameters.AddWithValue("@user", userName);
                addressCmd.ExecuteNonQuery();
                int addressId = (int)addressCmd.LastInsertedId;

                MySqlCommand customerCmd = new MySqlCommand(INSERTCUSTOMER, DBConnection.conn);
                customerCmd.Parameters.AddWithValue("@addressId", addressId);
                customerCmd.Parameters.AddWithValue("@customerName", customer);
                customerCmd.Parameters.AddWithValue("@user", userName);
                customerCmd.ExecuteNonQuery();
                int customerId = (int)customerCmd.LastInsertedId;

                //close form/connection
                this.Close();
                Customers customerForm = new Customers();
                customerForm.Show();
                DBConnection.CloseConnection();
            }
        }
    }
}
