using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            int[] order = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>(order.Reverse());
            Console.WriteLine(stack.Max());
            bool ordersLeft = false;

            while (stack.Count != 0)
            {
                if (quantity - stack.Peek() >= 0)
                {
                    quantity -= stack.Pop();
                }
                else
                {
                    ordersLeft = true;
                }
                if (ordersLeft)
                {
                    int[] arr = stack.ToArray();
                    Console.WriteLine($"Orders left: {String.Join(" ",arr)}");
                    return;
                }
            }
            Console.WriteLine("Orders complete");
        }
    }
}
