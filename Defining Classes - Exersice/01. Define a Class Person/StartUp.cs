using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
         Family family = new Family();
            int countOfMembers = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfMembers; i++)
            {
                string[] data = Console.ReadLine().Split();
                string name = data[0];
                int age = int.Parse(data[1]);


                
                Person person = new Person(name, age);
                    family.AddMember(person);

                
            }

            foreach (var item in family.Sorted)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
            


            }

    }
}
