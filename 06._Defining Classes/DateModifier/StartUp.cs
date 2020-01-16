using System;
using System.Data;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var fromData = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var toData = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            DateModifier dateModifier = new DateModifier(fromData,toData);

            Console.WriteLine(dateModifier.GetDaysBetweenDates());

        }
    }
}
