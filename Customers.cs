using System;
using System.Windows.Forms;


namespace Appointment_Scheduler_Felix_Berinde
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCustomer customer = new AddCustomer();
            customer.ShowDialog();
        }

        private void modCustomerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModCustomer customer = new ModCustomer();
            customer.ShowDialog();
        }
    }
}
