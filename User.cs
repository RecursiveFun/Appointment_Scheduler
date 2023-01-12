using System;

namespace Appointment_Scheduler_Felix_Berinde
{
    class User
    {
        //Create public props for the time being
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserID { get; set; }

        //create empty user constructor
       public User()
       {
           UserName = null;
           UserID = -1;
       }

    }
}
