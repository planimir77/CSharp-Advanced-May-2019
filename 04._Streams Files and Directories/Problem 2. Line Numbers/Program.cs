using System;
using System.Linq;
using System.IO;

namespace Problem_2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"text.txt";
            string newFile = @"output.txt";
            var lineCount = 0;
            var text = File.ReadAllLines(filePath);
            foreach (var item in text)
            {
                lineCount++;
                File.AppendAllText(newFile, $"Line {lineCount}:" +
                    $" {item} ({NumberOfLetters(item)})({NumberOfPunctuation(item)}){Environment.NewLine}");
            }
        }

        private static int NumberOfPunctuation(string text)
        {
            int number = 0;
            foreach (var item in text)
            {
                if (Char.IsPunctuation(item))
                {
                    number++;
                }
            }
            return number;
        }

        private static int NumberOfLetters(string text)
        {
            int number = 0;
            foreach (var item in text)
            {
                if (Char.IsLetter(item))
                {
                    number++;
                }
            }
            return number;
        }
    }
}
