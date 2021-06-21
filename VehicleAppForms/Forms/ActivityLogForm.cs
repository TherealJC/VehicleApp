using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VehicleAppLibrary;

namespace VehicleAppForms
{
    public partial class ActivityLog : Form
    {
        private readonly Dictionary<string, Comparison<Activity>> _sortMethods;

        private Comparison<Activity> _currentSortMethod;

        public ActivityLog()
        {
            InitializeComponent();

            _sortMethods = new Dictionary<string, Comparison<Activity>>() //Compares each entry in the list (a vs b) until desires sorting method is displayed correctly
        {
            {"Activity ID", (a, b ) => a.ActivityID.CompareTo(b.ActivityID) }, // sort by activity ID
            {"Name", (a, b ) => a.ActivityName.CompareTo(b.ActivityName) }, // sort by activity name
            {"Date", (a, b ) => a.GetDate().CompareTo(b.GetDate()) }, // sort by Date
            {"Highest Cost", (a, b ) => b.Cost.CompareTo(a.Cost) }, // sort by Cost
            {"Activity Type", (a, b ) => Activity.GetActivityType(a).CompareTo(Activity.GetActivityType(b))} // sort by activity type
        };

            Cmb_SortBy.SelectedIndex = 0; //Make sort by box display the current sorting method as text
        }

        private void Btn_AddNewActivity_Click(object sender, EventArgs e) // Add new activity, opens different form depending on activity type
        {
            if (SelectActivityType.ShowCreate() is Activity activity)
            {
                DataAccess.CreateActivity(activity);
                ConnectLists();
            }
        }

        private void Btn_EditSelectedActivity_Click(object sender, EventArgs e) // Edit existing activity, opens different form depending on activity selected
        {
            switch((Activity)Lst_ActivityLog.SelectedItem)
            {
                case HiringActivity activity:
                    if(new HiringActivityForm().ShowEdit(activity) is Activity a) // if selected activity = hiring activity, ShowEdit of Hiring activity Form
                    {
                        DataAccess.CreateActivity(a);
                        ConnectLists();
                    }
                    break;

                case ServiceActivity activity:
                    if (new ServiceActivityForm().ShowEdit(activity) is Activity b) // if selected activity = service activity, ShowEdit of Service activity Form
                    {
                        DataAccess.CreateActivity(b);
                        ConnectLists();
                    }
                    break;

                case RelocationActivity activity:
                    if (new RelocationActivityForm().ShowEdit(activity) is Activity c) // if selected activity = relocation activity, ShowEdit of Relocation activity Form
                    {
                        DataAccess.CreateActivity(c);
                        ConnectLists();
                    }
                    break;
            }
        }

        private void Btn_DeleteSelectedActivity_Click(object sender, EventArgs e) // Delete activity from list
        {
            if ((Activity)Lst_ActivityLog.SelectedItem is Activity a)
            {
                DataAccess.DeleteActivity(a.ActivityID);
                ConnectLists();
            }
        }

        private void ConnectLists() // Connect activity listbox to Activity datasource
        {
            Lst_ActivityLog.DataSource = null;
            List<Activity> source = DataAccess.GetVehicleActivities(MainForm.SelectedVehicle.RegistrationNumber);
            source.Sort(_currentSortMethod);
            Lst_ActivityLog.DataSource = source;

            decimal total = 0;
            foreach (Activity a in source)
            {
                total += a.GetTotalRevenue(); // For calculating the individual Vehicles activity revenue
            }

            Txt_VehicleActivityRevenueAmount.Text = total.ToString(); // update vehicles activity revenue (on form)

        }

        private void Cmb_SortBy_SelectedIndexChanged(object sender, EventArgs e) // Sort by selected sorting method
        {
            string sortType = (string)Cmb_SortBy.SelectedItem;
            _currentSortMethod = _sortMethods[sortType];
            ConnectLists();
        }

        private void Btn_CloseActivityLog_Click(object sender, EventArgs e)
        {
            Close(); 
        }

    }
}
