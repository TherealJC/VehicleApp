using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SDV601_Project
{
    public partial class Edit_Vehicle_Form : SDV601_Project.Add_Vehicle_Form
    {
        private Add_Activity_Form _addActivityForm = new Add_Activity_Form();
        public Edit_Vehicle_Form()
        {
            InitializeComponent();
        }

        private void activityLogBtn_Click(object sender, EventArgs e)
        {
            _addActivityForm.ShowDialog();
        }
    }
}
