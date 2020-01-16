namespace Club_Party
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var capacity = int.Parse(Console.ReadLine());
            var tokkens = Console.ReadLine()
                ?.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            
            var elements = new Stack<string>(tokkens ?? throw new InvalidOperationException());
            var letters = new Queue<string>();

            var dict = new Dictionary<string, List<int>>();

            while (elements.Count > 0)
            {
                var element = elements.Pop();
                if (int.TryParse(element, out int result))
                {
                    if (letters.Count > 0)
                    {
                        var currentLetter = letters.Peek();
                        var sum = dict[currentLetter].Sum();
                        if (sum + result < capacity)
                        {
                            dict[currentLetter].Add(result);
                        }
                        else if (sum + result == capacity)
                        {
                            dict[currentLetter].Add(result);
                            Console.WriteLine($"{letters.Dequeue()} -> {String.Join(", ", dict[currentLetter])}");
                        }
                        else
                        {
                            elements.Push(element);
                            Console.WriteLine($"{letters.Dequeue()} -> {String.Join(", ", dict[currentLetter])}");
                            //letters.Dequeue();
                        }
                        
                    }
                }
                else
                {
                    letters.Enqueue(element);
                    dict[element] = new List<int>();

                }
            }
        }
    }
}
