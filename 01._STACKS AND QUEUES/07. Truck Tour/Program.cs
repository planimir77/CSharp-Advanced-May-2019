using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPomp = int.Parse(Console.ReadLine());
            var pomps = new Queue<int[]>();
            var pompNumber = 0;
            for (int i = 0; i < numberOfPomp; i++)
            {
                var tokken = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                pomps.Enqueue(tokken);
            }

            
            while (true)
            {
                int fuel = 0;
                var distance = 0;
                foreach (var item in pomps)
                {
                    var amountOfPetrol = item[0];
                    var currentDistance = item[1];

                    fuel += amountOfPetrol - currentDistance;

                    if (fuel < 0)
                    {

                        var tempPomp = pomps.Dequeue();
                        pomps.Enqueue(tempPomp);
                        pompNumber++;
                        break; ;
                    }
                }
                if (fuel>=distance)
                {
                    break;
                }
            }
            
            Console.WriteLine(pompNumber);
        }
    }
}
