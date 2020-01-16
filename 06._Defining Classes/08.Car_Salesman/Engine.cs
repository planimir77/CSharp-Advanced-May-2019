using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class Engine
    {
        private string model;
        private int power;
        private int displacement;
        private string efficiency;

        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }
        
        public Engine(string model, int power )
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = 0;
            this.Efficiency = "n/a";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Model}:");
            sb.AppendLine($"    Power: {this.Power}");
            if (this.Displacement == 0)
            {
                sb.AppendLine($"    Displacement: n/a");
            }
            else
            {
                sb.AppendLine($"    Displacement: {this.Displacement}");
            }

            sb.AppendLine($"    Efficiency: {this.Efficiency}");

            return sb.ToString().Trim();
        }
    }
}
