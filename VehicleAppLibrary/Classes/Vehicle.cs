// Vehicle has been set as a struct, structs can be used to hold small data values that do not require inheritance 
// e.g. key-value pairs, and complex data structure. This suits what we need for the 'Vehicle'

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

        /// <summary>
        /// Used in CreateVehicleForm for creating a Vehicle from users input, convert input strings to actual values (int/decimal)
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

            int.TryParse(year, out int vehicleYearValue);
            Year = vehicleYearValue;

            decimal.TryParse(dailyHireCost, out decimal dailyHireCostValue);
            DailyHireCost = dailyHireCostValue;
        }
    }
}
