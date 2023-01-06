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

            //Get the connection string 
            DBConnection.StartConnection();


            MySqlCommand msc = new MySqlCommand("SELECT `userName`, `password` FROM `user` WHERE `username` = '" + userNameTextBox.Text + "' AND `password` = '" + passwordTextBox.Text + "'", DBConnection.conn);
            MySqlDataReader reader = msc.ExecuteReader();


            //read and validate user credentials
            if (reader.Read())
            {
                MessageBox.Show(string.Format(rm.GetString("strSuccessMessage")) + userNameTextBox.Text);
                Scheduler schedule = new Scheduler();
                schedule.ShowDialog();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show(string.Format(rm.GetString("strFailureMessage")));
                userNameTextBox.Text = string.Empty;
                passwordTextBox.Text = string.Empty;
                reader.Close();
                msc.Dispose();

                //Close connection
                DBConnection.conn.Close();
            }

        }



        //Button that changes the CultureInfo value from default to French and then between English and French if continuously clicked for testing.
        bool isRegionEN = true;

        private void button1_Click(object sender, EventArgs e)
        {
            if (isRegionEN)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr-BE");
                ComponentResourceManager resources = new ComponentResourceManager(typeof(Login));
                resources.ApplyResources(this, "$this");
                applyResources(resources, this.Controls);
                isRegionEN = false;
            }
            else
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                ComponentResourceManager resources = new ComponentResourceManager(typeof(Login));
                resources.ApplyResources(this, "$this");
                applyResources(resources, this.Controls);
                isRegionEN = true;
            }
        }
        private void applyResources(ComponentResourceManager resources, Control.ControlCollection ctls)
        {
            //Method that updates each resource
            foreach (Control ctl in ctls)
            {
                resources.ApplyResources(ctl, ctl.Name);
                applyResources(resources, ctl.Controls);
            }
        }

    }
}
