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

        //Create ResourceManager for multi-lingual string data for Globalization requirement and switching between languages
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
            //TODO:Fix error handling for invalid username login attempt
            //TODO:Create a log function to fire off here for login attempts. It must timestamp and is append or creates a new .txt log file depending on if one exists.

            //Check to see if userName and password are over fifty characters
            if (userNameTextBox.Text.Length > 50 || passwordTextBox.Text.Length > 50)
            {
                MessageBox.Show("Username or Password must not be over 50 characters in length.");
            }
            else
            {
                //get user list
                List<User> allUsers = DBConnection.GetAllUsers();

                try
                {
                    //check each user to see if name or password match to login
                    foreach (User user in allUsers)
                    {
                        if (user.UserName == userNameTextBox.Text)
                        {
                            if (user.Password == passwordTextBox.Text)
                            {
                                MessageBox.Show(string.Format(rm.GetString("strSuccessMessage")) +
                                                userNameTextBox.Text);
                                Scheduler scheduler = new Scheduler();
                                scheduler.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show(string.Format(rm.GetString("strFailureMessage")));
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    DBConnection.CloseConnection();
                }
            }
        }
    }
}
