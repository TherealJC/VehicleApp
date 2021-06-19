using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAppLibrary
{
    public class HiringActivity : Activity
    {
        public string HiringActivityName { get; set; }
        public string CustomerName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal HiringCost { get; set; }

        public override string SaveString()
        {
            return $"{ActivityType.Hiring},{RegistrationNumber},{CustomerName},{StartDate},{EndDate},{HiringCost}";
        }
    }
}
