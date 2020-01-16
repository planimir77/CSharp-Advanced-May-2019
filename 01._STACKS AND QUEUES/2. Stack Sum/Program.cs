using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input = Console.ReadLine().ToLower();

            var stack = new Stack<int>(numbers);
            int sum = 0;

            while (input != "end")
            {
                string[] tokken = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokken[0];
                int numberToRemove = int.Parse(tokken[1]);
                if (command == "add")
                {
                    for (int i = 1; i < tokken.Length; i++)
                    {
                        stack.Push(int.Parse(tokken[i]));
                    }
                }
                else if (command == "remove")
                {
                    if (numberToRemove <= stack.Count)
                    {
                        for (int i = 0; i < numberToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                input = Console.ReadLine().ToLower();
            }
            if (stack.Count != 0)
            {
                while (stack.Count != 0)
                {
                    sum += stack.Pop();
                }
                
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
