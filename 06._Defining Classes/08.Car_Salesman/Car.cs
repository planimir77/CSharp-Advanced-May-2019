using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color ;

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }
        
        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = 0;
            this.Color = "n/a";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Model}:");
            sb.AppendLine($"  {this.Engine}");
            if (this.Weight == 0)
            {
                sb.AppendLine("  Weight: n/a");
            }
            else
            {
                sb.AppendLine($"  Weight: {this.Weight}");
            }
            sb.AppendLine($"  Color: {this.Color}");
            return sb.ToString().Trim();
        }
    }
}
