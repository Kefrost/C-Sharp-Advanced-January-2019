using System;
using System.Collections.Generic;
using System.Text;

namespace Speed
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumption { get; set; }
        public double TraveledDistance { get; set; }

        public void CheckDistance(double distance)
        {
            double amountOfFuelNeeded = this.FuelConsumption * distance;

            if (this.FuelAmount >= amountOfFuelNeeded)
            {
                this.FuelAmount -= amountOfFuelNeeded;
                this.TraveledDistance += distance;
            }
            else
            {
                System.Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
