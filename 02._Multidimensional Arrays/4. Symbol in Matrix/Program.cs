using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareSize = int.Parse(Console.ReadLine());
            var matrix = new char[squareSize, squareSize];

            for (int j = 0; j < squareSize; j++)
            {
                var currentRow = Console.ReadLine().ToCharArray();
                for (int i = 0; i < squareSize; i++)
                {
                    matrix[j, i] = currentRow[i];
                }
            }
            char simbol = char.Parse(Console.ReadLine());
            for (int j = 0; j < squareSize; j++)
            {
                for (int i = 0; i < squareSize; i++)
                {
                    char currentSimbol = matrix[j, i];
                    if (currentSimbol == simbol)
                    {
                        Console.WriteLine($"({j}, {i})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{simbol} does not occur in the matrix");
        }
    }
}
