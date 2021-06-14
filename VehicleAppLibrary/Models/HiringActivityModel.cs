using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAppLibrary.Models
{
    public class HiringActivityModel
    {
        public string RegistrationNumber { get; set; }
        public string HiringActivityName { get; set; }
        public string CustomerName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal HiringCost { get; set; }
    }
}
