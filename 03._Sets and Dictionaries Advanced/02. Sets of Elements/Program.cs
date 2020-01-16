using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokken = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);
            var firstSetNumbers = int.Parse(tokken[0]);
            var secondSetNumbers = int.Parse(tokken[1]);

            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();

            for (int i = 0; i < firstSetNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstSet.Add(number);
            }
            for (int i = 0; i < secondSetNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                secondSet.Add(number);
            }
            foreach (var item in firstSet)
            {
                if (secondSet.Contains(item))
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
