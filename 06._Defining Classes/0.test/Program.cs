using System;

namespace _0.test
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int sum = 0;
            foreach (var item in name)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}
