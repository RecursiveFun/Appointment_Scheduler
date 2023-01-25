using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment_Scheduler_Felix_Berinde
{
    public class AllCustomersGrid
    {
        private int _id;
        private string _name;
        private string _address;
        private string _address2;
        private string _city;
        private string _postalCode;
        private string _country;
        private string _phone;

        public AllCustomersGrid(int ID, string name, string address, string address2, string postalCode, string city, string country, string phone)
        {
            this._id = ID;
            this._name = name;
            this._address = address;
            this._address2 = address2;
            this._city = city;
            this._postalCode = postalCode;
            this._country = country;
            this._phone = phone;
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string Address2
        {
            get { return _address2; }
            set { _address2 = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string PostalCode
        {
            get { return _postalCode; }
            set { _postalCode = value; }
        }
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
    }
}
