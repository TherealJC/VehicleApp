using System;
using System.Windows.Forms;
using VehicleAppLibrary;

namespace VehicleAppForms
{
    public partial class HiringActivityForm : Form, IActivityForm
    {
        Activity currentActivity;
        private string resultMessage = ("The Hiring Activity has been successfully added to the database");

        public HiringActivityForm()
        {
            InitializeComponent();
        }

        public Activity ShowCreate()
        {
            txt_activityID.Text = DataAccess.GetNextActivityID().ToString();
            ShowDialog();
            return currentActivity;
        }

        public Activity ShowEdit(HiringActivity activity)
        {
            FillForm(activity);
            ShowDialog();
            return currentActivity;
        }

        private void FillForm(HiringActivity activity)
        {
            txt_activityID.Text = activity.ActivityID.ToString();
            txt_activityName.Text = activity.ActivityName;
            txt_customerName.Text = activity.CustomerName;
            dtp_startDate.Value = activity.StartDate;
            dtp_endDate.Value = activity.EndDate;
            txt_hiringCost.Text = activity.Cost.ToString();

            btn_submitActivity.Text = "Update Activity";
            Text = "Edit Hiring Activity";
            resultMessage = "Vehicles hiring activity entry has been updated successfully";
        }

        private void btn_submitActivity_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                currentActivity = new HiringActivity()
                {
                   ActivityID = int.Parse(txt_activityID.Text),
                   RegistrationNumber = MainForm.SelectedVehicle.RegistrationNumber,
                   ActivityName = txt_activityName.Text,
                   CustomerName = txt_customerName.Text,
                   StartDate = dtp_startDate.Value,
                   EndDate = dtp_endDate.Value,
                   Cost = decimal.Parse(txt_hiringCost.Text)
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
            decimal hiringCost = 0;
            bool hiringCostValidNumber = decimal.TryParse(txt_hiringCost.Text, out hiringCost);

            if (txt_activityName.Text.Length == 0)
            {
                output = false;
            }

            if (txt_customerName.Text.Length == 0)
            {
                output = false;
            }

            if (hiringCost <= 0)
            {
                output = false;
            }

            return output;
        }
    }
}
