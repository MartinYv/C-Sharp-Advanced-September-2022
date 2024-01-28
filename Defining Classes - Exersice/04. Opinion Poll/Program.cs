using System;

namespace _04._Opinion_Poll
{
	class Program
	{
		static void Main(string[] args)
		{
            var people = new List<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                if (age > 30)
                {
                    people.Add(person);
                }
            }

            foreach (var person in people.OrderBy(p => p.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
	}
}
