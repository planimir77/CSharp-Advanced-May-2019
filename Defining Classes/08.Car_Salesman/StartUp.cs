using System;
using System.Linq;
using System.Collections.Generic;

namespace DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var engines = new List<Engine>();
            var cars = new List<Car>();
            int numberOfEngines = int.Parse(Console.ReadLine());


            for (int i = 0; i < numberOfEngines; i++)
            {
                var engineInfo = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string model = engineInfo[0];
                int power = int.Parse(engineInfo[1]);
                Engine engine = new Engine(model, power);
                if (engineInfo.Length == 3)
                {
                    string value = engineInfo[2];

                    if (int.TryParse(value, out int displacement))
                    {
                        engine.Displacement = displacement;
                    }
                    else
                    {
                        engine.Efficiency = value;
                    }
                }
                else if (engineInfo.Length == 4)
                {
                    engine.Displacement = int.Parse(engineInfo[2]);
                    engine.Efficiency = engineInfo[3];
                }
                engines.Add(engine);

            }

            int numberOfCars = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                string engineModel = carInfo[1];
                Engine engine = engines.FirstOrDefault(x => x.Model == engineModel);

                Car car = new Car(model, engine);

                if (carInfo.Length == 3)
                {
                    string color = carInfo[2];
                    if (int.TryParse(color,out int weight))
                    {
                        car.Weight = weight;
                    }
                    else
                    {
                        car.Color = color;
                    }
                    
                }
                else if (carInfo.Length == 4)
                {
                    int weight = int.Parse(carInfo[2]);
                    string color = carInfo[3];
                    car.Weight = weight;
                    car.Color = color;
                }
                cars.Add(car);
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
