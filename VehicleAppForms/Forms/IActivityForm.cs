using VehicleAppLibrary;

namespace VehicleAppForms
{
    interface IActivityForm
    {
        Activity ShowCreate(); //Every form that is an IActivityForm must use this method, used to show (edit) or create (new) an activity
    }
}
