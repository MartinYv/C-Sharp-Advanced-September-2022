using System;

namespace _07._Tuple
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split();

			string fullName = input[0] + " " + input[1];

			string address = input[2];

			var firstTuple = new Tuple<string, string>(fullName, address);

			Console.WriteLine(firstTuple);

			input = Console.ReadLine().Split();

			string name = input[0];

			int beer = int.Parse(input[1]);

			var secondTuple = new Tuple<string, int>(name, beer);

			Console.WriteLine(secondTuple);

			input = Console.ReadLine().Split();

			int integer = int.Parse(input[0]);

			double realNumber = double.Parse(input[1]);

			var thirdTuple = new Tuple<int, double>(integer, realNumber);

			Console.WriteLine(thirdTuple);

		}
	}
}
