using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                var tokken = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();
                int query = tokken[0];
                

                switch (query)
                {
                    case 1:
                        int number = tokken[1];
                        stack.Push(number);
                        break;
                    case 2:
                        if (stack.Count>0)
                        {
                            stack.Pop();
                        }
                        break;
                    case 3:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;
                    case 4:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                }
            }
            int[] arr = stack.ToArray();
            Console.WriteLine(String.Join(", ",arr));
        }
    }
}
