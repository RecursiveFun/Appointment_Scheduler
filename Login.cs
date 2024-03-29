﻿using System;
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
using System.Threading;


namespace Appointment_Scheduler_Felix_Berinde
{
    public partial class Login : Form
    {
        //create a variable to keep track of logged in user
        public static User _CurrUser { get; set; }

        //private variables for messages
        private string _strOverFailureMessage;

        private string _strFailureMessage;

        private string _strSuccessMessage;

        public Login()
        {
            InitializeComponent();

            //TODO: For testing purposes only. (Comment out below line before submission)
            //CultureInfo.CurrentCulture = new CultureInfo("fr");

            if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "fr") 
            {
                this.Text = "l' Ouverture De Session";
                loginButton.Text = "Connexion";
                userNameLabel.Text = "Nom D'utilisateur:";
                passwordLabel.Text = "Mot De Passe:";
                _strFailureMessage = "Désolé, le nom d'utilisateur et/ou le mot de passe saisis sont invalides.";
                _strSuccessMessage = "Le nom d'utilisateur ou le mot de passe ne doit pas dépasser 50 caractères.";
                _strOverFailureMessage = "Bonjour, vous êtes connecté avec succès : ";
            }
            else
            {
                _strFailureMessage = "Sorry, the username and/or password entered are invalid.";
                _strSuccessMessage = "Hello, you have successfully logged in: ";
                _strOverFailureMessage = "Username or Password must not be over 50 characters in length.";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            bool loginSuccessful = false;

            //Check to see if userName and password are over fifty characters
            if (userNameTextBox.Text.Length > 50 || passwordTextBox.Text.Length > 50)
            {
                MessageBox.Show(_strOverFailureMessage);
            }
            //check for empty text boxes
            if (userNameTextBox.Text.Equals(string.Empty) || passwordTextBox.Text.Equals(string.Empty))
            {
                MessageBox.Show(_strFailureMessage);
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
                                loginSuccessful = true;

                                MessageBox.Show(_strSuccessMessage +
                                                userNameTextBox.Text);
                                Scheduler scheduler = new Scheduler();
                                scheduler.Show();
                                this.Hide();

                                //log successful login attempt
                                LogWriter.LogWrite(user.UserName + ": Entered their password successfully.");

                                //keep track of currently logged in userId
                                _CurrUser = user;
                                

                                DBConnection.StartConnection();

                                //get all appointments by id
                                string allAppointmentsByUserId = @"SELECT * FROM appointment WHERE userId = @userId";

                                //Create select command
                                MySqlCommand allCmd = new MySqlCommand(allAppointmentsByUserId, DBConnection.conn);
                                allCmd.Parameters.AddWithValue("@userId", _CurrUser.Id);

                                //execute the query and retrieve the results
                                MySqlDataReader reader = allCmd.ExecuteReader();
                                DataTable appointments = new DataTable();
                                appointments.Load(reader);

                                reader.Close();


                                //Check to see if there is any active appointments within 15 minutes
                                foreach (DataRow appointment in appointments.Rows)
                                {
                                    //create datetime variables for current time and 15 minutes later
                                    DateTime now = DateTime.Now;
                                    DateTime end = now.AddMinutes(15);

                                    DateTime start = DateTime.Parse(appointment["start"].ToString());
                                    start = start.ToLocalTime();
                                    now = now.ToLocalTime();

                                    if (start > now && start <= end)
                                    {
                                        MessageBox.Show("Appointment within 15 minutes: " + start + "\n\r\n\r" + 
                                                        "Title: " + appointment["title"] + "\n\r\n\r" +
                                                        "Type: " + appointment["type"] + "\n\r\n\r" +
                                                        "Details: " + appointment["description"]);
                                    }
                                }
                            }
                            else
                            {
                                //log failed login attempt
                                LogWriter.LogWrite(user.UserName + ": Attempted to login with an invalid password.");
                            }
                        }
                    }

                    if (!loginSuccessful)
                    {
                        MessageBox.Show(_strFailureMessage);
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
