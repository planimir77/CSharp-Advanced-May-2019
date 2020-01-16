
namespace _4._Matrix_shuffling
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            var dimension = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var rowsLength = dimension[0];
            var colsLength = dimension[1];

            var matrix = new string[rowsLength, colsLength];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var inputNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputNumbers[col];
                }
            }
            string input = Console.ReadLine();
            while (input != "END")
            {
                var tokken = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokken[0]=="swap")
                {
                    var command = tokken[0];
                    var row1 = int.Parse(tokken[1]);
                    var col1 = int.Parse(tokken[2]);
                    var row2 = int.Parse(tokken[3]);
                    var col2 = int.Parse(tokken[4]);
                    bool isInputValid = isValid(rowsLength, colsLength, row1, col1, row2, col2);
                    if (isInputValid && tokken.Length == 5)
                    {
                        var temp = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = temp;
                        int count = 0;
                        foreach (var item in matrix)
                        {
                            count++;
                            Console.Write(item + " ");
                            if (count == colsLength)
                            {
                                Console.WriteLine();
                                count = 0;
                            }

                        }
                        //Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine();
                    continue;
                }



                input = Console.ReadLine();
            }


        }

        private static bool isValid(int rowsLength, int colsLength, int row1, int col1, int row2, int col2)
        {
            return (row1 >= 0 && row1 < rowsLength 
                 && col1 >= 0 && col1 < colsLength 
                 && row2 >= 0 && row2 < rowsLength
                 && col2 >= 0 && col2 < colsLength);
        }
    }
}
