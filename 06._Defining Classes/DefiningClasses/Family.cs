using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> familyMember;

        public Family()
        {
            this.familyMember = new List<Person>();
        }

        public void AddMember(Person person)
        {
            familyMember.Add(person);
        }
        public Person GetOldestMember()
        {

            Person person = familyMember.OrderByDescending(x => x.Age).FirstOrDefault();
            return person;
        }
        

    }
}
