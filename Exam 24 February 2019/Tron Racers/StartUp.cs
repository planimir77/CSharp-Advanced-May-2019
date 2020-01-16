using System;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;

namespace Tron_Racers
{
    public class StartUp
    {
        static char[][] matrix;

        static int[] firstPlayer;
        static int[] secondPlayer;

        public static void Main(string[] args)
        {
            var sizeOfMatrix = int.Parse(Console.ReadLine());

            matrix = new char[sizeOfMatrix][];

            Initialize();

            while (!matrix.Any(x => x.Contains('x')))
            {
                var directions = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var firstPlayerDirection = directions[0];
                var secondPlayerDirection = directions[1];

                Move(firstPlayer, firstPlayerDirection);
                if (matrix.Any(x=>x.Contains('x')))
                {
                    break;
                }
                Move(secondPlayer, secondPlayerDirection);
            }
            
            Print(matrix);
        }

        private static void Print(char[][] matrix)
        {
            foreach (char[] row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }

        }

        private static void Move(int[] player, string direction)
        {
            var playerRow = player[0];
            var playerNewRow = playerRow;

            var playerCol = player[1];
            var playerNewCol = player[1];//TO DO

            if (direction == "up")
            {
                playerNewRow = playerRow - 1;
                if (playerNewRow < 0)
                {
                    playerNewRow = matrix.Length - 1;
                }

                if (matrix[playerNewRow][playerCol] == '*')
                {
                    matrix[playerNewRow][playerCol] = matrix[playerRow][playerCol];
                    if (matrix[playerNewRow][playerCol] == 'f')
                    {
                        firstPlayer[0] = playerNewRow;
                    }
                    else
                    {
                        secondPlayer[0] = playerNewRow;
                    }
                }
                else
                {
                    matrix[playerNewRow][playerCol] = 'x';
                }

            }
            else if (direction == "down")
            {
                playerNewRow = playerRow + 1;
                if (playerNewRow > matrix.Length - 1)
                {
                    playerNewRow = 0;
                }

                if (matrix[playerNewRow][playerCol] == '*')
                {
                    matrix[playerNewRow][playerCol] = matrix[playerRow][playerCol];
                    if (matrix[playerNewRow][playerCol] == 'f')
                    {
                        firstPlayer[0] = playerNewRow;
                    }
                    else
                    {
                        secondPlayer[0] = playerNewRow;
                    }
                }
                else
                {
                    matrix[playerNewRow][playerCol] = 'x';
                }

            }
            else if (direction == "left")
            {
                playerNewCol = playerCol - 1;
                if (playerNewCol < 0)
                {
                    playerNewCol = matrix[playerRow].Length - 1;
                }
                if (matrix[playerRow][playerNewCol] == '*')
                {
                    matrix[playerRow][playerNewCol] = matrix[playerRow][playerCol];
                    if (matrix[playerRow][playerNewCol] == 'f')
                    {
                        firstPlayer[1] = playerNewCol;
                    }
                    else
                    {
                        secondPlayer[1] = playerNewCol;
                    }
                }
                else
                {
                    matrix[playerRow][playerNewCol] = 'x';
                }
            }
            else if (direction == "right")
            {
                playerNewCol = playerCol + 1;
                if (playerNewCol > matrix[playerRow].Length - 1)
                {
                    playerNewCol = 0;
                }

                if (matrix[playerRow][playerNewCol] == '*')
                {
                    matrix[playerRow][playerNewCol] = matrix[playerRow][playerCol];
                    if (matrix[playerRow][playerNewCol] == 'f')
                    {
                        firstPlayer[1] = playerNewCol;
                    }
                    else
                    {
                        secondPlayer[1] = playerNewCol;
                    }
                }
                else
                {
                    matrix[playerRow][playerNewCol] = 'x';
                }
            }
        }

        private static void Initialize()
        {
            firstPlayer = new int[2];
            secondPlayer = new int[2];
            for (int row = 0; row < matrix.Length; row++)
            {
                // ReSharper disable once PossibleNullReferenceException
                var input = Console.ReadLine()
                    .ToCharArray();
                matrix[row] = new char[input.Length];


                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = input[col];
                    if (matrix[row][col] == 'f')
                    {
                        firstPlayer[0] = row;
                        firstPlayer[1] = col;
                    }
                    else if (matrix[row][col] == 's')
                    {
                        secondPlayer[0] = row;
                        secondPlayer[1] = col;
                    }
                }
            }
        }
    }
}
