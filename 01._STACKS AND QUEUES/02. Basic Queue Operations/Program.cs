using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            var tokken = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var queue = new Queue<int>();

            int elementsToEnqueue = tokken[0];
            int elementsToDequeue = tokken[1];
            int checkNumber = tokken[2];

            for (int i = 0; i < elementsToEnqueue ; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < elementsToDequeue; i++)
            {
                if (queue.Count > 0)
                {
                    queue.Dequeue();
                }
            }
            if (queue.Count==0)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(checkNumber))
            {
                Console.WriteLine("true");
            }
            else
            {
                
                Console.WriteLine(queue.Min());
            }
        }
    }
}
