using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimension = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var rowsLength = dimension[0];
            var colsLength = dimension[1];
            int maxSum = int.MinValue;

            var matrix = new int[rowsLength, colsLength];
            var currentRow = 0;
            var currentCol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var inputNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputNumbers[col];
                }
            }
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                            + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                            + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum>maxSum)
                    {
                        maxSum = sum;
                        currentRow = row;
                        currentCol = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            for (int row = currentRow; row <= currentRow+2; row++)
            {
                for (int col = currentCol; col <= currentCol+2; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
