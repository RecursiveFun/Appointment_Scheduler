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
using MySql.Data.MySqlClient;

namespace Appointment_Scheduler_Felix_Berinde
{
    public partial class ModCustomer : Form
    {

        //create variable for modify customer Id
        private int _modId = 0;

        public ModCustomer()
        {
            InitializeComponent();
        }

        //param loaded constructor
        public ModCustomer(AllCustomersGrid customer)
        {
            InitializeComponent();
            _modId = customer.ID;
            customerNameTextBox.Text = customer.Name;
            customerAddressTextBox.Text = customer.Address;
            customerAddress2TextBox.Text = customer.Address2;
            customerCityTextBox.Text = customer.City;
            customerPostalCodeTextBox.Text = customer.PostalCode;
            customerCountryTextBox.Text = customer.Country;
            customerPhoneTextBox.Text = customer.Phone;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
            this.Close();
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

        private void submitButton_Click(object sender, EventArgs e)
        {
            //TODO: Check to see if the textboxes don't exceed database limits for each value being updated

            //check if textboxes are empty (keep address2 optional)
            if (customerNameTextBox.Text == string.Empty || customerAddressTextBox.Text == string.Empty
                                                         || customerCityTextBox.Text == string.Empty
                                                         || customerCountryTextBox.Text == string.Empty
                                                         || customerPhoneTextBox.Text == string.Empty)
            {
                MessageBox.Show(
                    "Name, Address, City, Country, and/or Phone are blank. Please add missing values before trying to submit again.");
            }
            else
            {

                //create variables for update commands
                int customerId = _modId;
                string country = customerCountryTextBox.Text;
                string postalCode = customerPostalCodeTextBox.Text;
                string city = customerCityTextBox.Text;
                string address = customerAddressTextBox.Text;
                string address2 = customerAddress2TextBox.Text;
                string customer = customerNameTextBox.Text;
                string phone = customerPhoneTextBox.Text;
                string user = Login._CurrUser.UserName; /*Placeholder for now I eventually would like the currently logged in user
                * to update the updatedBy field, but this is currently not required for the project */


                //create update statement
                string UPDATECUSTOMER = 
                    @"UPDATE client_schedule.customer
                    SET customerName = @customer
                    WHERE customerId = @customerId;
                    UPDATE client_schedule.address
                    SET address = @address, address2 = @address2, postalCode = @postalCode, phone = @phone
                    WHERE addressId = (SELECT addressId FROM client_schedule.customer WHERE customerId = @customerId);
                    UPDATE client_schedule.city
                    SET city = @city
                    WHERE cityId = (SELECT cityId FROM client_schedule.address WHERE addressId = (SELECT addressId FROM client_schedule.customer WHERE customerId = @customerId));
                    UPDATE client_schedule.country
                    SET country = @country
                    WHERE countryId = (SELECT countryId FROM client_schedule.city WHERE cityId = (SELECT cityId FROM client_schedule.address WHERE addressId = (SELECT addressId FROM customer WHERE customerId = @customerId)))";


                //open db connection
                DBConnection.StartConnection();


                //create SQL command
                MySqlCommand updateCmd = new MySqlCommand(UPDATECUSTOMER, DBConnection.conn);
                    updateCmd.Parameters.AddWithValue("@customerId", customerId);
                    updateCmd.Parameters.AddWithValue("@customer", customer);
                    updateCmd.Parameters.AddWithValue("@address", address);
                    updateCmd.Parameters.AddWithValue("@address2", address2);
                    updateCmd.Parameters.AddWithValue("@postalCode", postalCode);
                    updateCmd.Parameters.AddWithValue("@phone", phone);
                    updateCmd.Parameters.AddWithValue("@city", city);
                    updateCmd.Parameters.AddWithValue("@country", country);
                    updateCmd.ExecuteNonQuery();

                //close connection
                DBConnection.CloseConnection();

                //open customer form
                Customers customerForm = new Customers();
                customerForm.Show();

                this.Close();
                
            }
        }
    }
}
