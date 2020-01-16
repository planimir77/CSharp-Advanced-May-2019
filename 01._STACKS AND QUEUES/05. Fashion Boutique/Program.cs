using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] order = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>(order.Reverse());
            int capacity = int.Parse(Console.ReadLine());
            int count = 0;
            while (stack.Count > 0)
            {
                int temp = 0;
                while (temp <= capacity && stack.Count>0)
                {
                    if (temp + stack.Peek() <= capacity)
                    {
                        temp += stack.Pop();
                    }
                    else
                    {
                        break;
                    }
                }
                count++;

            }
            Console.WriteLine(count);
        }
    }
}
