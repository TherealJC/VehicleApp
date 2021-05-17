using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAT601_Project
{
    public partial class Main_Form : Form
    {
        //Global Variables
        private Add_Vehicle_Form _addVehicleForm = new Add_Vehicle_Form();
        Inventory myInventory = new Inventory();
        BindingSource vehicleInventoryBindingSource = new BindingSource();

        public Main_Form()
        {
            InitializeComponent();
        }


        private void btn_addVehicle_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Please Enter the new cars details");
            _addVehicleForm.ShowDialog();

            Vehicle a = new Vehicle();
            myInventory.VehicleList.Add(a);
            vehicleInventoryBindingSource.ResetBindings(false);

            decimal total = myInventory.totalRevenue();
            lbl_totalRevenue.Text = "$ " + total.ToString();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            vehicleInventoryBindingSource.DataSource = myInventory.VehicleList;

            lst_registration.DataSource = vehicleInventoryBindingSource;
            lst_registration.DisplayMember = ToString();

        }
    }
}
