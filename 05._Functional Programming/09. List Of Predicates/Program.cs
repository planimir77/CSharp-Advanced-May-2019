using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            int[] numbers = Console.ReadLine()
                .Split()
                .Distinct()
                .Select(int.Parse)
                .ToArray();
            var numbersList = new List<int>();
            for (int number = 1; number <= range; number++)
            {
                var isValid = true;
                foreach (var item in numbers)
                {
                    
                    if (number % item != 0)
                    {
                        isValid = false;
                    }
                    
                }
                if (isValid)
                {
                    numbersList.Add(number);
                }
            }
            Console.WriteLine(String.Join(" ",numbersList));
        }
    }
}
