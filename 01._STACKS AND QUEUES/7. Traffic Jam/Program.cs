using System;
using System.Collections;
using System.Collections.Generic;

namespace _7._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCar = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int passedCar = 0;
            var cars = new Queue<string>();

            while (input != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < numberOfCar; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            passedCar++;
                        }
                        
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{passedCar} cars passed the crossroads.");
        }
    }
}
