using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var simbols = new SortedDictionary<char, int>();
            foreach (char simbol in text)
            {
                if (!simbols.ContainsKey(simbol))
                {
                    simbols[Convert.ToChar(simbol)] = 0;
                }
                simbols[simbol]++;
            }
            foreach (var simbol in simbols)
            {
             
                Console.WriteLine($"{simbol.Key}: {simbol.Value} time/s");
            }

        }
    }
}
