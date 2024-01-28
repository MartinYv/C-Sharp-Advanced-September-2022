using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Opinion_Poll
{
	class Person
	{

		private string name;
		private int age;

		public string Name
		{
			get { return this.name; }
			set { this.name = value; }
		}
		public int Age
		{
			get { return this.age; }
			set { this.age = value; }
		}

		public Person()
		{

		}

		public Person(int age) : this()
		{
			this.Age = age;
		}

		public Person(string name, int age) : this(age)
		{
			this.Name = name;
		}
	}
}
