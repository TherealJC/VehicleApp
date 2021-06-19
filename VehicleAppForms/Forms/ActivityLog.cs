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
    public partial class ActivityLog : Form
    {
        public ActivityLog()
        {
            InitializeComponent();
        }

        private void btn_closeActivityLog_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_addNewActivity_Click(object sender, EventArgs e)
        {
            if (SelectActivityType.ShowCreate() is Activity activity);
        }
    }
}
