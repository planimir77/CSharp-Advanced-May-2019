using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Auto_Repair_and_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split();
            var vehiclesForCervice = new Queue<string>(arr);
            var servedVehicles = new Stack<string>();

            string input = Console.ReadLine();

            while (input.ToLower() != "end")
            {

                if (input.Contains("CarInfo"))
                {
                    var tokken = input.Split('-', StringSplitOptions.RemoveEmptyEntries);
                    var vehicle = tokken[1];

                    if (vehiclesForCervice.Contains(vehicle))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                    else if (servedVehicles.Contains(vehicle))
                    {
                        Console.WriteLine("Served.");
                    }
                }
                else if (input == "Service" && vehiclesForCervice.Count > 0)
                {
                    var servedVehicle = vehiclesForCervice.Dequeue();
                    servedVehicles.Push(servedVehicle);
                    Console.WriteLine($"Vehicle {servedVehicle} got served.");
                }
                else if (input == "History")
                {
                    Console.WriteLine(String.Join(", ", servedVehicles));
                }

                input = Console.ReadLine();
            }
            if (vehiclesForCervice.Count > 0)
            {
                Console.WriteLine($"Vehicles for service: {String.Join(", ", vehiclesForCervice)}");
            }
            Console.WriteLine($"Served vehicles: {String.Join(", ", servedVehicles)}");
        }
    }
}
