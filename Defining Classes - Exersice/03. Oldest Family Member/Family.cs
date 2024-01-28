using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Oldest_Family_Member
{
	class Family
	{
        public Family()
        {
            People = new List<Person>();
        }

        public List<Person> People { get; private set; }

        public void AddMember(Person person)
        {
            People.Add(person);
        }

        public Person GetOldestMember()
        {
            return People.OrderByDescending(p => p.Age).FirstOrDefault();
        }
    }
}
