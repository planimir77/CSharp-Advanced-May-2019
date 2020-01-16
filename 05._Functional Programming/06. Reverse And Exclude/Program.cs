using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Reverse()
                .Select(int.Parse)
                .ToList();
            int number = int.Parse(Console.ReadLine());

            Predicate<int> isDivisible = x => x % number != 0;

            numbers = numbers.Where(x => isDivisible(x)).ToList();

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
