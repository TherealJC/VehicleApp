using System;
using System.Windows.Forms;
using VehicleAppLibrary;

namespace VehicleAppForms
{
    public partial class ServiceActivityForm : Form, IActivityForm
    {
        Activity currentActivity;
        private string resultMessage = ("The Service Activity has been successfully added to the database");
        public ServiceActivityForm()
        {
            InitializeComponent();
        }

        public Activity ShowCreate()
        {
            txt_activityID.Text = DataAccess.GetNextActivityID().ToString();
            ShowDialog();
            return currentActivity;
        }

        public Activity ShowEdit(ServiceActivity activity)
        {
            FillForm(activity);
            ShowDialog();
            return currentActivity;
        }

        private void FillForm(ServiceActivity activity)
        {
            txt_activityID.Text = activity.ActivityID.ToString();
            txt_activityName.Text = activity.ActivityName;
            dtp_serviceDate.Value = activity.ServiceDate;
            txt_description.Text = activity.Description;
            txt_serviceCost.Text = activity.Cost.ToString();

            btn_submitActivity.Text = "Update Activity";
            Text = "Edit Service Activity";
            resultMessage = "Vehicles service activity entry has been updated successfully";
        }

        private void btn_submitActivity_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                currentActivity = new ServiceActivity()
                {
                    ActivityID = int.Parse(txt_activityID.Text),
                    RegistrationNumber = MainForm.SelectedVehicle.RegistrationNumber,
                    ActivityName = txt_activityName.Text,
                    ServiceDate = dtp_serviceDate.Value,
                    Description = txt_description.Text,
                    Cost = decimal.Parse(txt_serviceCost.Text)
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
            decimal serviceCost = 0;
            bool hiringCostValidNumber = decimal.TryParse(txt_serviceCost.Text, out serviceCost);

            if (txt_activityName.Text.Length == 0)
            {
                output = false;
            }

            if (txt_description.Text.Length == 0)
            {
                output = false;
            }

            if (serviceCost <= 0)
            {
                output = false;
            }

            return output;
        }
    }
}