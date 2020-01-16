namespace TheGarden
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());

            var garden = new string[numberOfRows][];

            var vegetables = new Dictionary<string, int>
            {//•	Lettuce  – 'L', Potatoes – 'P', Carrots  – 'C'
                {"L",0 },
                {"P",0 },
                {"C",0 }
            };
            var harmedVegetables = 0;

            for (int row = 0; row < garden.Length; row++)
            {
                var currentRow = Console.ReadLine().Split();
                garden[row] = new string[currentRow.Length];
                for (int col = 0; col < garden[row].Length; col++)
                {
                    garden[row][col] = currentRow[col];
                }
            }
            string input = Console.ReadLine();
            while (input != "End of Harvest")
            {
                var tokken = input
                    .Split();
                var command = tokken[0];
                var currentRow = int.Parse(tokken[1]);
                var currentCol = int.Parse(tokken[2]);
                var direction = String.Empty;
                if (IsPositionValid(garden, currentRow, currentCol))
                {
                    if (command == "Harvest" && vegetables.ContainsKey(garden[currentRow][currentCol]))
                    {
                        vegetables[garden[currentRow][currentCol]] += 1;
                        garden[currentRow][currentCol] = " ";
                    }
                    else if (command== "Mole")
                    {
                        direction = tokken[3];
                        while (IsPositionValid(garden, currentRow, currentCol))
                        {
                            if (vegetables.ContainsKey(garden[currentRow][currentCol]))
                            {
                                harmedVegetables += 1;
                                garden[currentRow][currentCol] = " ";
                            }
                            if (direction == "up")
                            {
                                currentRow -= 2;
                            }
                            else if (direction == "down")
                            {
                                currentRow += 2;
                            }
                            else if (direction == "left")
                            {
                                currentCol -= 2;
                            }
                            else if (direction == "right")
                            {
                                currentCol += 2;
                            }
                        }
                        
                    }
                }
                input = Console.ReadLine();
            }
            for (int row = 0; row < garden.Length; row++)
            {
                for (int col = 0; col < garden[row].Length; col++)
                {
                    Console.Write($"{garden[row][col]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Carrots: {vegetables["C"]}{Environment.NewLine}" +
                $"Potatoes: { vegetables["P"]}{Environment.NewLine}" +
                $"Lettuce: { vegetables["L"]}{Environment.NewLine}" +
                $"Harmed vegetables: { harmedVegetables} ");
        }

        private static bool IsPositionValid(string[][] garden, int currentRow, int currentCol)
        {
            for (int row = 0; row < garden.Length; row++)
            {
                for (int col = 0; col < garden[row].Length; col++)
                {
                    if (row == currentRow && col == currentCol)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
