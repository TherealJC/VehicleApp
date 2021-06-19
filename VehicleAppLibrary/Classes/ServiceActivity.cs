using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAppLibrary
{
    public class ServiceActivityModel : Activity
    {
        public string ServiceActivityName { get; set; }
        public DateTime ServiceDate { get; set; }
        public string Description { get; set; }
        public decimal ServiceCost { get; set; }

        public override string SaveString()
        {
            return $"{ActivityType.Service},{RegistrationNumber},{ServiceActivityName},{ServiceDate},{Description},{ServiceCost}";
        }
    }
}
