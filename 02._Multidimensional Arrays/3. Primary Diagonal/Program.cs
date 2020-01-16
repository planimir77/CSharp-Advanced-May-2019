using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[squareSize, squareSize];
            int sumOfDiagonal = 0;
            for (int j = 0; j < squareSize; j++)
            {
                var currentRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int i = 0; i < squareSize; i++)
                {
                    matrix[j, i] = currentRow[i];
                    if (j==i)
                    {
                        sumOfDiagonal += currentRow[i];
                    }
                }
            }
            Console.WriteLine(sumOfDiagonal);
        }
    }
}
