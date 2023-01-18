using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment_Scheduler_Felix_Berinde
{
    public class Country
    {
        //create private fields
        private int _countryID;
        private string _country;
        private DateTime _createDate;
        private string _createdBy;
        private DateTime _lastUpdate;
        private string _lastUpdateBy;

        //create public getters/setters
        public int CountryID
        {
            get
            {
                return _countryID;
            }
        }

        public string CountryName
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
            }
        }

        public DateTime CreateDate
        {
            get
            {
                return _createDate;
            }
        }

        public string CreatedBy
        {
            get
            {
                return _createdBy;
            }
        }

        public DateTime LastUpdate
        {
            get
            {
                return _lastUpdate;
            }
            set
            {
                _lastUpdate = value;
            }
        }

        public string LastUpdateBy
        {
            get
            {
                return _lastUpdateBy;
            }
            set
            {
                _lastUpdateBy = value;
            }
        }

        //create constructor with params
        public Country(int countryID, string country, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            this._countryID = countryID;
            this._country = country;
            this._createDate = createDate;
            this._createdBy = createdBy;
            this._lastUpdate = lastUpdate;
            this._lastUpdateBy = lastUpdateBy;
        }
        //default constructor
        public Country(){ }
    }
}
