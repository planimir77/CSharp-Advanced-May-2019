using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokken = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            var rowsLength = int.Parse(tokken[0]);
            var colsLength = int.Parse(tokken[1]);
            int squareCount = 0;

            var matrix = new char[rowsLength, colsLength];

            for (int row = 0; row < rowsLength; row++)
            {
                var matrixRow = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < colsLength; col++)
                {
                    matrix[row, col] = matrixRow[col];

                    if (row > 0 && col > 0)
                    {
                        char currentChar = matrixRow[col];

                        if (currentChar == matrix[row, col - 1]
                            && currentChar == matrix[row - 1, col]
                            && currentChar == matrix[row - 1, col - 1])
                        {
                            squareCount++;
                        }

                    }
                }
            }
            Console.WriteLine(squareCount);
        }
    }
}
