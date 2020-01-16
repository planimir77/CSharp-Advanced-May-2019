using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            var parantheses = Console.ReadLine().ToCharArray();
            var stack = new Stack<char>();
            string result = "YES";
            foreach (var item in parantheses)
            {
                if (item == '('|| item == '{'|| item == '[')
                {
                    stack.Push(item);
                }
                else if (stack.Count == 0)
                {
                    result = "NO";
                    break;
                }
                else if (item == ')' && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else if (item == '}' && stack.Peek() == '{')
                {
                    stack.Pop();
                }
                else if (item == ']' && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else
                {
                    result = "NO";
                    break;
                }

            }
            Console.WriteLine(result);
        }
    }
}
