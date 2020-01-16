using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            var cars = new Car[numberOfCars];

            for (int i = 0; i < numberOfCars; i++)
            {
                var carInfo = Console.ReadLine()
                .Split();
                Car car = new Car(carInfo);
                cars[i] = car;
            }

            string cargoType = Console.ReadLine();
            foreach (var car in cars.Where(x => x.Cargo.CargoType == cargoType))
            {
                if (cargoType == "flamable")
                {
                    if (car.Engine.Power>250)
                    {
                        Console.WriteLine(car.Model.ToString());
                    }
                    
                }
                else if (cargoType == "fragile")
                {
                    if (car.Tires.TirePressure.FirstOrDefault() > 1)
                    {
                        continue;
                    }
                    Console.WriteLine(car.Model.ToString());
                }
            }
            
            //if (cargoType == "fragile" )
            //{
            //    foreach (var car in cars)
            //    {
            //        if (car.Tires.TirePressure.FirstOrDefault()>1)
            //        {
            //            continue;
            //        }
            //        Console.WriteLine(car.Model.ToString());
            //    }
            //}
        }
    }
}
