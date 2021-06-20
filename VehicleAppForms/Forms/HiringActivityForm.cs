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
    public partial class HiringActivityForm : Form, IActivityForm
    {
        Activity currentActivity;

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
        }

        private void btn_submitActivity_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
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

                DialogResult = DialogResult.OK;
            }
            else
            {

            }

        }

        private bool ValidateForm()
        {
            bool output = true;

            return output;
        }
    }
}
