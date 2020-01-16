using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int row = size[0];
            int col = size[1];

            int[,] matrix = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                var tokken = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = tokken[j];
                }
            }
            for (int i = 0; i < col; i++)
            {
                int sum = 0;
                for (int j = 0; j < row; j++)
                {
                    sum += matrix[j, i];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
