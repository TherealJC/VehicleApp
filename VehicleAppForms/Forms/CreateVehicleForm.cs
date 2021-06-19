using System;
using System.Windows.Forms;
using VehicleAppLibrary;

namespace VehicleAppForms
{
    public partial class CreateVehicleForm : Form
    {
        string resultMessage = ("The Vehicle has been successfully added to the TextFile Inventory");

        private Vehicle vehicle;
        private CreateVehicleForm()
        {
            InitializeComponent();
        }

        //Takes a Vehicle and fills in the tex boxes
        private void FillForm(Vehicle vm)
        {
            txt_registrationNumber.Enabled = false;

            txt_registrationNumber.Text = vm.RegistrationNumber;
            txt_make.Text = vm.Make;
            txt_model.Text = vm.Model;
            txt_year.Text = vm.Year.ToString();
            txt_dailyHireCost.Text = vm.DailyHireCost.ToString();

            btn_addVehicle.Text = "Update Vehicle";
            Text = "Edit Vehicle";
            resultMessage = "Vehicle entry has been updated successfully";
        }

        //Creates a new form with empty text boxes and creates a Vehicle
        public static Vehicle? ShowCreate()
        {
            CreateVehicleForm form = new CreateVehicleForm();
            DialogResult dr = form.ShowDialog();
            return dr == DialogResult.OK ? new Vehicle?(form.vehicle) : null;
        }

        //Creates a new form, fills it with the selected vehicle attributes
        public static Vehicle? ShowEdit(Vehicle vm)
        {
            CreateVehicleForm form = new CreateVehicleForm();
            form.FillForm(vm);
            DialogResult dr = form.ShowDialog();
            return dr == DialogResult.OK ? new Vehicle?(form.vehicle) : null;
        }


        //Set the events for when a user clicks on 'Add Vehicle' button
        private void btn_addVehicle_Click(object sender, EventArgs e)
        {
            if (ValidateForm())    //If the validation has succeeded e.g. no improper data input
            {
                vehicle = new Vehicle(  //Create the vehicle model from user input
                    txt_registrationNumber.Text,
                    txt_make.Text,
                    txt_model.Text,
                    txt_year.Text,
                    txt_dailyHireCost.Text);

                //Display successful data entry message
                MessageBox.Show(resultMessage);
                DialogResult = DialogResult.OK;
            }
            else
            {
                //When Validator equals not true, e.g improper data format, return the error message
                MessageBox.Show("This Form has invalid or missing information, Please check it and try again");
            }
        }

        //Validate the user's input data against these rules
        private bool ValidateForm()
        {
            bool output = true;

            decimal dailyHireCost = 0;
            bool dailyHireCostValidNumber = decimal.TryParse(txt_dailyHireCost.Text, out dailyHireCost);

            int vehicleYear = 0;
            bool vehicleYearValidNumber = int.TryParse(txt_year.Text, out vehicleYear);

            if (txt_registrationNumber.Text.Length == 0) //Check Rego #
            {
                output = false;
            }

            if (txt_model.Text.Length == 0) //Check Model
            {
                output = false;
            }

            if (txt_make.Text.Length == 0) //Check Make
            {
                output = false;
            }

            if (vehicleYear < 1) //Check Year
            {
                output = false;
            }

            if (dailyHireCost < 1) //if input value is less than 1
            {
                output = false;
            }

            return output;
        }
    }
}