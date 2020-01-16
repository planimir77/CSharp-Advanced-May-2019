using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problem_3._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string textPath = "text.txt";
            string wordsPath = "words.txt";
            string actualResultPath = "actualResult.txt";
            string expectedResultPath = "expectedResult.txt";

            string[] textLines = File.ReadAllLines(textPath);
            string[] words = File.ReadAllLines(wordsPath);

            var wordsInfo = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string currentWord = word.ToLower();
                if (!wordsInfo.ContainsKey(currentWord))
                {
                    wordsInfo[currentWord] = 0;
                }
            }
            var sing = new char[] { ' ', '-', '?', '.', '!' ,',',':','\'',';'};
            foreach (var currentLine in textLines)
            {
                
                string[] currentLineWords = currentLine.ToLower().Split(sing,StringSplitOptions.RemoveEmptyEntries);
                foreach (var currentWord in currentLineWords)
                {
                    if (wordsInfo.ContainsKey(currentWord))
                    {
                        wordsInfo[currentWord.ToLower()] ++;
                    }
                }
            }
            foreach (var (key,value) in wordsInfo)
            {
                File.AppendAllText(actualResultPath,$"{key} - {value}{Environment.NewLine}");
            }
            foreach (var (key, value) in wordsInfo.OrderByDescending(x => x.Value))
            {
                File.AppendAllText(expectedResultPath, $"{key} - {value}{Environment.NewLine}");
            }
        }
    }
}
