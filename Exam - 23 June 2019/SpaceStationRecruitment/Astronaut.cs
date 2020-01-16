using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStationRecruitment
{
    public class Astronaut
    {
        private string _name;

        private int _age;

        private string _country;
        // name, age and country and override the ToString() 

        public Astronaut(string name, int age, string country)
        {
            this.Name = name;
            this.Age = age;
            this.Country = country;
        }

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

        public string Country
        {
            get => _country;
            set => _country = value;
        }

        public override string ToString()
        {
            // "Astronaut: {name}, {age} ({country})"

            var sb = new StringBuilder();
            sb.Append($"Astronaut: {this.Name}, {this.Age} ({this.Country})");
            return sb.ToString().TrimEnd();
        }
    }
}
