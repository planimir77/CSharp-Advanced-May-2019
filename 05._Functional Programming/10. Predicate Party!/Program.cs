using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = Console.ReadLine().Split().ToList();
            var input = Console.ReadLine();
            //var currentPeople = people.Select(x => x.StartsWith('P'));
            Func<string, string, bool> startWith = (x, y) => x.StartsWith(y);
            Func<string, string, bool> endWith = (x, y) => x.EndsWith(y);
            Func<string, int, bool> lengthWith = (x, y) => x.Length == y;
            while (input != "Party!")
            {
                string[] tokken = input.Split();
                var command = tokken[0];
                var criteria = tokken[1];
                var sing = tokken[2];
                if (command == "Remove")
                {
                    if (criteria == "StartsWith")
                    {
                        people.Remove(people.Where(x => startWith(x, sing))
                            .FirstOrDefault()
                            .ToString());

                    }
                    else if (criteria == "EndsWith")
                    {
                        people.Remove(people.Where(x => endWith(x, sing))
                            .FirstOrDefault()
                            .ToString());
                    }
                    else if (criteria == "Length")
                    {
                        people.Remove(people.Where(x => lengthWith(x, int.Parse(sing)))
                            .FirstOrDefault()
                            .ToString());
                    }
                }
                else if (command == "Double")
                {
                    if (criteria == "StartsWith")
                    {

                        people.Insert(people
                            .IndexOf(people.Where(x => startWith(x, sing))
                            .FirstOrDefault()
                            .ToString())
                            ,people
                            .Where(x => startWith(x, sing))
                            .FirstOrDefault()
                            .ToString());

                    }
                    else if (criteria == "EndsWith")
                    {
                        people.Insert(people
                            .IndexOf(people.Where(x => endWith(x, sing))
                            .FirstOrDefault()
                            .ToString())
                            , people
                            .Where(x => endWith(x, sing))
                            .FirstOrDefault()
                            .ToString());
                    }
                    else if (criteria == "Length")
                    {
                        
                    }
                }
                input = Console.ReadLine();
            }
            if (people.Count > 0)
            {
                Console.Write(String.Join(", ",people));
                Console.WriteLine(" are going to the party!");
            }
        }
    }
}
