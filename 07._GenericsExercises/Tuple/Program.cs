using System;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine()
                .Split();

            string[] personBeerInfo = Console.ReadLine()
                .Split();

            string[] numberInfo = Console.ReadLine()
                .Split();

            var personTuple = new Tuple<string, string>(personInfo[0]+" "+personInfo[1], personInfo[2]);

            var personBeerTuple = new Tuple<string, int>(personBeerInfo[0], int.Parse(personBeerInfo[1]));

            var numberTuple = new Tuple<int, double>(int.Parse(numberInfo[0]), double.Parse(numberInfo[1]));

            Console.WriteLine(personTuple.GetInfo());
            Console.WriteLine(personBeerTuple.GetInfo());
            Console.WriteLine(numberTuple.GetInfo());
        }
    }
}
