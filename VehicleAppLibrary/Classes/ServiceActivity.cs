using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAppLibrary.Models
{
    public class ServiceActivityModel
    {
        public string RegistrationNumber { get; set; }
        public string ServiceActivityName { get; set; }
        public DateTime ServiceDate { get; set; }
        public string Description { get; set; }
        public decimal ServiceCost { get; set; }
    }
}
