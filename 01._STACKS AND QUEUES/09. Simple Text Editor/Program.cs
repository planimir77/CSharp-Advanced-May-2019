using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperation = int.Parse(Console.ReadLine());

            var sb = new StringBuilder();

            var stack = new Stack<string>();
            for (int i = 0; i < numberOfOperation; i++)
            {
                string[] input = Console.ReadLine().Split();
                int command = int.Parse(input[0]);
                
                switch (command)
                {
                    case 1:
                        stack.Push(sb.ToString());
                        string element = input[1];
                        sb.Append(element);
                        break;
                    case 2:
                        stack.Push(sb.ToString());
                        int number = int.Parse(input[1]);
                        sb.Remove(sb.Length-number,number);
                        
                        break;
                    case 3:
                        int index = int.Parse(input[1])-1;
                        Console.WriteLine(sb[index]);
                        break;
                    case 4:
                        string str = stack.Pop();
                        sb.Clear();
                        sb.Append(str);
                        break;
                }
            }
        }
    }
}
