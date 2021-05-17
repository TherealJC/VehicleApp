using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT601_Project
{
    public class Vehicle
    {
        private string _registrationNumber;
        private string _make;
        private string _model;
        private decimal _dailyHireCost;
        private decimal _revenue;

        public override string ToString()
        {
            return "-Registration Number " + _registrationNumber +
                " -Make " + _make +
                " -Model " + Model +
                " -Daily Hire Cost " + _dailyHireCost +
                " -Revenue " + Revenue;
        }

        public string RegistrationNumber
        {
            get { return _registrationNumber; } 
            set { _registrationNumber = value; }
        }

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public decimal DailyHireCost
        {
            get { return _dailyHireCost; }
            set { _dailyHireCost = value; }
        }

        public decimal Revenue
        {
            get { return _revenue; }
            set { _revenue = value; }
        }
    }
}
