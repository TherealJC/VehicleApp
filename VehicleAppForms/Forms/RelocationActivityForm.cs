using System;
using System.Windows.Forms;
using VehicleAppLibrary;

namespace VehicleAppForms
{
    public partial class RelocationActivityForm : Form, IActivityForm
    {
        private Activity _currentActivity;

        private string _resultMessage = ("The Relocation Activity has been successfully added to the database");
        private string _errorMessage = ("This Form has invalid or missing information, Please check it and try again");

        public RelocationActivityForm()
        {
            InitializeComponent();
        }

        public Activity ShowCreate() // For showing or creating a new activity
        {
            Txt_ActivityID.Text = DataAccess.GetNextActivityID().ToString();
            ShowDialog();
            return _currentActivity;
        }

        public Activity ShowEdit(RelocationActivity activity) // For opening a form to edit the selected activity
        {
            FillForm(activity);
            ShowDialog();
            return _currentActivity;
        }

        private void FillForm(RelocationActivity activity) // Fills the form with the selected activities values
        {
            Txt_ActivityID.Text = activity.ActivityID.ToString();
            Txt_ActivityName.Text = activity.ActivityName;
            Dtp_RelocationDate.Value = activity.RelocationDate;
            Txt_KmsUsed.Text = activity.KmsUsed.ToString();
            Txt_RelocationCost.Text = activity.Cost.ToString();

            Btn_SubmitActivity.Text = "Update Activity";
            Text = "Edit Relocation Activity";
            _resultMessage = "Vehicles relocation activity entry has been updated successfully";
        }

        private void Btn_SubmitActivity_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                _currentActivity = new RelocationActivity()
                {
                    ActivityID = int.Parse(Txt_ActivityID.Text),
                    RegistrationNumber = MainForm.SelectedVehicle.RegistrationNumber,
                    ActivityName = Txt_ActivityName.Text,
                    RelocationDate = Dtp_RelocationDate.Value,
                    KmsUsed = int.Parse(Txt_KmsUsed.Text),
                    Cost = decimal.Parse(Txt_RelocationCost.Text)
                };

                MessageBox.Show(_resultMessage);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(_errorMessage);
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            _ = decimal.TryParse(Txt_RelocationCost.Text, out decimal relocationCost); //Used to check if relocation cost is valid

            _ = int.TryParse(Txt_KmsUsed.Text, out int kmCheck); //Used to check if KmsUsed is correct

            if (Txt_ActivityName.Text.Length == 0)
            {
                output = false;
                _errorMessage = "Please enter a valid activity name";
            }

            if (kmCheck <= 0)
            {
                output = false;
                _errorMessage = "Please enter a valid Kilometre amount";
            }

            if (relocationCost <= 0)
            {
                output = false;
                _errorMessage = "Please enter a valid cost (more than 0)";
            }

            return output;
        }
    }
}
