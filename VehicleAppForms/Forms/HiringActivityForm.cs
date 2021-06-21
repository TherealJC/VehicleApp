﻿using System;
using System.Windows.Forms;
using VehicleAppLibrary;

namespace VehicleAppForms
{
    public partial class HiringActivityForm : Form, IActivityForm
    {
        Activity currentActivity;

        private string _resultMessage = ("The Hiring Activity has been successfully added to the database");
        private string _errorMessage = ("This Form has invalid or missing information, Please check it and try again");

        public HiringActivityForm()
        {
            InitializeComponent();
        }

        public Activity ShowCreate() // For showing or creating a new activity
        {
            Txt_ActivityID.Text = DataAccess.GetNextActivityID().ToString();
            ShowDialog();
            return currentActivity;
        }

        public Activity ShowEdit(HiringActivity activity) // For opening a form to edit selected activity
        {
            FillForm(activity);
            ShowDialog();
            return currentActivity;
        }

        private void FillForm(HiringActivity activity) // Fill form textboxes with selected activities values
        {
            Txt_ActivityID.Text = activity.ActivityID.ToString();
            Txt_ActivityName.Text = activity.ActivityName;
            Txt_CustomerName.Text = activity.CustomerName;
            Dtp_StartDate.Value = activity.StartDate;
            Dtp_EndDate.Value = activity.EndDate;
            Txt_HiringCost.Text = activity.Cost.ToString();

            Btn_SubmitActivity.Text = "Update Activity";
            Text = "Edit Hiring Activity";
            _resultMessage = "Vehicles hiring activity entry has been updated successfully";
        }

        private void Btn_SubmitActivity_Click(object sender, EventArgs e)
        {
            if (ValidateForm()) // If validate form returns true
            {
                currentActivity = new HiringActivity() //create new hiring activity from input
                {
                   ActivityID = int.Parse(Txt_ActivityID.Text),
                   RegistrationNumber = MainForm.SelectedVehicle.RegistrationNumber, //Get Vehicles registration number from main forms selected Vehicle
                   ActivityName = Txt_ActivityName.Text,
                   CustomerName = Txt_CustomerName.Text,
                   StartDate = Dtp_StartDate.Value,
                   EndDate = Dtp_EndDate.Value,
                   Cost = decimal.Parse(Txt_HiringCost.Text)
                };

                MessageBox.Show(_resultMessage); //Successful activity addition
                DialogResult = DialogResult.OK;
            }

            else //If the validator fails/returns false
            {
                MessageBox.Show(_errorMessage);
            }
        }

        //Validate the input fields
        private bool ValidateForm()
        {
            bool output = true; // start at true, if any validation fails, return false

            //Discards are local variables which you can assign but cannot read from. i.e. they are “write-only”
            _ = decimal.TryParse(Txt_HiringCost.Text, out decimal hiringCost);

            if (Txt_ActivityName.Text.Length == 0)
            {
                output = false; //If no text has been entered in the Activity Name field
                _errorMessage = ("Please enter a Name for the activity");
            }

            if (Txt_CustomerName.Text.Length == 0) //If no text has been entered in the Customer Name field
            {
                output = false;
                _errorMessage = ("Please enter the Customer for this activity");
            }

            if (hiringCost <= 0)
            {
                output = false; //If no hiring costs is entered, or if entered cost is less than, or equal to 0
                _errorMessage = ("Please enter a valid cost (more than zero)");
            }

            return output; //return output (which = true, as set at the start of the method)
        }
    }
}
