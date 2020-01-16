using System;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> incrementByOne = x => x + 1;
            Func<int, int> decrementByOne = x => x - 1;
            Func<int, int> multiplyByTwo = x => x * 2;
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            while (command != "end")
            {
                if (command== "add")
                {
                    numbers = numbers.Select(incrementByOne).ToList();
                }
                else if (command == "multiply")
                {
                    numbers = numbers.Select(multiplyByTwo).ToList();
                }
                else if (command == "subtract")
                {
                    numbers = numbers.Select(decrementByOne).ToList();
                }
                else if (command == "print")
                {
                    Console.WriteLine(String.Join(" ", numbers));
                }
                command = Console.ReadLine();
            }
            
        }
    }
}
