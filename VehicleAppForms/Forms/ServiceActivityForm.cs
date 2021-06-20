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


        }
        private void btn_submitActivity_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                currentActivity = new ServiceActivity()
                {
                    ActivityID = int.Parse(txt_activityID.Text),
                    RegistrationNumber = MainForm.SelectedVehicle.RegistrationNumber,

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