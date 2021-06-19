using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VehicleAppLibrary;

namespace VehicleAppForms
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Registration Number List, displays all of the Vehicles in Inventory (the textfile database).
        /// </summary>
        private List<VehicleModel> vehicleInventory = TextConnector.GetVehicle_All();

        /// <summary>
        /// Quick view list, displays highlighted registration numbers Vehicle details
        /// </summary>
        private List<VehicleModel> selectedVehicle = new List<VehicleModel>();

        public MainForm()
        {
            InitializeComponent();

            //createSampleData();

            ConnectLists();
        }

        private void ConnectLists()
        {
            lst_registration.DataSource = null;
            lst_registration.DataSource = vehicleInventory;
            lst_registration.DisplayMember = "RegistrationNumber";

            lst_quickView.DataSource = null;
            lst_quickView.DataSource = vehicleInventory;
            lst_quickView.DisplayMember = "FullVehicleDetails";

        }

        private void btn_createVehicle_Click(object sender, EventArgs e)
        {
            CreateVehicleForm newCvForm = new CreateVehicleForm();
            newCvForm.ShowDialog();
            vehicleInventory = TextConnector.GetVehicle_All();
            ConnectLists();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ConnectLists(); //Call the function to connect List Box to Data source/display member
            lst_registration.Refresh();
            lst_quickView.Refresh();
        }

        // Remove Vehicle model from the Registration Numbers List
        private void btn_deleteVehicle_Click(object sender, EventArgs e)
        {
            VehicleModel v = (VehicleModel)lst_registration.SelectedItem;

            if (v != null)
            vehicleInventory.Remove(v);

            else if (v == null)
            {
                MessageBox.Show("No Vehicle Selected");
            }

            ConnectLists();
        }

        private void createSampleData()
        {
            vehicleInventory.Add(new VehicleModel { RegistrationNumber = "RLTD01", Make = "Registration1", Model = "Test1", Year = 1111, DailyHireCost = 99 });
            vehicleInventory.Add(new VehicleModel { RegistrationNumber = "RLTD02", Make = "Registration2", Model = "Test2", Year = 2222, DailyHireCost = 1000 });


            selectedVehicle.Add(new VehicleModel { RegistrationNumber = "RLTD01", Make = "Registration1", Model = "Test1", Year = 1111, DailyHireCost = 99 });
            selectedVehicle.Add(new VehicleModel { RegistrationNumber = "RLTD02", Make = "Registration2", Model = "Test2", Year = 2222, DailyHireCost = 1000 });
        }
    }
}
