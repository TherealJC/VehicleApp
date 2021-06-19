﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAppLibrary
{
    class RelocationActivity : Activity
    {
        public string RelocationActivityName { get; set; }
        public DateTime RelocationDate { get; set; }
        public int KmsUsed { get; set; }
        public decimal RelocationCost { get; set; }

        public override string SaveString()
        {
            return $"{ActivityType.Relocation},{RegistrationNumber},{RelocationActivityName},{RelocationDate},{KmsUsed},{RelocationCost}";
        }

    }
}
