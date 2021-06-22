// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// Author : Jamie Crowther
// Published Date : 22/06/2021

using VehicleAppLibrary;

namespace VehicleAppForms
{
    interface IActivityForm
    {
        Activity ShowCreate(); //Eeac form that inherits from IActivityForm must use this method, used to show activity form based on which Activity type is selected
    }
}
