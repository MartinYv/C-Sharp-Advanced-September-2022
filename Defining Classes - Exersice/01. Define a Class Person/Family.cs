using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> familyMembers;
        private List<Person> sorted;
        public Family()
        {
            this.familyMembers = new List<Person>();
            this.sorted = new List<Person>();
        }

        
        public List<Person> Sorted { get; private set; }

        public void AddMember(Person member)
        {
            this.familyMembers.Add(member);
           
           this.Sorted= familyMembers.OrderBy(x => x.Name).Where(x=>x.Age > 30).ToList();
            
        }

        public Person GetOldestMember()
        {
            int maxAge = familyMembers.Max(x => x.Age);
            return familyMembers.First(x => x.Age == maxAge);
        }
         
        
    }
}
