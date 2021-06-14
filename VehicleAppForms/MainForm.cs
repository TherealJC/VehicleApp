using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleAppLibrary;

namespace VehicleAppForms
{
    public partial class MainForm : Form
    {
        private CreateVehicleForm _createVehicleForm = new CreateVehicleForm();

        /// <summary>
        /// Registration Number List, displays all of the Vehicles in Inventory (the textfile database).
        /// </summary>
        private List<VehicleModel> vehicleInventory = GlobalConfig.Connection.GetVehicle_All();

        /// <summary>
        /// Quick view list, displays highlighted registration numbers Vehicle details
        /// </summary>
         private List<VehicleModel> selectedVehicle = GlobalConfig.Connection.GetVehicle_All();

        public MainForm()
        {
            InitializeComponent();

            //createSampleData();

            ConnectLists();
        }

        private void createSampleData()
        {
            vehicleInventory.Add(new VehicleModel { RegistrationNumber = "RLTD01", Make = "Registration1", Model = "Test1", Year = 1111, DailyHireCost = 99 });
            vehicleInventory.Add(new VehicleModel { RegistrationNumber = "RLTD02", Make = "Registration2", Model = "Test2", Year = 2222, DailyHireCost = 1000 });


            selectedVehicle.Add(new VehicleModel { RegistrationNumber = "RLTD01", Make = "Registration1", Model = "Test1", Year = 1111, DailyHireCost = 99 });
            selectedVehicle.Add(new VehicleModel { RegistrationNumber = "RLTD02", Make = "Registration2", Model = "Test2", Year = 2222, DailyHireCost = 1000 });
        }

        private void ConnectLists()
        {
            lst_registration.DataSource = null;
            lst_registration.DataSource = vehicleInventory;
            lst_registration.DisplayMember = "RegistrationNumber";
            lst_registration.Refresh();

            lst_quickView.DataSource = null;
            lst_quickView.DataSource = vehicleInventory;
            lst_quickView.DisplayMember = "FullVehicleDetails";
            lst_quickView.Refresh();

        }

        private void btn_createVehicle_Click(object sender, EventArgs e)
        {
            _createVehicleForm.ShowDialog();
        }

        private void lst_registration_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_deleteVehicle_Click(object sender, EventArgs e)
        {
            VehicleModel v = (VehicleModel)lst_registration.SelectedItem;

            if (v != null)
            vehicleInventory.Remove(v);

            ConnectLists();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ConnectLists(); //Call the function to connect List Box to Data source/display member
        }
    }
}
