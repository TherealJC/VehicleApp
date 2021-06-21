using System;
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

        private void Btn_Continue_Click(object sender, EventArgs e)
        {
            if (Rbtn_Hiring.Checked) //If hiring radio button is checked
            {
                newActivity = new HiringActivityForm().ShowCreate(); //set newActivity to equal a new activity form and call ShowCreate() which opens the form for creation or editing
            }

            else if (Rbtn_Service.Checked)
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
