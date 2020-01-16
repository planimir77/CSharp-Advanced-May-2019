using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Test
{
    public class Cat :IAnimal 
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
            return "Myau";
        }
    }
}
