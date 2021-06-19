using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAppLibrary.Models
{
    class RelocationActivity
    {
        public string RegistrationNumber { get; set; }
        public string RelocationActivityName { get; set; }
        public DateTime RelocationDate { get; set; }
        public int KmsUsed { get; set; }
        public decimal RelocationCost { get; set; }

    }
}
