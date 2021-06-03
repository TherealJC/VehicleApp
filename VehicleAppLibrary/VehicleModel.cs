using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAppLibrary
{
    public class VehicleModel
    {
        public string RegistrationNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public decimal DailyHireCost { get; set; }

        public VehicleModel()
        {

        }

        public VehicleModel(string registrationNumber, string make, string model, string year, string dailyHireCost)
        {
            RegistrationNumber = registrationNumber;
            Make = make;
            Model = model;
            Year = year;

            decimal dailyHireCostValue = 0;
            decimal.TryParse(dailyHireCost, out dailyHireCostValue);
            DailyHireCost = dailyHireCostValue;
        }
    }
}
