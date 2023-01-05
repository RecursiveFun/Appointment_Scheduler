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
        public static MySqlConnection conn { get; set; }

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
                string login = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
                conn = new MySqlConnection(login);

            //Open the connection
                conn.Open();
                MySqlCommand msdr = new MySqlCommand("SELECT `userName`, `password` FROM `user` WHERE `username` = '" + userNameTextBox.Text + "' AND `password` = '" + passwordTextBox.Text + "'", conn);
                MySqlDataReader reader = msdr.ExecuteReader();

                ResourceManager rm = new ResourceManager(typeof(Login));

                if (reader.Read())
                {
                    MessageBox.Show(string.Format(rm.GetString("strSuccessMessage")) + userNameTextBox.Text);
                }
                else
                {
                    MessageBox.Show(string.Format(rm.GetString("strFailureMessage")));
                    userNameTextBox.Text = string.Empty;
                    passwordTextBox.Text = string.Empty;
                    reader.Close();
                    msdr.Dispose();

                    //Close connection
                    conn.Close();
                }

        }

        bool isRegionEN = true;

        private void button1_Click(object sender, EventArgs e)
        {
            if (isRegionEN)
            {
                //Button that changes the CultureInfo value from default to French and then between english and french if continuously clicked
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
