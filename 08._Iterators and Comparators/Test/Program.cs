using System;
using System.Collections.Generic;

namespace Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IAnimal cat = new Cat();
            cat.Name = "jsjsj";
            cat.Age = 3;
            IAnimal dog = new Dog();
            Console.WriteLine(dog.SaySamthing());
            Console.WriteLine(cat.Age);
        }
    }
}