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
    public partial class RelocationActivityForm : Form, IActivityForm
    {
        public RelocationActivityForm()
        {
            InitializeComponent();
        }

        public Activity ShowCreate()
        {
            return null;
        }
    }
}
