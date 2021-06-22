// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// Author : Jamie Crowther
// Published Date : 22/06/2021

using System;

namespace VehicleAppLibrary
{
    public class ServiceActivity : Activity
    {
        public DateTime ServiceDate { get; set; }
        public string Description { get; set; }

        public override string SaveString()  //Used to save the activity string to file (overrides abstract SaveString() in paretn class 'Activity'
        {
            return $"{(int)ActivityType.Service},{ActivityID},{RegistrationNumber},{ActivityName},{Cost},{ServiceDate},{Description}";
        }

        protected override void LoadFromColumns(string[] columns)
        {
            base.LoadFromColumns(columns);
            int startingPoint = 5;
            ServiceDate = DateTime.Parse(columns[startingPoint++]);
            Description = (columns[startingPoint++]);
        }

        public override string ToString()
        {
            return $"{ActivityType.Service} | Workshop: {ActivityName} |  Cost: {Cost}  |  Service Date: {ServiceDate.ToShortDateString()} | Description: {Description}";
        }

        public override DateTime GetDate()
        {
            return ServiceDate;
        }

        public override decimal GetTotalRevenue()
        {
            return -Cost;
        }
    }
}
