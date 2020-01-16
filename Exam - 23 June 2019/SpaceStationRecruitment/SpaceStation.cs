using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SpaceStationRecruitment
{
    public class SpaceStation
    {
        private string _name;
        private int _capacity;
        private List<Astronaut> _data;

        public SpaceStation(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this._data = new List<Astronaut>();
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Capacity
        {
            get => _capacity;
            set => _capacity = value;
        }

        public void Add(Astronaut astronaut) //– adds an entity to the data if there is room for him/her.
        {
            if (this._data.Count < this.Capacity)
            {
                _data.Add(astronaut);
            }
        }

        public bool Remove(string name) //– removes an astronaut by given name, if such exists, and returns bool.
        {
            // var astro = this._data.FirstOrDefault(x=>_name == name);
            if (!this._data.Contains(this._data.FirstOrDefault(x => _name == name))) return false;
            {
                this._data.Remove(this._data.FirstOrDefault(x => _name == name));
                return true;
            }
        }

        public Astronaut GetOldestAstronaut() //– returns the oldest astronaut.
        {
            var ageMax = this._data.Max(x=>x.Age);
            return this._data.FirstOrDefault(x => x.Age == ageMax);
        }

        public Astronaut GetAstronaut(string name) //– returns the astronaut with the given name.
        {
            return this._data.FirstOrDefault(x => x.Name == name);
        }

        public int Count => this._data.Count; // – returns the number of astronauts.

        public string Report() //– returns a string in the following format:
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Astronauts working at Space Station {this.Name}:");
            foreach (var astronaut in this._data)
            {
                sb.AppendLine(astronaut.ToString());
            }

            return sb.ToString().TrimEnd();
        }

    }
}
