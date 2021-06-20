using System;
using System.Windows.Forms;
using VehicleAppLibrary;

namespace VehicleAppForms
{
    public partial class ServiceActivityForm : Form, IActivityForm
    {
        Activity currentActivity;

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

            return output;
        }
    }
}