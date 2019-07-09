using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tires tires;

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tires Tires { get; set; }

        public Car()
        {
            this.Model = model;
            this.Engine = new Engine();
            this.Cargo = new Cargo();
            this.Tires = new Tires();
        }

        public Car(string[] car)
            :this()
        {
            var model = car[0];
            int speed = int.Parse(car[1]);
            int power = int.Parse(car[2]);
            int weight = int.Parse(car[3]);
            string type = car[4];
            double tire1Pressure = double.Parse(car[5]);
            int tire1Age = int.Parse(car[6]);
            double tire2Pressure = double.Parse(car[7]);
            int tire2Age = int.Parse(car[8]);
            double tire3Pressure = double.Parse(car[9]);
            int tire3Age = int.Parse(car[10]);
            double tire4Pressure = double.Parse(car[11]);
            int tire4Age = int.Parse(car[12]);

            this.Model = model;
            this.Engine = new Engine(speed, power);
            this.Cargo = new Cargo(weight, type);
            this.Tires = new Tires(tire1Pressure, tire1Age, tire2Pressure, tire2Age, tire3Pressure, tire3Age, tire4Pressure, tire4Age);
        }
    }
}
