using System;
using System.Linq;
using System.IO;

namespace Problem_1._Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            var sourse = @"text.txt";
            //{ "-", ",", ".", "!", "?" };
            
            using (var streamReader = new StreamReader(sourse))
            {
                var text = streamReader.ReadLine();
                var count = 0;

                while (text != null)
                {

                    if (count % 2 == 0)
                    {
                        text = ReplaceText(text);
                        text = ReversWord(text);
                        Console.WriteLine(text);
                    }
                    
                    text = streamReader.ReadLine();
                    count++;
                }
            }

        }

        private static string ReversWord(string text)
        {
            return String.Join(" ", text.Split().Reverse());
        }

        private static string ReplaceText(string text)
        {
            return text.Replace('-', '@').
                        Replace(',', '@').
                        Replace('.', '@').
                        Replace('!', '@').
                        Replace('?', '@');

        }               
    }                   
}                       
                        