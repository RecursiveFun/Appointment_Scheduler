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
        public ModCustomer()
        {
            InitializeComponent();
        }

        //param loaded constructor
        public ModCustomer(int customerID, AllCustomersGrid customer)
        {
            InitializeComponent();

            customerNameTextBox.Text = customer.Name;
            customerAddressTextBox.Text = customer.Address;
            customerAddress2TextBox.Text = customer.Address2;
            customerCityTextBox.Text = customer.City;
            customerCountryTextBox.Text = customer.Country;
            customerPhoneTextBox.Text = customer.Phone;
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

        private void submitButton_Click(object sender, EventArgs e)
        {
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
                //TODO: Fix modify submit to database

                //            //create variables for update commands
    //            string country = customerCountryTextBox.Text;
    //            string city = customerCityTextBox.Text;
    //            string address = customerAddressTextBox.Text;
    //            string address2 = customerAddress2TextBox.Text;
    //            string customer = customerNameTextBox.Text;
    //            string phone = customerPhoneTextBox.Text;

    //            const string INSERTCOUNTRY =
    //@"INSERT INTO client_schedule.country VALUES (NULL, @country, NOW(), 'user', NOW(), 'user')";
    //            const string INSERTCITY = @"INSERT INTO city VALUES (NULL, @city, @countryId, NOW(), 'user', NOW(), 'user') ";
    //            const string INSERTADDRESS = @"INSERT INTO address VALUES (NULL, @address, @address2, 
    //                               @cityId, 'not needed', @phone, NOW(), 'user', NOW(), 'user')";
    //            const string INSERTCUSTOMER =
    //                @"INSERT INTO customer VALUES (NULL, @customerName, @addressId, 1, NOW(), 'user', NOW(), 'user')";

    //            //open connection
    //            DBConnection.StartConnection();
                

    //            //create insert commands
    //            MySqlCommand countryCmd = new MySqlCommand(INSERTCOUNTRY, DBConnection.conn);
    //            countryCmd.Parameters.AddWithValue("@country", country);
    //            countryCmd.ExecuteNonQuery();
    //            int countryId = (int)countryCmd.LastInsertedId;

    //            MySqlCommand cityCmd = new MySqlCommand(INSERTCITY, DBConnection.conn);
    //            cityCmd.Parameters.AddWithValue("@countryId", countryId);
    //            cityCmd.Parameters.AddWithValue("@city", city);
    //            cityCmd.ExecuteNonQuery();
    //            int cityId = (int)cityCmd.LastInsertedId;

    //            MySqlCommand addressCmd = new MySqlCommand(INSERTADDRESS, DBConnection.conn);
    //            addressCmd.Parameters.AddWithValue("@cityId", cityId);
    //            addressCmd.Parameters.AddWithValue("@address", address);
    //            addressCmd.Parameters.AddWithValue("@address2", address2);
    //            addressCmd.Parameters.AddWithValue("@phone", phone);
    //            addressCmd.ExecuteNonQuery();
    //            int addressId = (int)addressCmd.LastInsertedId;

    //            MySqlCommand customerCmd = new MySqlCommand(INSERTCUSTOMER, DBConnection.conn);
    //            customerCmd.Parameters.AddWithValue("@addressId", addressId);
    //            customerCmd.Parameters.AddWithValue("@customerName", customer);
    //            customerCmd.ExecuteNonQuery();
    //            int customerId = (int)customerCmd.LastInsertedId;

    //            //insert into 
    //            this.Close();
    //            Customers customerForm = new Customers();
    //            customerForm.Show();
    //            DBConnection.CloseConnection();
            }
        }
    }
}
