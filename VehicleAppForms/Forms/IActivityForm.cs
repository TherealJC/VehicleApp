using VehicleAppLibrary;

namespace VehicleAppForms
{
    interface IActivityForm
    {
        Activity ShowCreate(); //Eeac form that inherits from IActivityForm must use this method, used to show activity form based on which Activity type is selected
    }
}
