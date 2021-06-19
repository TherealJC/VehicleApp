using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAppLibrary
{
    public class ServiceActivity : Activity
    {
        public string ServiceActivityName { get; set; }
        public DateTime ServiceDate { get; set; }
        public string Description { get; set; }
        public decimal ServiceCost { get; set; }

        public override string SaveString()
        {
            return $"{ActivityType.Service},{RegistrationNumber},{ServiceActivityName},{ServiceDate},{Description},{ServiceCost}";
        }

        protected override void LoadFromColumns(string[] columns)
        {
            base.LoadFromColumns(columns);
            ServiceActivityName = columns[2];
            ServiceDate = DateTime.Parse(columns[3]);
            Description = (columns[4]);
            ServiceCost = Decimal.Parse(columns[5]);

        }
    }
}
