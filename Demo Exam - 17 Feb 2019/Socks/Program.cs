using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace Socks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var leftArr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            var rightArr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            var left = new Stack<int>(leftArr);

            var right = new Stack<int>(rightArr.Reverse());

            var pair = new List<int>();

            while (left.Count > 0 && right.Count > 0)
            {
                var leftNumber = left.Pop();

                var rightNumber = right.Pop();

                if (leftNumber > rightNumber)
                {
                    pair.Add(leftNumber+rightNumber);
                }
                else if (leftNumber < rightNumber)
                {
                    right.Push(rightNumber);
                }
                else
                {
                    left.Push(leftNumber+1);
                }
            }

            var maxPair = pair.Max();

            Console.WriteLine(maxPair);

            Console.WriteLine(String.Join(" ",pair));
        }
    }
}
