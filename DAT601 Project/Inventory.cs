using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT601_Project
{
    public class Inventory
    {
        public List<Vehicle> VehicleList { get; set; }

        public Inventory()
        {
            VehicleList = new List<Vehicle>();
        }

        public decimal totalRevenue()
        {
            //Set starting cost
        decimal totalCost = 0;

            foreach (var a in VehicleList)
            {
                totalCost += a.Revenue;
            }

            return totalCost;
        }
    }
}
