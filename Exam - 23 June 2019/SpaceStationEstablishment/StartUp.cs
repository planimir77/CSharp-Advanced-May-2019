using System;
using System.Dynamic;
using System.Linq;

namespace SpaceStationEstablishment
{
    public class StartUp
    {
        static char[][] matrix;
        static int[] spaceship;

        private static int energy = 0;

        public static void Main()
        {
            var matrixSize = int.Parse(Console.ReadLine());

            matrix = new char[matrixSize][];

            bool outOfSpace = false;

            Initialize();

            var command = Console.ReadLine();
            while (true)
            {
                int currentRow = spaceship[0];
                int currentCol = spaceship[1];
                char sing = ' ';

                if (command == "up" && IsPositionValid(currentRow - 1, currentCol))
                {
                    sing = matrix[currentRow - 1][currentCol];
                    matrix[currentRow - 1][currentCol] = 'S';
                    spaceship[0] = currentRow - 1;
                    matrix[currentRow][currentCol] = '-';

                }
                else if (command == "down" && IsPositionValid(currentRow + 1, currentCol))
                {
                    sing = matrix[currentRow + 1][currentCol];
                    matrix[currentRow + 1][currentCol] = 'S';
                    spaceship[0] = currentRow + 1;
                    matrix[currentRow][currentCol] = '-';
                }
                else if (command == "left" && IsPositionValid(currentRow, currentCol - 1))
                {
                    sing = matrix[currentRow][currentCol - 1];
                    matrix[currentRow][currentCol - 1] = 'S';
                    spaceship[1] = currentCol - 1;
                    matrix[currentRow][currentCol] = '-';
                }
                else if (command == "right" && IsPositionValid(currentRow, currentCol + 1))
                {
                    sing = matrix[currentRow][currentCol + 1];
                    matrix[currentRow][currentCol + 1] = 'S';
                    spaceship[1] = currentCol + 1;
                    matrix[currentRow][currentCol] = '-';
                }
                else
                {
                    Console.WriteLine($"Bad news, the spaceship went to the void.");
                    
                    outOfSpace = true;
                    break;
                }

                //var position = matrix[currentRow][currentCol];
                if (int.TryParse(sing.ToString(), out int result))
                {
                    energy += result;
                    if (energy >= 50)
                    {
                        break;
                    }
                }
                else if (sing == 'O')
                {
                    int[] blackHole = GetElement(matrix,'O');
                    int[] getS = GetElement(matrix, 'S');
                    matrix[blackHole[0]][blackHole[1]] = 'S';
                    spaceship[0] = blackHole[0];
                    spaceship[1] = blackHole[1];
                    matrix[getS[0]][getS[1]] = '-';
                }

                command = Console.ReadLine();
            }

            if (!outOfSpace)
            {
                Console.WriteLine($"Good news! Stephen succeeded in collecting enough star power");
            }
            Console.WriteLine($"Star power collected: {energy}");
            Print(matrix);
        }

        private static void Print(char[][] matrix)
        {
            foreach (char[] row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }

        }

        private static int[] GetElement(char[][] c, char sing)
        {
            var hole = new int[2];
            for (int row = 0; row < matrix.Length; row++)
            {

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    //matrix[row][col] = input[col];
                    if (matrix[row][col] == sing)
                    {
                        hole[0] = row;
                        hole[1] = col;
                    }
                }
            }

            return hole;
        }

        private static bool IsPositionValid(int currentRow, int currentCol)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (row == currentRow && col == currentCol)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private static void Initialize()
        {
            spaceship = new int[2];
            for (int row = 0; row < matrix.Length; row++)
            {
                // input for every row
                var input = Console.ReadLine()
                    .ToCharArray();

                matrix[row] = new char[input.Length];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = input[col];
                    if (matrix[row][col] == 'S')
                    {
                        spaceship[0] = row;
                        spaceship[1] = col;
                    }
                }
            }
        }
    }
}
