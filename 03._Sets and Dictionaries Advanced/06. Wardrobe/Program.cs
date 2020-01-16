using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            var clothes = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                var input = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                var color = input[0];
                var tokken = input[1];
                if (!clothes.ContainsKey(color))
                {
                    clothes[color] = new Dictionary<string, int>();
                }

                if (!input[1].Contains(','))
                {
                    if (!clothes[color].ContainsKey(tokken))
                    {
                        clothes[color][tokken] = 0;
                    }
                    clothes[color][tokken]++;
                }
                else
                {
                    var clothesTokken = tokken
                        .Split(",", StringSplitOptions.RemoveEmptyEntries);
                    foreach (var item in clothesTokken)
                    {
                        if (!clothes[color].ContainsKey(item))
                        {
                            clothes[color][item] = 0;
                        }
                        clothes[color][item]++;
                    }
                }
            }
            var target = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var targetColor = target[0];
            var targetItem = target[1];
            foreach (var kvp in clothes)
            {
                Console.WriteLine($"{kvp.Key} clothes:");
                foreach (var item in kvp.Value)
                {
                    Console.Write($"* {item.Key} - {item.Value}");
                    if (kvp.Key == targetColor && item.Key == targetItem)
                    {
                        Console.Write($" (found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
