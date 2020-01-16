using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareMatrix = int.Parse(Console.ReadLine());

            var matrix = new int[squareMatrix, squareMatrix];
            var sumPrimary = 0;
            var sumSecondary = 0;

            for (int row = 0; row < squareMatrix; row++)
            {
                int[] array = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                
                for (int col = 0; col < squareMatrix; col++)
                {
                    matrix.[row,col] = array[col];
                }
                sumPrimary += matrix[row, row];
                sumSecondary += matrix[row,squareMatrix-1-row];
            }
            Console.WriteLine(Math.Abs(sumPrimary-sumSecondary));
        }
    }
}
