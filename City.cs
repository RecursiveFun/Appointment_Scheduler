using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment_Scheduler_Felix_Berinde
{
    public class City
    {
        //create private fields
        private int _cityID;
        private string _city;
        private int _countryID;
        private DateTime _createDate;
        private string _createdBy;
        private DateTime _lastUpdate;
        private string _lastUpdateBy;

        //create public getters/setters

        public int AddressID
        {
            get
            {
                return _cityID;
            }
        }

        public string CityName
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }

        public int CountryID
        {
            get
            {
                return _countryID;
            }
            set
            {
                _countryID = value;
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
        public City(int cityID, string city, int countryID, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            this._cityID = cityID;
            this._city = city;
            this._countryID = countryID;
            this._createDate = createDate;
            this._createdBy = createdBy;
            this._lastUpdate = lastUpdate;
            this._lastUpdateBy = lastUpdateBy;
        }

        //default constructor
        public City(){ }
    }
}
