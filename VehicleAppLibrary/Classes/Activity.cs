using System;

namespace VehicleAppLibrary
{
    public abstract class Activity
    {
        public int ActivityID { get; set; }
        public string RegistrationNumber { get; set; }
        public string ActivityName { get; set; }
        public decimal Cost { get; set; }

        public abstract string SaveString(); //Gets overridden by sub classes with activity values

        public enum ActivityType //Used for GetActivityType, Lists each type of activity (plus Error at 0/default)
        {
            Error,
            Hiring,
            Service,
            Relocation
        }

        public abstract decimal GetTotalRevenue(); //Calculates the vehicle revenue, each activity type overrides this with the cost upon creation

        public static ActivityType GetActivityType(Activity activity) //Adds an activity type attribute (depending on which activity form has been selected)
        {
            switch(activity)
            {
                case HiringActivity a: return ActivityType.Hiring; //If activity is HiringActivity, ActivityType = Hiring
                case ServiceActivity b: return ActivityType.Service; //If activity is ServiceActivity, ActivityType = Service
                case RelocationActivity c: return ActivityType.Relocation; //If activity is RelocationActivity, ActivityType = Relocation
                default: return ActivityType.Error; //Otherwise (should not be able to get here) activity type = Error
            }
        }

        public static Activity LoadFromString(string line) //Used to load an activity from a string (how it's stored in the list)
        {
            string[] columns = line.Split(','); //Reads the string, and sets each column equal to the strings value separated by a comma

            int.TryParse(columns[0], out int activityType); //Get the activity type

            switch ((ActivityType)activityType) //Compare ActivityType to activityType
            {
                case ActivityType.Hiring:
                    Activity a = new HiringActivity(); //if ActivityType = Hiring, create new HiringActivity
                    a.LoadFromColumns(columns);  //Load common activity values from the columns made in this method
                    return a;
                case ActivityType.Service:
                    Activity b = new ServiceActivity(); //if ActivityType = Service, create new ServiceActivity
                    b.LoadFromColumns(columns);
                    return b;
                case ActivityType.Relocation:
                    Activity c = new RelocationActivity(); //if ActivityType = Relocation, create new RelocationActivity
                    c.LoadFromColumns(columns);
                    return c;
                default:
                    return null;
            }
        }

        protected virtual void LoadFromColumns(string[] columns) //Used to make columns equal values from loaded Activity string (from csv file)
        {
            ActivityID = int.Parse(columns[1]);
            RegistrationNumber = columns[2];
            ActivityName = columns[3];
            Cost = decimal.Parse(columns[4]);
        }

        public abstract DateTime GetDate(); //used in sub-classes (override)
    }
}
