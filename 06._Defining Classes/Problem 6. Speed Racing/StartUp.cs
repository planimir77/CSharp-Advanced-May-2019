using System;
using System.Linq;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            var cars = new List<Car>();
            for (int i = 0; i < numberOfCars; i++)
            {
                var carInfo = Console.ReadLine()
                    .Split();
                var car = new Car(carInfo);
                cars.Add(car);
            }
            string input = Console.ReadLine();

            while (input != "End")
            {
                var driveCarInfo = input
                    .Split();
                var model = driveCarInfo[1];
                var distance  = double.Parse(driveCarInfo[2]);
                foreach (var car in cars.Where(x => x.Model == model))
                {
                    var fuelForDistance = distance  * car.FuelConsumptionPerKilometer;
                    if (car.FuelAmount - fuelForDistance >= 0)
                    {
                        car.TravelledDistance += distance;
                        car.FuelAmount -= fuelForDistance;
                    }
                    else
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} { car.FuelAmount :F2} { car.TravelledDistance}");
            }
        }
    }
}
