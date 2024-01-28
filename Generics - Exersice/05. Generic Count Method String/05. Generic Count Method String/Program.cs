using GenericCountMethodString;
using System;
using System.Collections.Generic;

namespace _05._Generic_Count_Method_String
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Box<string>> boxes = new List<Box<string>>();

			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				Box<String> box = new Box<string>(Console.ReadLine());

				boxes.Add(box);
			}

			string compare = Console.ReadLine();

			Console.WriteLine(Count(boxes, compare));
		}

		public static int Count<T>(List<Box<T>> list, T element) where T : IComparable<T>
		{
			int count = 0;

			foreach (var item in list)
			{
				if (item.CompareTo(element) > 0)
				{
					count++;
				}
			}
			return count;
		}
	}
}
