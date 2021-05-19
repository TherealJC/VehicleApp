using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDV601_Project
{
    public partial class Add_Vehicle_Form : Form
    {

        Inventory myInventory = new Inventory();
        BindingSource vehicleInventoryBindingSource = new BindingSource();

        public Add_Vehicle_Form()
        {
            InitializeComponent();
        }

        private void btn_addVehicle_Click(object sender, EventArgs e)
        {
            Vehicle a = new Vehicle();
            myInventory.VehicleList.Add(a);
            vehicleInventoryBindingSource.ResetBindings(false);
            Close();
        }
    }
}
