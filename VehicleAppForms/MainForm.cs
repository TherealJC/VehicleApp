using System;
using System.Windows.Forms;
using VehicleAppLibrary;

namespace VehicleAppForms
{
    public partial class MainForm : Form
    {
        //Singleton instance
        public static readonly MainForm Instance = new MainForm();

        //gets selected vehicle of the singleton instance
        public static Vehicle SelectedVehicle => (Vehicle)Instance.Lst_Registration.SelectedItem;
        private MainForm()
        {
            InitializeComponent();

            ConnectLists();
        }

        private void ConnectLists() // Used to connect listboxes, and to update lists upon new data entry
        {
            Lst_Registration.DataSource = null;
            Lst_Registration.DataSource = DataAccess.VehicleInventory;
            Lst_Registration.DisplayMember = "RegistrationNumber";

            decimal total = 0;
            foreach (Activity a in DataAccess.LoadActivityModels())
            {
                total += a.GetTotalRevenue(); //Calculate the total revenue of all saved vehicles/activities
            }

            Lbl_DisplayTotalRevenue.Text = total.ToString(); // Display the total revenue
        }


        private void Btn_CreateVehicle_Click(object sender, EventArgs e) // Create Vehicle click event
        {
            //The is expression handles the null check and creates a local variable
            if (CreateVehicleForm.ShowCreate() is Vehicle vm)
            {
                DataAccess.CreateVehicle(vm);
                ConnectLists();
            }
        }

        private void Btn_EditVehicle_Click(object sender, EventArgs e) // Edit Vehicle button event
        {
            if (Lst_Registration.SelectedItem != null)
            {
                //The is expression handles the null check and creates a local variable
                if (CreateVehicleForm.ShowEdit((Vehicle)Lst_Registration.SelectedItem) is Vehicle vm)
                {
                    DataAccess.CreateVehicle(vm);
                    ConnectLists();
                }
            }
        }

        private void Btn_DeleteVehicle_Click(object sender, EventArgs e) // Delete Vehicle button event
        {
            if (Lst_Registration.SelectedItem != null) // Makes sure a vehicle is selected
            {
                DataAccess.DeleteVehicle((Vehicle)Lst_Registration.SelectedItem); //Delete the selected vehicle
                ConnectLists(); // re-bind lists
            }
            else
            {
                MessageBox.Show("No Vehicle Selected");
            }
        }

        private void Btn_ViewActivityLog_Click(object sender, EventArgs e) // Opens the selected Vehicles activity log
        {
            new ActivityLog().ShowDialog();
            ConnectLists();
        }

        private void Lst_Registration_SelectedValueChanged(object sender, EventArgs e) //Updates Quick View values to match selected Vehicle
        {

            if (Lst_Registration.SelectedItem != null)
            {
                Vehicle vm = (Vehicle)Lst_Registration.SelectedItem;
                Txt_RegistrationNumber.Text = vm.RegistrationNumber;
                Txt_Make.Text = vm.Make;
                Txt_Model.Text = vm.Model;
                Txt_Year.Text = vm.Year.ToString();
                Txt_DailyHireCost.Text = vm.DailyHireCost.ToString();
            }

            else
            {
                Txt_RegistrationNumber.Text = "";
                Txt_Make.Text = "";
                Txt_Model.Text = "";
                Txt_Year.Text = "";
                Txt_DailyHireCost.Text = "";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ConnectLists(); //Call the function to connect List Box to Data source/display member
            Lst_Registration.Refresh();
        }

    }
}
