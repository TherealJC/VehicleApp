﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAppLibrary
{
    public interface IDataConnection
    {
        VehicleModel CreateVehicle(VehicleModel model);
    }
}
