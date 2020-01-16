using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        private List<Hero> heroes;

        public List<Hero> Heroes { get; private set; }

        public HeroRepository()
        {
            this.Heroes = new List<Hero>();
        }

        public int Count => this.Heroes.Count;

        public void Add(Hero hero)
        {
            this.Heroes.Add(hero);
        }

        public void Remove(string name)
        {
            this.Heroes.Remove(this.Heroes.FirstOrDefault(x => x.Name == name));
        }

        public Hero GetHeroWithHighestStrength()
        {
            var highestStrength = this.Heroes.Max(x=>x.Item.Strength);
            return this.Heroes.FirstOrDefault(x => x.Item.Strength == highestStrength);
        }

        public Hero GetHeroWithHighestAbility()
        {
            var highestAbility = this.Heroes.Max(x => x.Item.Ability);
            return this.Heroes.FirstOrDefault(x => x.Item.Ability == highestAbility);
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            var highestIntelligence = this.Heroes.Max(x => x.Item.Intelligence);
            return this.Heroes.FirstOrDefault(x => x.Item.Intelligence == highestIntelligence);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var hero in this.Heroes)
            {
                sb.AppendLine(hero.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
