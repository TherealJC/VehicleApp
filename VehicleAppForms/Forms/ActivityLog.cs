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

        Dictionary<string, Comparison<Activity>> sortMethods;

        Comparison<Activity> currentSortMethod;


        public ActivityLog()
        {
            InitializeComponent();

            sortMethods = new Dictionary<string, Comparison<Activity>>()
        {
            {"Activity ID", (a, b ) => a.ActivityID.CompareTo(b.ActivityID) },
            {"Name", (a, b ) => a.ActivityName.CompareTo(b.ActivityName) },
            {"Date", (a, b ) => a.GetDate().CompareTo(b.GetDate()) },
            {"Max Revenue", (a, b ) => b.Cost.CompareTo(a.Cost) },
            {"Activity Type", (a, b ) => Activity.GetActivityType(a).CompareTo(Activity.GetActivityType(b))}
        };

            cmb_sortBy.SelectedIndex = 0; //Make sort by box displaye current sorting method
        }

        private void btn_closeActivityLog_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_addNewActivity_Click(object sender, EventArgs e)
        {
            if (SelectActivityType.ShowCreate() is Activity activity)
            {
                DataAccess.CreateActivity(activity);
                ConnectLists();
            }
        }

        private void btn_editSelectedActivity_Click(object sender, EventArgs e)
        {
            switch((Activity)lst_activityLog.SelectedItem)
            {
                case HiringActivity activity:
                    if(new HiringActivityForm().ShowEdit(activity) is Activity a)
                    {
                        DataAccess.CreateActivity(a);
                        ConnectLists();
                    }
                    break;

                case ServiceActivity activity:
                    if (new ServiceActivityForm().ShowEdit(activity) is Activity b)
                    {
                        DataAccess.CreateActivity(b);
                        ConnectLists();
                    }
                    break;

                case RelocationActivity activity:
                    if (new RelocationActivityForm().ShowEdit(activity) is Activity c)
                    {
                        DataAccess.CreateActivity(c);
                        ConnectLists();
                    }
                    break;
            }
        }

        private void ConnectLists()
        {
            lst_activityLog.DataSource = null;
            List<Activity> source = DataAccess.GetVehicleActivities(MainForm.SelectedVehicle.RegistrationNumber);
            source.Sort(currentSortMethod);
            lst_activityLog.DataSource = source;

            decimal total = 0;
            foreach (Activity a in source)
            {
                total += a.GetTotalRevenue();
            }

            txt_vehicleActivityRevenueAmount.Text = total.ToString();

        }

        private void btn_deleteSelectedActivity_Click(object sender, EventArgs e)
        {
            if ((Activity)lst_activityLog.SelectedItem is Activity a)
            {
                DataAccess.DeleteActivity(a.ActivityID);
                ConnectLists();
            }
        }

        private void cmb_sortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortType = (string)cmb_sortBy.SelectedItem;
            currentSortMethod = sortMethods[sortType];
            ConnectLists();
        }
    }
}
