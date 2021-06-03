using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAppLibrary
{
    public class TextConnector : IDataConnection
    {
        /// <summary>
        /// Saves the Vehicle to a Text File
        /// </summary>
        /// <param name="model"> The Vehicle Information </param>
        /// <returns> The Vehicle Information, including Registration </returns>
        public VehicleModel CreateVehicle(VehicleModel model)
        {
            return model;
        }
    }
}
