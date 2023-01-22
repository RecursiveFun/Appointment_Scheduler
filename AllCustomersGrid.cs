using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment_Scheduler_Felix_Berinde
{
    public class AllCustomersGrid
    {
        private int _ID;
        private string _Name;
        private string _Address;
        private string _Address2;
        private string _City;
        private string _Country;
        private string _Phone;

        public AllCustomersGrid(int ID, string name, string address, string address2, string city, string country, string phone)
        {
            this._ID = ID;
            this._Name = name;
            this._Address = address;
            this._Address2 = address2;
            this._City = city;
            this._Country = country;
            this._Phone = phone;
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        public string Address2
        {
            get { return _Address2; }
            set { _Address2 = value; }
        }

        public string City
        {
            get { return _City; }
            set { _City = value; }
        }
        public string Country
        {
            get { return _Country; }
            set { _Country = value; }
        }
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }
    }
}
