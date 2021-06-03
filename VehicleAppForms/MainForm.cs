﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleAppForms
{
    public partial class MainForm : Form
    {
        private CreateVehicleForm _createVehicleForm = new CreateVehicleForm();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_createVehicle_Click(object sender, EventArgs e)
        {
            _createVehicleForm.ShowDialog();
        }
    }
}
