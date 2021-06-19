using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace VehicleAppLibrary
{
    public static class TextConnectorProcessor
    {
        /// <summary>
        ///  //go to app settings, find matching key (filePath), return value, 
        ///  then append the specified filepath (VehicleModels.csv) to the end of it.
        /// </summary>
        /// <param name="fileName">Name of the Text File</param>
        /// <returns>A string of the Full filepaths location</returns>
        public static string FullFilePath(this string fileName)
        {                                              //escape '\', then escape the escape '\'.
            return $@"{ConfigurationManager.AppSettings["filePath"]}\{fileName}";
        }

        /// <summary>
        /// Load the textfile, read all lines, create a list of all current models.
        /// If file does not exist, create a new List<string>
        /// </summary>
        /// <param name="file"></param>
        /// <returns>A list of all rows/entries in the text file</returns>
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))  //If file does not exist
            {
                return new List<string>(); //create a new list of string.
            }
            return File.ReadAllLines(file).ToList(); //read all lines, convert to a list
        }


        /// <summary>
        /// Takes in a List of <strings> called 'lines' , 
        /// 'this List<string>' is created when the LoadFile function is run,
        /// This method then converts the lines to a List of <VehicleModel>.
        /// </summary>
        /// <param name="lines">A list of strings from the texfile</param>
        /// <returns>A list of VehicleModel created from the lines in the textfile</returns>
        public static List<Vehicle> ConvertToVehicleModel(this List<string> lines)
        {
            List<Vehicle> output = new List<Vehicle>();

            foreach (string line in lines)
            {
                string[] columns = line.Split(','); //Split/Separate entries(rows) by commas

                Vehicle v = new Vehicle();   //Add the vehicles attributes
                v.RegistrationNumber = columns[0];
                v.Make = columns[1];
                v.Model = columns[2];
                v.Year = int.Parse(columns[3]);
                v.DailyHireCost = decimal.Parse(columns[4]);
                output.Add(v);  //Add vehicle values to output
            }

            //get properties

            return output; //return output (list of vehicle)
        }
    }
}
