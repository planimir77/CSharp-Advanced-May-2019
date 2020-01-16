using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] bounds = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int lowerBound = bounds[0];
            int upperBound = bounds[1];
            string numberType = Console.ReadLine();


            var numbers = new List<int>();

            for (int i = lowerBound; i <= upperBound; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> isEven = number => number % 2 == 0;
            Predicate<int> isOdd = number => number % 2 != 0 ;

            if (numberType == "even")
            {
                numbers = numbers.Where(x => isEven(x)).ToList();
            }
            if (numberType == "odd")
            {
                numbers = numbers.Where(x => isOdd(x)).ToList();
            }
            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
