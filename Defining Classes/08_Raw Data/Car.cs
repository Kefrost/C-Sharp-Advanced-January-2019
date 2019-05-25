using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {
        public Car(string model, Engine carEngine, Cargo carCargo, Tire[] carTires)
        {
            this.Model = model;
            this.CarEngine = carEngine;
            this.CarCargo = carCargo;
            this.CarTires = carTires;
        }

        public string Model { get; set; }
        public Engine CarEngine { get; set; }
        public Cargo CarCargo { get; set; }
        public Tire[] CarTires { get; set; } = new Tire[4];
    }
}
