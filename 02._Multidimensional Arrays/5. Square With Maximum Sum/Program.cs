using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizeOfMatrix = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = sizeOfMatrix[0];
            int cols = sizeOfMatrix[1];
            var matrix = new int[rows, cols];

            int sumOfSquare = int.MinValue;
            int indexOfRow = -1;
            int indexOfCol = -1;

            for (int j = 0; j < rows; j++)
            {
                var currentRow = Console.ReadLine()
                     .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                     .Select(int.Parse)
                     .ToArray();
                for (int i = 0; i < cols; i++)
                {
                    matrix[j, i] = currentRow[i];
                }
            }
            for (int j = 0; j < rows - 1; j++)
            {
                for (int i = 0; i < cols - 1; i++)
                {
                    int currentSum = matrix[j, i] + matrix[j, i + 1]
                                   + matrix[j + 1, i] + matrix[j + 1, i + 1];
                    if (currentSum > sumOfSquare)
                    {
                        sumOfSquare = currentSum;
                        indexOfRow = j;
                        indexOfCol = i;
                    }
                }
            }
            Console.WriteLine($"{matrix[indexOfRow, indexOfCol]} " +
                              $"{matrix[indexOfRow, indexOfCol + 1]}");
            Console.WriteLine($"{matrix[indexOfRow + 1, indexOfCol]} " +
                              $"{matrix[indexOfRow + 1, indexOfCol + 1]}");
            Console.WriteLine(sumOfSquare);
        }
    }
}
