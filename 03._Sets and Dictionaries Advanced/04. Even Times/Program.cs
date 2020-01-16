using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            var numbers = new Dictionary<int, int>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(number))
                {
                    numbers[number] = 0;
                }
                numbers[number]++;
            }
            int result = numbers.FirstOrDefault(x => x.Value % 2 == 0).Key;
            Console.WriteLine(result);
        }
    }
}
