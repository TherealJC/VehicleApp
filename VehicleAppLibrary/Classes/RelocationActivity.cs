using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAppLibrary
{
    public class RelocationActivity : Activity
    {
        public DateTime RelocationDate { get; set; }
        public int KmsUsed { get; set; }

        public override string SaveString()
        {
            return $"{(int)ActivityType.Relocation},{ActivityID},{RegistrationNumber},{ActivityName},{Cost},{RelocationDate},{KmsUsed}";
        }
        protected override void LoadFromColumns(string[] columns)
        {
            base.LoadFromColumns(columns);
            int startingPoint = 5;
            RelocationDate = DateTime.Parse(columns[startingPoint++]);
            KmsUsed = int.Parse(columns[startingPoint++]);
        }

        public override string ToString()
        {
            return $"{ActivityType.Relocation} | Activity Name: {ActivityName}  |  Relocation Date: {RelocationDate.ToShortDateString()} | Kms Used: {KmsUsed} |  Cost: {Cost}";
        }

        public override DateTime GetDate()
        {
            return RelocationDate;
        }

        public override decimal GetTotalRevenue()
        {
            return -Cost;
        }
    }
}
