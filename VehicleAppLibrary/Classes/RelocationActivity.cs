// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// Author : Jamie Crowther
// Published Date : 22/06/2021

using System;

namespace VehicleAppLibrary
{
    public class RelocationActivity : Activity
    {
        public DateTime RelocationDate { get; set; }
        public int KmsUsed { get; set; }

        public override string SaveString()  //Used to save the activity string to file (overrides abstract SaveString() in paretn class 'Activity'
        {
            return $"{(int)ActivityType.Relocation},{ActivityID},{RegistrationNumber},{ActivityName},{Cost},{RelocationDate},{KmsUsed}";
        }
        protected override void LoadFromColumns(string[] columns)
        {
            base.LoadFromColumns(columns);
            int startingPoint = 5;
            RelocationDate = DateTime.Parse(columns[startingPoint++]);
            KmsUsed = int.Parse(columns[startingPoint++]);
        }

        public override string ToString()
        {
            return $"{ActivityType.Relocation} | Location From/To: {ActivityName}  |  Relocation Date: {RelocationDate.ToShortDateString()} | Kms Used: {KmsUsed} |  Cost: {Cost}";
        }

        public override DateTime GetDate()
        {
            return RelocationDate;
        }

        public override decimal GetTotalRevenue()
        {
            return -Cost;
        }
    }
}
