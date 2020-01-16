namespace MakeASalad
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var vegetables = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToList();
            var calories = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .Select(int.Parse)
                .ToList();

            var table = new Dictionary<string, int>
            {
                { "tomato", 80 },
                { "carrot",  136},
                {"lettuce", 109 },
                {"potato", 215 }
            };

            var salads = new List<int>();

            var makeSalad = new Queue<int>(calories);
            var withVegetable = new Stack<string>(vegetables);
            while (makeSalad.Count > 0 && withVegetable.Count > 0)
            {
                var salad = makeSalad.Dequeue();
                salads.Add(salad);
                while (salad > 0 && withVegetable.Count > 0)
                {
                    var vegetable = withVegetable.Pop();
                    if (table.ContainsKey(vegetable))
                    {
                        var value = table[vegetable];
                        salad -= value;
                    }
                    
                }
            }
            Console.WriteLine(String.Join(" ", salads));
            if (withVegetable.Count > 0)
            {
                Console.WriteLine(String.Join(" ", withVegetable));
            }
            else if (makeSalad.Count > 0)
            {
                Console.WriteLine(String.Join(" ", makeSalad));
            }

            //var vegetables = Console.ReadLine()
            //    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //var calories = Console.ReadLine()
            //    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToArray();

            //var dict = new Dictionary<string, int>
            //{
            //    { "tomato", 80 },
            //    { "carrot", 136 },
            //    { "lettuce", 109 },
            //    { "potato", 215 }
            //};

            //var saladsToMake = new Stack<int>();

            //foreach (var salad in calories)
            //{
            //    saladsToMake.Push(salad);
            //}

            //var vegetablesToTake = new Queue<string>();

            //foreach (var veg in vegetables)
            //{
            //    vegetablesToTake.Enqueue(veg);
            //}

            //var finishedSalads = new List<int>();

            //while (saladsToMake.Count > 0 && vegetablesToTake.Count > 0)
            //{
            //    var neededSalad = saladsToMake.Peek();

            //    while (neededSalad > 0 && vegetablesToTake.Count > 0)
            //    {
            //        var vegetable = vegetablesToTake.Dequeue();

            //        if (dict.ContainsKey(vegetable))
            //        {
            //            neededSalad -= dict[vegetable];
            //        }
            //    }
            //    if (neededSalad < saladsToMake.Peek())
            //    {
            //        finishedSalads.Add(saladsToMake.Pop());
            //    }
            //}

            //if (finishedSalads.Count > 0)
            //{
            //    Console.WriteLine(string.Join(" ", finishedSalads));
            //}

            //if (vegetablesToTake.Count > 0)
            //{
            //    Console.WriteLine(string.Join(" ", vegetablesToTake));
            //}
            //else if (saladsToMake.Count > 0)
            //{
            //    Console.WriteLine(string.Join(" ", saladsToMake));
            //}
        }
    }
}
