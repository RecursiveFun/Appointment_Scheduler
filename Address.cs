using System;

namespace Appointment_Scheduler_Felix_Berinde
{
    public class Address
    {
        //create private fields
        private int _addressID;
        private string _address1;
        private string _address2;
        private int _cityID;
        private string _postalCode;
        private string _phone;
        private DateTime _createDate;
        private string _createdBy;
        private DateTime _lastUpdate;
        private string _lastUpdateBy;


        //create public getters/setters

        public int AddressID
        {
            get { return _addressID; }
        }

        public string Address1
        {
            get { return _address1; }
            set { _address1 = value; }
        }

        public string Address2
        {
            get { return _address2; }
            set { _address2 = value; }
        }

        public int CityID
        {
            get { return _cityID; }
            set { CityID = value; }
        }

        public string PostalCode
        {
            get { return _postalCode; }
            set { _postalCode = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public DateTime CreateDate
        {
            get { return _createDate; }

        }

        public string CreatedBy
        {
            get { return _createdBy; }
        }

        public DateTime LastUpdate
        {
            get { return _lastUpdate; }
            set { _lastUpdate = value; }
        }

        public string LastUpdateBy
        {
            get { return _lastUpdateBy; }
            set { _lastUpdateBy = value; }
        }

        //create constructor with params
        public Address(int addressID, string address, string address2, int cityID,
            string postalCode, string phone, DateTime createDate, string createdBy,
            DateTime lastUpdate, string lastUpdateBy)
        {
            this._addressID = addressID;
            this._address1 = address;
            this._address2 = address2;
            this._cityID = cityID;
            this._postalCode = postalCode;
            this._phone = phone;
            this._createDate = createDate;
            this._createdBy = createdBy;
            this._lastUpdate = lastUpdate;
            this._lastUpdateBy = lastUpdateBy;
        }

        //default constructor
        public Address() { }
    }
}