﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tire
    {
        public Tire(double pressure, int age)
        {
            this.TirePressure = pressure;
            this.TireAge = age;
        }
        public double TirePressure { get; set; }
        public int TireAge { get; set; }
    }
}
