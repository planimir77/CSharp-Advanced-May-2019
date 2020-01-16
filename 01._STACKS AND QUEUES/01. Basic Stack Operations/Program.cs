using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokken = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var numOfPushes = tokken[0];
            var numOfPops = tokken[1];
            var element = tokken[2];
            int min = 0;


            var stack = new Stack<int>();

            for (int i = 0; i < numOfPushes; i++)
            {
                stack.Push(numbers[i]);
            }
            for (int i = 0; i < numOfPops; i++)
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }

            }
            if (stack.Count > 0)
            {
                min = stack.Peek();
            }

            while (stack.Count > 0)
            {
                int temp = stack.Pop();
                if (temp == element)
                {
                    Console.WriteLine("true");
                    return;
                }
                else if (temp < min)
                {
                    min = temp;
                }
            }
            Console.WriteLine(min);
        }
    }
}