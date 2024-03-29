﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Oldest_Family_Member
{
	class Person
	{
        private string name;
        private int age;

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
    }
}
