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
    public partial class SelectActivityType : Form
    {
        private Activity newActivity;
        public SelectActivityType()
        {
            InitializeComponent();
        }

        public static Activity ShowCreate()
        {
            SelectActivityType form = new SelectActivityType();
            form.ShowDialog();
            return form.newActivity;
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            if (rbtn_hiring.Checked)
            {
                newActivity = new HiringActivityForm().ShowCreate();
            }
            else if (rbtn_service.Checked)
            {
                newActivity = new ServiceActivityForm().ShowCreate();
            }
            else 
            {
                newActivity = new RelocationActivityForm().ShowCreate();
            }
            DialogResult = DialogResult.OK;
        }
    }
}
