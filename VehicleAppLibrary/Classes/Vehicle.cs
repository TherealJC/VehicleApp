using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAppLibrary
{
    /// <summary>
    /// This class contains the static values for any Vehicle, Vehicle objects are created with these attributes
    /// </summary>
    public struct Vehicle
    {
        public string RegistrationNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal DailyHireCost { get; set; }

        public string FullVehicleDetails
        {
            get
            {
                return $"{ RegistrationNumber } { Make }  { Model }  { Year }  { DailyHireCost }";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="registrationNumber">The registration number of the Vehicle object, only 6 characters allowed</param>
        /// <param name="make">The make of the Vehicle object e.g. BMW</param>
        /// <param name="model">The model of the Vehicle e.g. 320i</param>
        /// <param name="year">The year that the Vehicle was made</param>
        /// <param name="dailyHireCost">The cost to hire the Vehicle per day</param>
        public Vehicle(string registrationNumber, string make, string model, string year, string dailyHireCost)
        {
            RegistrationNumber = registrationNumber;
            Make = make;
            Model = model;

            int vehicleYearValue = 0; //convert string to int
            int.TryParse(year, out vehicleYearValue);
            Year = vehicleYearValue;

            decimal dailyHireCostValue = 0; //convert string to decimal
            decimal.TryParse(dailyHireCost, out dailyHireCostValue);
            DailyHireCost = dailyHireCostValue;
        }
    }
}
