using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            int numberOfRow = matrixSize[0];
            int numberOfCol = matrixSize[1];

            int[,] matrix = new int[numberOfRow,numberOfCol];
            int sum = 0;

            for (int row = 0; row < numberOfRow; row++)
            {
                var matrixCol = Console.ReadLine()
                          .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                          .Select(int.Parse)
                          .ToArray();
                for (int col = 0; col < numberOfCol; col++)
                {
                    matrix[row, col] = matrixCol[col];
                    sum += matrixCol[col];
                }
            }
            Console.WriteLine(numberOfRow);
            Console.WriteLine(numberOfCol);
            Console.WriteLine(sum);
        }
    }
}
