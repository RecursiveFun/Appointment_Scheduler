using System;
using System.Diagnostics;

namespace Appointment_Scheduler_Felix_Berinde
{
    public class User
    {
        //Create private fields
        private int _userID;
        private string _userName;
        private string _password;
        private bool _active;
        private DateTime _createDate;
        private string _createdBy;
        private DateTime _lastUpdate;
        private string _lastUpdateBy;


        // constructor without update params
        public User(int userID, string userName, string password, bool active, DateTime createDate, string createBy)
        {
            this._userID = userID;
            this._userName = userName;
            this._password = password;
            this._active = active;
            this._createdBy = createBy;
            this._createDate = createDate;
            _lastUpdate = createDate;
            _lastUpdateBy = createBy;
        }

        // constructor with update params
        public User(int userID, string userName, string password, bool active, DateTime createDate, string createBy,
            DateTime lastUpdate, string lastUpdateBy)
        {
            this._userID = userID;
            this._userName = userName;
            this._password = password;
            this._active = active;
            this._createdBy = createBy;
            this._createDate = createDate;
            this._lastUpdate = lastUpdate;
            this._lastUpdateBy = lastUpdateBy;
        }

        // create public getters for private fields

        public int Id
        {
            get
            {
                return _userID;

            }
        }

        public string UserName
        {
            get
            {
                return _userName; 

            }
        }

        public string Password
        {
            get
            {
                return _password;

            }
        }

        public bool Active
        {
            get
            {
                return _active;

            }
        }

        public DateTime CreateDate
        {
            get
            {
                return _createDate;

            }
        }

        public string CreateBy
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
        }

        public string LastUpdateBy
        {
            get
            {
                return _lastUpdateBy;

            }
        }
    }
}
