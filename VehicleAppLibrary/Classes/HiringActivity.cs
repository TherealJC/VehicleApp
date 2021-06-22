// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// Author : Jamie Crowther
// Published Date : 22/06/2021

using System;

namespace VehicleAppLibrary
{
    public class HiringActivity : Activity
    {
        public string CustomerName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public override string SaveString() //Used to save the activity string to file (overrides abstract SaveString() in paretn class 'Activity'
        {
            return $"{(int)ActivityType.Hiring},{ActivityID},{RegistrationNumber},{ActivityName},{Cost},{CustomerName},{StartDate},{EndDate}";
        }

        protected override void LoadFromColumns(string[] columns)
        {
            base.LoadFromColumns(columns); //Append additional values to the end of common values
            int startingPoint = 5;
            CustomerName = columns[startingPoint++];
            StartDate = DateTime.Parse(columns[startingPoint++]);
            EndDate = DateTime.Parse(columns[startingPoint++]);
        }

        public override string ToString() //Returns a string containing all relevant values (To be displayed in list on ActivityLog)
        {
           return $"{ActivityType.Hiring} | Activity Name: {ActivityName}  |  Customer: {CustomerName} | Cost: {Cost}  |  From: {StartDate.ToShortDateString()} | To: {EndDate.ToShortDateString()}";
        }
        public override DateTime GetDate()
        {
            return StartDate; //override GetDate with StartDate value
        }

        public override decimal GetTotalRevenue() //Calculate total revenue of the vehicle inventory
        {
            return Cost;
        }
    }
}
