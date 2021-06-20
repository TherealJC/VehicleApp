using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAppLibrary
{
    public class HiringActivity : Activity
    {
        public string CustomerName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public override string SaveString()
        {
            return $"{(int)ActivityType.Hiring},{ActivityID},{RegistrationNumber},{ActivityName},{Cost},{CustomerName},{StartDate},{EndDate}";
        }

        protected override void LoadFromColumns(string[] columns)
        {
            base.LoadFromColumns(columns);
            int startingPoint = 5;
            CustomerName = columns[startingPoint++];
            StartDate = DateTime.Parse(columns[startingPoint++]);
            EndDate = DateTime.Parse(columns[startingPoint++]);
        }

        public override string ToString()
        {
           return $"{ActivityType.Hiring} | Activity Name: {ActivityName}  |  Customer: {CustomerName} | Start Date: {StartDate.ToShortDateString()} | End Date: {EndDate.ToShortDateString()}  |  Cost: {Cost}";
        }
        public override DateTime GetDate()
        {
            return StartDate;
        }

        public override decimal GetTotalRevenue()
        {
            return Cost;
        }
    }
}
