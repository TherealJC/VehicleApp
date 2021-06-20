using System;
using System.Windows.Forms;
using VehicleAppLibrary;

namespace VehicleAppForms
{
    public partial class RelocationActivityForm : Form, IActivityForm
    {
        Activity currentActivity;

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
