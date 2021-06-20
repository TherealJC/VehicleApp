using System;
using System.Windows.Forms;
using VehicleAppLibrary;

namespace VehicleAppForms
{
    public partial class RelocationActivityForm : Form, IActivityForm
    {
        Activity currentActivity;
        private string resultMessage = ("The Relocation Activity has been successfully added to the database");

        public RelocationActivityForm()
        {
            InitializeComponent();
        }

        public Activity ShowCreate()
        {
            txt_activityID.Text = DataAccess.GetNextActivityID().ToString();
            ShowDialog();
            return currentActivity;
        }

        public Activity ShowEdit(RelocationActivity activity)
        {
            FillForm(activity);
            ShowDialog();
            return currentActivity;
        }

        private void FillForm(RelocationActivity activity)
        {
            txt_activityID.Text = activity.ActivityID.ToString();
            txt_activityName.Text = activity.ActivityName;
            dtp_relocationDate.Value = activity.RelocationDate;
            txt_kmsUsed.Text = activity.KmsUsed.ToString();
            txt_relocationCost.Text = activity.Cost.ToString();

            btn_submitActivity.Text = "Update Activity";
            Text = "Edit Relocation Activity";
            resultMessage = "Vehicles relocation activity entry has been updated successfully";
        }

        private void btn_submitActivity_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                currentActivity = new RelocationActivity()
                {
                    ActivityID = int.Parse(txt_activityID.Text),
                    RegistrationNumber = MainForm.SelectedVehicle.RegistrationNumber,
                    ActivityName = txt_activityName.Text,
                    RelocationDate = dtp_relocationDate.Value,
                    KmsUsed = int.Parse(txt_kmsUsed.Text),
                    Cost = decimal.Parse(txt_relocationCost.Text)
                };

                MessageBox.Show(resultMessage);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("This Form has invalid or missing information, Please check it and try again");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            decimal relocationCost = 0;
            bool hiringCostValidNumber = decimal.TryParse(txt_relocationCost.Text, out relocationCost);

            int kmCheck = 0;
            bool kmCheckIfValid = int.TryParse(txt_kmsUsed.Text, out kmCheck);

            if (txt_activityName.Text.Length == 0)
            {
                output = false;
            }

            if (kmCheck <= 0)
            {
                output = false;
            }

            if (relocationCost <= 0)
            {
                output = false;
            }

            return output;
        }
    }
}
