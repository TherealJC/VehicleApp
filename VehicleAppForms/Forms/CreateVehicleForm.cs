// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// Author : Jamie Crowther
// Published Date : 22/06/2021

using System;
using System.Windows.Forms;
using VehicleAppLibrary;

namespace VehicleAppForms
{
    public partial class CreateVehicleForm : Form
    {
        private string _resultMessage = ("The Vehicle has been successfully added to the TextFile Inventory");
        private string _errorMessage = ("This Form has invalid or missing information, Please check it and try again");

        private Vehicle _vehicle;
        private CreateVehicleForm()
        {
            InitializeComponent();
        }

        // Takes a Vehicle and fills in the text boxes. This is used for modify/edit Vehicle
        private void FillForm(Vehicle vm)
        {
            Txt_RegistrationNumber.Enabled = false;

            Txt_RegistrationNumber.Text = vm.RegistrationNumber;
            Txt_Make.Text = vm.Make;
            Txt_Model.Text = vm.Model;
            Txt_Year.Text = vm.Year.ToString();
            Txt_DailyHireCost.Text = vm.DailyHireCost.ToString();

            Btn_AddVehicle.Text = "Update Vehicle";
            Text = "Edit Vehicle";
            _resultMessage = "Vehicle entry has been updated successfully";
        }

        // Creates a new form with empty text boxes and creates a Vehicle
        public static Vehicle? ShowCreate() //Nullable type, but we know it will always be a Vehicle
        {
            CreateVehicleForm form = new CreateVehicleForm();
            DialogResult dr = form.ShowDialog();
            return dr == DialogResult.OK ? new Vehicle?(form._vehicle) : null;
        }

        // Creates a new form, fills it with the selected vehicle attributes
        public static Vehicle? ShowEdit(Vehicle vm)
        {
            CreateVehicleForm form = new CreateVehicleForm();
            form.FillForm(vm);
            DialogResult dr = form.ShowDialog();
            return dr == DialogResult.OK ? new Vehicle?(form._vehicle) : null;
        }


        // Set the events for when a user clicks on 'Add Vehicle' button
        private void Btn_AddVehicle_Click(object sender, EventArgs e)
        {
            if (ValidateForm())    // If the validation has succeeded e.g. no improper data input
            {
                _vehicle = new Vehicle(  // Create a new vehicle from user input
                    Txt_RegistrationNumber.Text,
                    Txt_Make.Text,
                    Txt_Model.Text,
                    Txt_Year.Text,
                    Txt_DailyHireCost.Text);

                // Display successful data entry message
                MessageBox.Show(_resultMessage);
                DialogResult = DialogResult.OK;
            }
            else
            {
                // When Validator equals not true, e.g improper data format, return the error message
                MessageBox.Show(_errorMessage);
            }
        }

        // Validate the user's input data against these rules
        private bool ValidateForm()
        {
            bool output = true;

            if (Txt_RegistrationNumber.Enabled) // If on the Create Vehicle Form, (Txt_RegistrationNumber is disabled on the Edit version of the form).
            {
                if (DataAccess.CheckVehicleExists(Txt_RegistrationNumber.Text)) //Check if registration number exists
                {
                    output = false;
                    _errorMessage = ("ERROR: A vehicle with this registration number already exists");
                }
            }

            _ = decimal.TryParse(Txt_DailyHireCost.Text, out decimal dailyHireCost);
            _ = int.TryParse(Txt_Year.Text, out int vehicleYear);

            if (Txt_RegistrationNumber.Text.Length <= 5) // Check Rego #
            {
                output = false;
                _errorMessage = ("Please enter a registration number for the Vehicle (A registration number must be 6 characters)");
            }

            if (Txt_Model.Text.Length == 0) // Check Model
            {
                output = false;
                _errorMessage = ("Please enter a Model for the Vehicle");
            }

            if (Txt_Make.Text.Length == 0) // Check Make
            {
                output = false;
                _errorMessage = ("Please enter a Make for the Vehicle");
            }

            if (vehicleYear < 1800) // Check Year greather than 1800
            {
                output = false;
                _errorMessage = ("Please enter The Year that the Vehicle was made (Cannot be more than 200 years ago)");
            }

            if (vehicleYear >= 2022) // Check Year less than 2022
            {
                output = false;
                _errorMessage = ("Please enter a valid Year for the Vehicle (Vehicle cannot exist before its creation date)");
            }

            if (dailyHireCost < 1) // if input value is less than 1
            {
                output = false;
                _errorMessage = "Please enter the daily hiring cost for this vehicle (Must be more than 0)";
            }

            return output;
        }
    }
}