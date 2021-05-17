using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT601_Project
{
    class Activity
    {
        private string _registrationNumber;
        private string _activityName;
        private DateTime _activityDate = DateTime.Now;
        private string _activityType;
        private decimal _revenue;

        public override string ToString()
        {
            return "-Registration Number " + _registrationNumber +
                " -Activity Name " + _activityName +
                " -Activity Date " + _activityDate +
                " -Activity Type " + _activityType +
                " -Revenue " + _revenue;
        }

        public string RegistrationNumber
        {
            get { return _registrationNumber; }
            set { _registrationNumber = value; }
        }

        public string ActivityName
        {
            get { return _activityName; }
            set { _activityName = value; }
        }

        public DateTime ActivityDate
        {
            get { return _activityDate; }
            set { _activityDate = value; }
        }

        public string ActivityType
        {
            get { return _activityType; }
            set { _activityType = value; }
        }

        public decimal Revenue
        {
            get { return _revenue; }
            set { _revenue = value; }
        }
    }
}
