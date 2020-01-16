using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace _6._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split();
            var queue = new Queue<string>(children);
            int count = int.Parse(Console.ReadLine());

            while (queue.Count > 1)
            {
                for (int i = 1; i < count; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }

            Console.WriteLine($"Last is {queue.First()}");
        }
    }
}
