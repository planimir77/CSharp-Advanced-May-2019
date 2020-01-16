using System;
using System.Linq;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());

            var triangle = new long[height][];
            for (int row = 0; row < triangle.Length; row++)
            {
                triangle[row] = new long[row + 1];
                for (int col = 0; col < row+1; col++)
                {
                    if (col==0 || col==triangle[row].Length-1)
                    {
                        triangle[row][col] = 1;
                    }
                    else
                    {
                        triangle[row][col] = triangle[row-1][col-1]+ triangle[row-1][col];
                    }
                    
                }
            }
            foreach (var item in triangle)
            {
                Console.WriteLine(String.Join(' ',item));
            }
        }
    }
}
