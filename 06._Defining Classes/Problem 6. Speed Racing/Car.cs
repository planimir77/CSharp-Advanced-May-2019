using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public Car()
        {

        }
        public Car(String[] car)
            :this()
        {
            this.Model = car[0];
            this.FuelAmount = double.Parse( car[1]);
            this.FuelConsumptionPerKilometer= double.Parse(car[2]);
            this.TravelledDistance = travelledDistance;
        }
    }
}
