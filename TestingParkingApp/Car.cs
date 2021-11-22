﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingParkingApp
{
    internal class Car : Vehicle
    {
        public Car(string aRegNum) : base(aRegNum)//Set Regnumber in vehcle class (parent class)
        {
            var settings = Configuration.ReadSettingsFromFile();//instance the settings class to get our values from our json file
            size = settings.CarSize;
            Price = settings.CarPrice;

        }
    }
}
