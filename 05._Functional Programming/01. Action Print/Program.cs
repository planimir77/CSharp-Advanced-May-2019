using System;
using System.Linq;

namespace _01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printNames = name => Console.WriteLine(String.Join(Environment.NewLine, name));

            string[] names = Console.ReadLine()
                .Split();
            

            printNames(names);

        }
    }
}
