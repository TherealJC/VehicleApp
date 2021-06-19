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
        Activity activity;

        public HiringActivityForm()
        {
            InitializeComponent();
        }

        public Activity ShowCreate()
        {
            return null;
        }

        private void btn_submitActivity_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                activity = new HiringActivity()
                {
                   HiringActivityName = txt_activityName.Text,
                   CustomerName = txt_customerName.Text,
                   StartDate = dtp_startDate.Value,
                   EndDate = dtp_endDate.Value,
                   HiringCost = decimal.Parse(txt_hiringCost.Text)
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
