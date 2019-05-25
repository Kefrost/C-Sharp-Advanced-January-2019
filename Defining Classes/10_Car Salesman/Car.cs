using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{this.Model}:");
            stringBuilder.AppendLine(Engine.ToString());
            stringBuilder.AppendLine($"  Weight: {this.Weight}");
            stringBuilder.Append($"  Color: {this.Color}");

            return stringBuilder.ToString();

        }
    }
}
