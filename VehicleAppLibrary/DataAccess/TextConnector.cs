using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleAppLibrary.DataAccess.TextHelpers;

namespace VehicleAppLibrary
{
    public class TextConnector : IDataConnection
    {
        //const, value will never change (pascal notation due to static const)
        private const string VehicleFile = "VehicleAppData.csv";

        /// <summary>
        /// Saves the Vehicle Model to a Text File
        /// </summary>
        /// <param name="model"> The Vehicle Values </param>
        /// <returns> The Vehicle Information, including Registration </returns>
        public VehicleModel CreateVehicle(VehicleModel model)
        {
            List<VehicleModel> vehicles = VehicleFile.FullFilePath().LoadFile().ConvertToVehicleModel(); //load the text file, convert text to List of VehicleModels

            vehicles.Add(model); //Add the new Vehicle record

            vehicles.SaveToVehicleFile(VehicleFile); //Save the list<string> to the text file

            return model;
        }
    }
}
