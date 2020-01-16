using System;
using System.Linq;

namespace _6._Bomb_the_Basement
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimension = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var rows = dimension[0];
            var cols = dimension[1];
            var matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = 0;
                }
            }

            var bombCoordinates = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var targetRow = bombCoordinates[0];
            var targetCol = bombCoordinates[1];
            var radius = bombCoordinates[2];
            

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                { 
                    matrix[targetRow, targetCol] = 1;
                    
                }
            }

            
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
