using System;
using System.Windows.Forms;
using VehicleAppLibrary;

namespace VehicleAppForms
{
    public partial class ServiceActivityForm : Form, IActivityForm
    {
        private Activity _currentActivity;

        private string _resultMessage = ("The Service Activity has been successfully added to the database");
        private string _errorMessage = ("This Form has invalid or missing information, Please check it and try again");

        public ServiceActivityForm()
        {
            InitializeComponent();
        }

        public Activity ShowCreate() // For showing or creating a new activity
        {
            Txt_ActivityID.Text = DataAccess.GetNextActivityID().ToString();
            ShowDialog();
            return _currentActivity;
        }

        public Activity ShowEdit(ServiceActivity activity) // For opening an existing activity to edit
        {
            FillForm(activity);
            ShowDialog();
            return _currentActivity;
        }

        private void FillForm(ServiceActivity activity) // Fill the 'Edit' form with the selected activities values
        {
            Txt_ActivityID.Text = activity.ActivityID.ToString();
            Txt_ActivityName.Text = activity.ActivityName;
            Dtp_ServiceDate.Value = activity.ServiceDate;
            Txt_Description.Text = activity.Description;
            Txt_ServiceCost.Text = activity.Cost.ToString();

            Btn_SubmitActivity.Text = "Update Activity"; // Update the form to edit/update instead of create
            Text = "Edit Service Activity";
            _resultMessage = "Vehicles service activity entry has been updated successfully";
        }

        private void Btn_SubmitActivity_Click(object sender, EventArgs e) // Submit activity button event
        {
            if (ValidateForm())
            {
                _currentActivity = new ServiceActivity() // sets activity to service activity
                {
                    ActivityID = int.Parse(Txt_ActivityID.Text),
                    RegistrationNumber = MainForm.SelectedVehicle.RegistrationNumber,
                    ActivityName = Txt_ActivityName.Text,
                    ServiceDate = Dtp_ServiceDate.Value,
                    Description = Txt_Description.Text,
                    Cost = decimal.Parse(Txt_ServiceCost.Text)
                };

                MessageBox.Show(_resultMessage); //If validation succeeds, show success message
                DialogResult = DialogResult.OK;  // Closes the form, activity is created
            }
            else
            {
                MessageBox.Show(_errorMessage);
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            _ = decimal.TryParse(Txt_ServiceCost.Text, out decimal serviceCost); //Convert entered text to a Decimal, allows for validation

            if (Txt_ActivityName.Text.Length == 0)
            {
                output = false;
                _errorMessage = "Please enter a valid activity name";
            }

            if (Txt_Description.Text.Length == 0)
            {
                output = false;
                _errorMessage = "Please enter a valid description for this service";
            }

            if (serviceCost <= 0)
            {
                output = false;
                _errorMessage = "Please enter a valid cost for this service (more than 0)";
            }

            return output;
        }
    }
}