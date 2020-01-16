using System.Linq;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class Tires
    {
        private double tire1Pressure;
        private int tire1Age;
        private double tire2Pressure;
        private int tire2Age;
        private double tire3Pressure;
        private int tire3Age;
        private double tire4Pressure;
        private int tire4Age;
        private List<double> tirePressure;

        public double Tire1Pressure { get; set; }
        public int Tire1Age { get; set; }
        public double Tire2Pressure { get; set; }
        public int Tire2Age { get; set; }
        public double Tire3Pressure { get; set; }
        public int Tire3Age { get; set; }
        public double Tire4Pressure { get; set; }
        public int Tire4Age { get; set; }
        public List<double> TirePressure { get; set; }
        

        public Tires()
        {
            this.Tire1Pressure = tire1Pressure;
            this.Tire1Age = tire1Age;
            this.Tire2Pressure = tire2Pressure;
            this.Tire2Age = tire2Age;
            this.Tire3Pressure = tire3Pressure;
            this.Tire3Age = tire3Age;
            this.Tire4Pressure = tire4Pressure;
            this.Tire4Age = tire4Age;
            this.TirePressure = new List<double>();

        }

        public Tires(double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age
                   , double tire3Pressure, int tire3Age, double tire4Pressure, int tire4Age)
            :this()
        {
            //this.Tire1Pressure = tire1Pressure;
            this.Tire1Age = tire1Age;
            //this.Tire2Pressure = tire2Pressure;
            this.Tire2Age = tire2Age;
            //this.Tire3Pressure = tire3Pressure;
            this.Tire3Age = tire3Age;
            //this.Tire4Pressure = tire4Pressure;
            this.Tire4Age = tire4Age;
            this.TirePressure.Add(tire1Pressure);
            this.TirePressure.Add(tire2Pressure);
            this.TirePressure.Add(tire3Pressure);
            this.TirePressure.Add(tire4Pressure);
        }
    }
}