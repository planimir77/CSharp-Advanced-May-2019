using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var names = new HashSet<String>();

            for (int i = 0; i < number; i++)
            {
                string inputName = Console.ReadLine();
                names.Add(inputName);
            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
