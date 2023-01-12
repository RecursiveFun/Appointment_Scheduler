using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing.Text;
using MySql.Data.MySqlClient;
using Appointment_Scheduler_Felix_Berinde.Database;
using System.Resources;



namespace Appointment_Scheduler_Felix_Berinde
{
    public partial class Login : Form
    {

        //Create ResourceManager for multi-lingual string data for Globalization requirement
        ResourceManager rm = new ResourceManager(typeof(Login));


        public Login()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //Check to see if userName and password are over fifty characters
            if (userNameTextBox.Text.Length > 50 || passwordTextBox.Text.Length > 50)
            {
                MessageBox.Show("Username or Password must not be over 50 characters in length.");
            }
            else
            {
                //create user login object
                User user = new User();

                //set username and password from user inputs
                user.UserName = userNameTextBox.Text;
                user.Password = passwordTextBox.Text;

                //start connection
                DBConnection.StartConnection();

                MySqlCommand cmd = DBConnection.conn.CreateCommand();

                
                cmd.CommandText = "SELECT EXISTS(SELECT userName FROM user WHERE userName = @username)"; 

                MySqlCommand msc = new MySqlCommand("SELECT `userName`, `password` FROM `user` WHERE `username` = '" + user.UserName + "' AND `password` = '" + user.Password + "'", DBConnection.conn);
                MySqlDataReader reader = msc.ExecuteReader();

                //read and validate user credentials
                if (reader.Read())
                {
                    MessageBox.Show(string.Format(rm.GetString("strSuccessMessage")) + userNameTextBox.Text);
                    DBConnection.CloseConnection();
                    Scheduler scheduler = new Scheduler();
                    reader.Close();
                    msc.Dispose();
                    scheduler.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(string.Format(rm.GetString("strFailureMessage")));
                    userNameTextBox.Text = string.Empty;
                    passwordTextBox.Text = string.Empty;
                    reader.Close();
                    msc.Dispose();
                    DBConnection.CloseConnection();
                }
            }
        }
    }
}
