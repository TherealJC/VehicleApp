using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAppLibrary
{
    public class SqlConnector : IDataConnection
    {
        /// <summary>
        /// Saves a new Vehicle to the Database
        /// </summary>
        /// <param name="model"> The Vehicle Information </param>
        /// <returns>The Vehicle Information, including Registration</returns>
        public VehicleModel CreateVehicle(VehicleModel model) //must follow the Interface contract
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("VehicleApp")))
            {
                var p = new DynamicParameters();
                p.Add("@RegistrationNumber", model.RegistrationNumber);
                p.Add("@Make", model.Make);
                p.Add("@Model", model.Model);
                p.Add("@Year", model.Year);
                p.Add("@DailyHireCost", model.DailyHireCost);

                connection.Execute("dbo.spVehicles_Insert" , p , commandType: CommandType.StoredProcedure);

                return model;
            }
        }
    }
}