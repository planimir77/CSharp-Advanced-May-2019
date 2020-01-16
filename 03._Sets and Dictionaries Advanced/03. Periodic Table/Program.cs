using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            var elements = new SortedSet<string>();

            for (int i = 0; i < numbers; i++)
            {
                var inputElements = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);
                foreach (var element in inputElements)
                {
                    elements.Add(element);
                }
            }
            Console.WriteLine(String.Join(" ",elements));
        }
    }
}
