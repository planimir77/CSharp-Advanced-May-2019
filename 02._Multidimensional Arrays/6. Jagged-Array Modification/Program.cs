using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            var jagged = new int[rows][];

            for (int row = 0; row < jagged.Length; row++)
            {
                var currentRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                jagged[row] = new int[currentRow.Length];
                for (int col = 0; col < currentRow.Length; col++)
                {
                    jagged[row][col] = currentRow[col];
                }
            }
            string input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                var tokken = input.Split();
                var command = tokken[0];
                int rowValue = int.Parse(tokken[1]);
                int colValue = int.Parse(tokken[2]);
                int value = int.Parse(tokken[3]);

                for (int row = 0; row < jagged.Length; row++)
                {
                    if ((rowValue < 0 || rowValue > jagged.Length-1) 
                        || (colValue < 0 || colValue > jagged[row].Length-1))
                    {
                        Console.WriteLine("Invalid coordinates");
                        break;
                    }
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        
                        if (command.ToLower() == "add" && row == rowValue && col == colValue)
                        {
                            jagged[row][col] += value;
                            break;
                        }
                        else if (command.ToLower() == "subtract" && row == rowValue && col == colValue)
                        {
                            jagged[row][col] -= value;
                            break;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var item in jagged)
            {
                Console.WriteLine(String.Join(" ", item));
            }
        }
    }
}
