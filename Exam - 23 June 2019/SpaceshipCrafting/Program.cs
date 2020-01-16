using System;
using System.Collections.Generic;
using System.Linq;

namespace SpaceshipCrafting
{
    public class Program
    {
        private static Dictionary<string, int> items = new Dictionary<string, int>
        {
            { "Glass", 25} ,
            {"Aluminium", 50 } ,
            {"Lithium", 75 } ,
            {"Carbon fiber", 100}
        };

        private static Dictionary<string, int> amount = new Dictionary<string, int>
        {
            
            {"Aluminium", 0 } ,
            {"Carbon fiber", 0},
            { "Glass", 0},
            {"Lithium", 0 } 
            
        };
        public static void Main(string[] args)
        {
            var arr1 = Console.ReadLine()
                ?.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            var liquids = new Stack<int>(arr1.Reverse());

            var arr2 = Console.ReadLine()
                ?.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var physicalItems = new Stack<int>(arr2);

            

            while (liquids.Count > 0 && physicalItems.Count > 0 && items.Count > 0)
            {
                var currentLiquid = liquids.Pop();
                var currentPhysicalItem = physicalItems.Pop();

                if (items.ContainsValue(currentLiquid + currentPhysicalItem))
                {
                    string key = items.FirstOrDefault(x=>x.Value == currentLiquid + currentPhysicalItem).Key;
                    amount[key]++;
                }
                else
                {
                    physicalItems.Push(currentPhysicalItem + 3);
                }
            }

            Console.WriteLine(!amount.ContainsValue(0)
                ? $"Wohoo! You succeeded in building the spaceship!"
                : "Ugh, what a pity! You didn't have enough materials to build the spaceship.");

            Console.WriteLine(liquids.Count > 0
                ? $"Liquids left: {String.Join(", ", liquids)}"
                : $"Liquids left: none");

            Console.WriteLine(physicalItems.Count > 0
                ? $"Physical items left: {String.Join(", ", physicalItems)}"
                : $"Physical items left: none");

            foreach (var (key, value) in amount)
            {
                Console.WriteLine($"{key}: {value}");
            }
        }

        
    }
}
