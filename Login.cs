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
using System.Globalization;
using MySql.Data.MySqlClient;
using Appointment_Scheduler_Felix_Berinde.Database;
using System.Resources;



namespace Appointment_Scheduler_Felix_Berinde
{
    public partial class Login : Form
    {
        //create a variable to keep track of logged in userId
        public static User _CurrUser { get; set; }

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

            //Check to see if userName and password are over fifty characters
            if (userNameTextBox.Text.Length > 50 || passwordTextBox.Text.Length > 50)
            {
                MessageBox.Show(string.Format(rm.GetString("strOverFailureMessage")));
            }
            //check for empty text boxes
            if (userNameTextBox.Text.Equals(string.Empty) || passwordTextBox.Text.Equals(string.Empty))
            {
                MessageBox.Show(string.Format(rm.GetString("strFailureMessage")));
            }
            else
            {
                //get user list
                List<User> allUsers = DBConnection.GetAllUsers();

                try
                {
                    //check each user to see if name and/or password match to login
                    foreach (User user in allUsers)
                    {
                        if (user.UserName.ToLower() == userNameTextBox.Text.ToLower())
                        {
                            if (user.Password.ToLower() == passwordTextBox.Text.ToLower()) //successful login
                            {
                                MessageBox.Show(string.Format(rm.GetString("strSuccessMessage")) +
                                                userNameTextBox.Text);
                                Scheduler scheduler = new Scheduler();
                                scheduler.Show();
                                this.Hide();
                                //log successful login attempt
                                LogWriter.LogWrite(user.UserName + ": Entered their password successfully.");

                                //keep track of currently logged in userId
                                _CurrUser = user;
                                Console.WriteLine(_CurrUser.ToString());
                            }
                            else
                            {
                                MessageBox.Show(string.Format(rm.GetString("strFailureMessage")));
                                //log failed login attempt
                                LogWriter.LogWrite(user.UserName + ": Attempted to login with an invalid password.");
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
