using System;
using System.Linq;

namespace Excel_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixRows = int.Parse(Console.ReadLine());
            var matrix = new string[4,3];

            for (int row= 0; row < matrix.GetLength(0); row++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            var command = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            if (command[0] == "hide")
            {
                var header = command[1];

            }
            else if (command[0] == "sort")
            {

            }
            else if (command[0] == "filter")
            {

            }
            foreach (var VARIABLE in matrix)
            {
                Console.WriteLine(VARIABLE);
            }
        }
    }
}
