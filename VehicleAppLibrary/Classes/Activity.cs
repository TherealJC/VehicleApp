using System;

namespace VehicleAppLibrary
{
    public abstract class Activity
    {
        public int ActivityID { get; set; }
        public string RegistrationNumber { get; set; }
        public string ActivityName { get; set; }
        public decimal Cost { get; set; }

        public abstract string SaveString();

        public enum ActivityType
        {
            Error,
            Hiring,
            Service,
            Relocation
        }

        public abstract decimal GetTotalRevenue();

        public static ActivityType GetActivityType(Activity activity)
        {
            switch(activity)
            {
                case HiringActivity a: return ActivityType.Hiring;
                case ServiceActivity b: return ActivityType.Service;
                case RelocationActivity c: return ActivityType.Relocation;
                default: return ActivityType.Error;
            }
        }

        public static Activity LoadFromString(string line)
        {
            string[] columns = line.Split(',');
            int activityType;
            int.TryParse(columns[0], out activityType);
            switch((ActivityType)activityType)
            {
                case ActivityType.Hiring:
                    Activity a = new HiringActivity();
                    a.LoadFromColumns(columns);
                    return a;
                case ActivityType.Service:
                    Activity b = new ServiceActivity();
                    b.LoadFromColumns(columns);
                    return b;
                case ActivityType.Relocation:
                    Activity c = new RelocationActivity();
                    c.LoadFromColumns(columns);
                    return c;
                default:
                    return null;
            }
        }

        protected virtual void LoadFromColumns(string[] columns)
        {
            ActivityID = int.Parse(columns[1]);
            RegistrationNumber = columns[2];
            ActivityName = columns[3];
            Cost = decimal.Parse(columns[4]);
        }

        public abstract DateTime GetDate();
    }
}
