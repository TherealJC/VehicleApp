using System;

namespace VehicleAppLibrary
{
    public class ServiceActivity : Activity
    {
        public DateTime ServiceDate { get; set; }
        public string Description { get; set; }

        public override string SaveString()
        {
            return $"{(int)ActivityType.Service},{ActivityID},{RegistrationNumber},{ActivityName},{Cost},{ServiceDate},{Description}";
        }

        protected override void LoadFromColumns(string[] columns)
        {
            base.LoadFromColumns(columns);
            int startingPoint = 5;
            ServiceDate = DateTime.Parse(columns[startingPoint++]);
            Description = (columns[startingPoint++]);
        }

        public override string ToString()
        {
            return $"{ActivityType.Service} | Workshop: {ActivityName} |  Cost: {Cost}  |  Service Date: {ServiceDate.ToShortDateString()} | Description: {Description}";
        }

        public override DateTime GetDate()
        {
            return ServiceDate;
        }

        public override decimal GetTotalRevenue()
        {
            return -Cost;
        }
    }
}
