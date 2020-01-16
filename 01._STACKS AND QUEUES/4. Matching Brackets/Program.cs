using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            var stack = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    stack.Push(i);
                }
                else if (expression[i] == ')')
                {
                    int from = stack.Pop();
                    int to = i;
                    string result = expression.Substring(from,to-from+1);
                    Console.WriteLine(result);
                }
            }
        }
    }
}
