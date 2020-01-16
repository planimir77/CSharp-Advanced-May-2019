using System;
using System.Linq;

namespace GenericBoxOfString
{
    public class Program
    {
        static void Main(string[] args)
        {
            var box = new Box<double>();

            int count = int.Parse(Console.ReadLine());


            for (int i = 0; i < count; i++)
            {
                //int input = int.Parse(Console.ReadLine());
                double input = double.Parse(Console.ReadLine());

                box.Add(input);
            }

            var item = double.Parse(Console.ReadLine());

            box.Compare(item);

            Console.WriteLine(box.Count);
            
        }
    }
}
