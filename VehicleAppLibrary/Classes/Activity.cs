using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAppLibrary
{
    public abstract class Activity
    {
        public string RegistrationNumber { get; set; }

        public abstract string SaveString();

        protected enum ActivityType
        {
            Hiring,
            Service,
            Relocation
        }
    }
}
