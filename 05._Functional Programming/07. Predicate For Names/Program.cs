using System;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int nameLengths = int.Parse(Console.ReadLine());
            
            string[] names = Console.ReadLine()
                .Split();

            Predicate<string> nameWithLength = x => x.Length <= nameLengths;

            foreach (var item in names.Where(x => nameWithLength(x)))
            {
                Console.WriteLine(item);
            }
        }
    }
}
