using System;
using System.Linq;
using System.Collections.Generic;

namespace HelensAbduction
{
    public class Program
    {
        public static void Main()
        {
            int parisEnergy = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            
            var warField = new char[rows][];

            for (int row = 0; row < warField.Length; row++)
            {
                var currentRow = Console.ReadLine().ToCharArray();
                warField[row] = new char[ currentRow.Length ];
                for (int col = 0; col < warField[row].Length; col++)
                {
                    warField[row][col] = currentRow[col];
                }

            }

            while (true)
            {
                var command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var directionOfParis = command[0];
                var spawnRow = int.Parse(command[1]);
                var spawnCol = int.Parse(command[2]);

                // set enemy position
                warField[spawnRow][ spawnCol] = 'S';

                // move Paris
                var parisOldPosition = GetParisPosition(warField);

                var parisOldRow = parisOldPosition[0];
                var parisOldCol = parisOldPosition[1];

                var parisNewRow = parisOldRow;
                var parisNewCol = parisOldCol;

                switch (directionOfParis)
                {
                    case "up": parisNewRow -= 1; break;
                    case "down": parisNewRow += 1; break;
                    case "left": parisNewCol -= 1; break;
                    case "right": parisNewCol += 1; break;
                }

                parisEnergy -= 1;

                if (IsNewPositionValid(warField, parisNewRow, parisNewCol))
                {
                    if (warField[parisNewRow][ parisNewCol] == 'H')
                    {
                        warField[parisNewRow][parisNewCol] = '-';
                        warField[parisOldRow][parisOldCol] = '-';
                        Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {parisEnergy}");
                        PrintWarField(warField);
                        break ;
                    }
                    else if (warField[parisNewRow][parisNewCol] == 'S')
                    {
                        parisEnergy -= 2;
                        if (parisEnergy <= 0)
                        {
                            warField[parisNewRow][parisNewCol] = 'X';
                            warField[parisOldRow][parisOldCol] = '-';
                            Console.WriteLine($"Paris died at {parisNewRow};{parisNewCol}.");
                            PrintWarField(warField);
                            break; ;
                        }
                        else
                        {
                            warField[parisNewRow][parisNewCol] = 'P';
                            warField[parisOldRow][parisOldCol] = '-';
                        }
                    }
                    else
                    {
                        warField[parisNewRow][parisNewCol] = 'P';
                        warField[parisOldRow][parisOldCol] = '-';
                        if (parisEnergy <= 0)
                        {
                            warField[parisNewRow][parisNewCol] = 'X';
                            Console.WriteLine($"Paris died at {parisNewRow};{parisNewCol}.");
                            PrintWarField(warField);
                            break;
                        }
                    }
                }
                if (parisEnergy <= 0)
                {
                    Console.WriteLine($"Paris died at {parisOldRow};{parisOldCol}.");
                    PrintWarField(warField);
                    break ; 
                }
            }
        }

        private static void PrintWarField(char[][] warField)
        {
            for (int row = 0; row < warField.Length; row++)
            {
                for (int col = 0; col < warField[row].Length; col++)
                {
                    Console.Write(warField[row][col]);
                }
                Console.WriteLine();
            }
        }

        private static bool IsNewPositionValid(char[][] warField, int parisRow, int parisCol)
        {
            var position = new List<int[]>();
            for (int row = 0; row < warField.Length; row++)
            {
                for (int col = 0; col < warField[row].Length; col++)
                {
                    position.Add(new int[2] { row, col });
                }
            }
            foreach (var item in position)
            {
                if (item?[0] == parisRow && item?[1] == parisCol)
                {
                    return true;
                }

            }
            return false;
        }

        private static int[] GetParisPosition(char[][] warField)
        {
            for (int row = 0; row < warField.Length; row++)
            {
                for (int col = 0; col < warField[row].Length; col++)
                {
                    if (warField[row][col] == 'P')
                    {
                        return new int[2] { row, col };
                    }
                }
            }
            return new int[2] { 0, 0 };
        }
    }
}
