using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VehicleAppLibrary;

namespace VehicleAppForms
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            ConnectLists();
        }

        private void ConnectLists()
        {
            lst_registration.DataSource = null;
            lst_registration.DataSource = DataAccess.VehicleInventory;
            lst_registration.DisplayMember = "RegistrationNumber";
        }


        private void btn_createVehicle_Click(object sender, EventArgs e)
        {
            //The is expression handles the null check and creates a local variable
            if (CreateVehicleForm.ShowCreate() is Vehicle vm)
            {
                DataAccess.CreateVehicle(vm);
                ConnectLists();
            }
        }

        private void btn_editVehicle_Click(object sender, EventArgs e)
        {
            if (lst_registration.SelectedItem != null)
            {
                //The is expression handles the null check and creates a local variable
                if (CreateVehicleForm.ShowEdit((Vehicle)lst_registration.SelectedItem) is Vehicle vm)
                {
                    DataAccess.CreateVehicle(vm);
                    ConnectLists();
                }
            }
        }

        private void btn_deleteVehicle_Click(object sender, EventArgs e)
        {
            if (lst_registration.SelectedItem != null)
            {
                DataAccess.DeleteVehicle((Vehicle)lst_registration.SelectedItem);
                ConnectLists();
            }
            else
            {
                MessageBox.Show("No Vehicle Selected");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ConnectLists(); //Call the function to connect List Box to Data source/display member
            lst_registration.Refresh();
        }

        private void lst_registration_SelectedValueChanged(object sender, EventArgs e)
        {

            if (lst_registration.SelectedItem != null)
            {
                Vehicle vm = (Vehicle)lst_registration.SelectedItem;
                txt_registrationNumber.Text = vm.RegistrationNumber;
                txt_make.Text = vm.Make;
                txt_model.Text = vm.Model;
                txt_year.Text = vm.Year.ToString();
                txt_dailyHireCost.Text = vm.DailyHireCost.ToString();
            }

            else {
                txt_registrationNumber.Text = "";
                txt_make.Text = "";
                txt_model.Text = "";
                txt_year.Text = "";
                txt_dailyHireCost.Text = "";
            }
        }

        private void btn_viewActivityLog_Click(object sender, EventArgs e)
        {
            new ActivityLog().ShowDialog();
        }
    }
}
