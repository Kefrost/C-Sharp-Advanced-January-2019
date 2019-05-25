using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        public Engine(string model, int power)
        {
            this.EngineModel = model;
            this.Power = power;
        }

        public string EngineModel { get; set; }
        public int Power { get; set; }
        public string Displacement { get; set; }
        public string Efficiency { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"  {this.EngineModel}:");
            stringBuilder.AppendLine($"    Power: {this.Power}");
            stringBuilder.AppendLine($"    Displacement: {this.Displacement}");
            stringBuilder.Append($"    Efficiency: {this.Efficiency}");

            return stringBuilder.ToString();
        }
    }
}
