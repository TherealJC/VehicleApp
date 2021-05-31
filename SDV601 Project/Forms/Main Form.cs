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
    public partial class Main_Form : Form
    {
        //Global Variables
        private Add_Vehicle_Form _addVehicleForm = new Add_Vehicle_Form();
        private Edit_Vehicle_Form _editVehicleForm = new Edit_Vehicle_Form();
        public Inventory myInventory = new Inventory();
        public BindingSource vehicleInventoryBindingSource = new BindingSource();

        public Main_Form()
        {
            InitializeComponent();
        }

        private void btn_addVehicle_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Please Enter the new cars details");
            _addVehicleForm.ShowDialog();
        }

        private void btn_editVehicle_Click(object sender, EventArgs e)
        {
            _editVehicleForm.ShowDialog();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            vehicleInventoryBindingSource.DataSource = myInventory.VehicleList;

            lst_registration.DataSource = vehicleInventoryBindingSource;
            lst_registration.DisplayMember = ToString();

            decimal total = myInventory.totalRevenue();
            lbl_totalRevenuePrice.Text = "$ " + total.ToString();
        }
    }
}
