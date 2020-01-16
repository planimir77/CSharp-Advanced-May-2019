using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Dog : IAnimal
    {
        private string _name;
        private int _age;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        public string SaySamthing()
        {
            return "Bau";
        }
    }
}
