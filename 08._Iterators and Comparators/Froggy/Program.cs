using System;
using System.Linq;

namespace Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumers = Console.ReadLine()
                .Split(new char[] { ' ',','}
                ,StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

        }
    }
}
