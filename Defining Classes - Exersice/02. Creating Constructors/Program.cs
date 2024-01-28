using System;

namespace _02._Creating_Constructors
{
	class Program
	{
		static void Main(string[] args)
		{
			Person firstPerson = new Person();

			Person secondPerson = new Person(20);

			Person thirdPerson = new Person("Marto", 26);
		}
	}
}
