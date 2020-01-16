using System;
using System.Linq;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Family family = new Family();
            var people = new List<Person>();

            for (int i = 0; i < count; i++)
            {
                var member = Console.ReadLine()
                    .Split();
                var name = member[0];
                var age = int.Parse(member[1]);
                Person person = new Person(name, age);
                if (person.Age>30)
                {
                    people.Add(person);
                }
                family.AddMember(person);
            }

            foreach (var humman in people.OrderBy(x=>x.Name))
            {
                Console.WriteLine($"{humman.Name} - {humman.Age}");
            }
            
            
        }
    }
}
