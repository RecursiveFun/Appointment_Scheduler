using System;

namespace Appointment_Scheduler_Felix_Berinde
{
    public class Customer
    {
        //create private fields
        private int _customerID;
        private string _customerName { get; set; }
        private int _addressID { get; set; }
        private bool _active { get; set; }
        private DateTime _createDate;
        private string _createdBy;
        private DateTime _lastUpdate;
        private string _lastUpdateBy;

        //create getters/setters

        public int CustomerID
        {
            get { return _customerID; }
        }

        public string Name
        {
            get { return _customerName; }
            set { _customerName = value; }
        }

        public int AddressID
        {
            get { return _addressID; }
            set { _addressID = value; }
        }

        public bool isActive
        {
            get { return _active; }
            set { _active = value; }
        }

        public DateTime DateCreated
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

        //constructor with all params
        public Customer(int customerID, string customerName, int addressID, bool active, DateTime createDate,
            string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            this._customerID = customerID;
            this._customerName = customerName;
            this._addressID = addressID;
            this._active = active;
            this._createDate = createDate;
            this._createdBy = createdBy;
            this._lastUpdate = lastUpdate;
            this._lastUpdateBy = lastUpdateBy;
        }


        public Customer(){}
    }
}