using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
