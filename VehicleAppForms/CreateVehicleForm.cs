using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleAppLibrary;

namespace VehicleAppForms
{
    public partial class CreateVehicleForm : Form
    {

        public CreateVehicleForm()
        {
            InitializeComponent();
        }

        //Set the events for when a user clicks on 'Add Vehicle' button
        private void btn_addVehicle_Click(object sender, EventArgs e)
        {
            if (ValidateForm())    //If the validation has succeeded e.g. no improper data input
            {
                VehicleModel model = new VehicleModel(  //Create the vehicle model from user input
                    txt_registrationNumber.Text,
                    txt_make.Text,
                    txt_model.Text,
                    txt_year.Text,
                    txt_dailyHireCost.Text);

                //for each db connection (allows it to be saved to both sql and a textFile)
                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreateVehicle(model); //Create vehicle model.
                }

                //Clear the forms textbox values.
                txt_registrationNumber.Text = "";
                txt_make.Text = "";
                txt_model.Text = "";
                txt_year.Text = "";
                txt_dailyHireCost.Text = "";

                //Display successful data entry message
                MessageBox.Show("The Vehicle has been successfully added to the SQL Database");
            }
            else
            {
                //When Validator is not true, e.g improper data format, return the error message
                MessageBox.Show("This Form has invalid or missing information, Please check it and try again");
            }

        }

        //Validate the user's input data against these rules
        private bool ValidateForm()
        {
            bool output = true;
            decimal dailyHireCost = 0;
            bool dailyHireCostValidNumber = decimal.TryParse(txt_dailyHireCost.Text, out dailyHireCost);

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

            if (txt_year.Text.Length == 0) //Check Year
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
