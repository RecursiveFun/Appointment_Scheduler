using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appointment_Scheduler_Felix_Berinde
{
    public partial class Calendars : Form
    {
        public Calendars()
        {
            InitializeComponent();
        }

        //TODO: Create a method that returns a datatable

        //Populate datatable using a mysql data adapter

        //set datasource for the datagrid to the datatable



        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
