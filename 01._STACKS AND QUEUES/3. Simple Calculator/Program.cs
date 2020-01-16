using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            var stack = new Stack<string>(arr.Reverse());

            while (stack.Count > 1)
            {
                int firstNum = int.Parse(stack.Pop());
                string sing = stack.Pop();
                int secondNum = int.Parse(stack.Pop());
                
                if (sing=="+")
                {
                    stack.Push((firstNum+secondNum).ToString());
                }
                else if (sing == "-")
                {
                    stack.Push((firstNum - secondNum).ToString());
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
