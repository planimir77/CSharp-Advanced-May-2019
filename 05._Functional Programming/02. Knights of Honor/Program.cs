using System;
using System.Linq;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {

            Action<string[]> printSirAndNames = name 
                => Console.WriteLine("Sir " + String.Join(Environment.NewLine + "Sir ", name));

            string[] inputName = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            printSirAndNames(inputName);
        }
    }
}
