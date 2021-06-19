using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAppLibrary
{
    public abstract class Activity
    {
        public string RegistrationNumber { get; set; }

        public abstract string SaveString();

        protected enum ActivityType
        {
            Error,
            Hiring,
            Service,
            Relocation
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
                case ActivityType.Relocation:
                    Activity b = new RelocationActivity();
                    b.LoadFromColumns(columns);
                    return b;
                case ActivityType.Service:
                    Activity c = new ServiceActivity();
                    c.LoadFromColumns(columns);
                    return c;
                default:
                    return null;
                    break;

            }
        }

        protected virtual void LoadFromColumns(string[] columns)
        {
            RegistrationNumber = columns[1];
        }
    }
}
