using System;

namespace _08._Threeuple
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split();

			string fullName = input[0] + " " + input[1];
			string address = input[2];
			string town = input[3];

			var firstThreeuple = new Threeuple<string, string, string>(fullName, address, town);

			Console.WriteLine(firstThreeuple);

			input = Console.ReadLine().Split();

			string name = input[0];
			int beer = int.Parse(input[1]);
			string state = input[2];

			bool isDrunk = false;

			if (state == "drunk")
			{
				isDrunk = true;

			}

			var secondThreeuple = new Threeuple<string, int, bool>(name, beer, isDrunk);

			Console.WriteLine(secondThreeuple);

			input = Console.ReadLine().Split();

			name = input[0];
			double accountBalance = double.Parse(input[1]);
			string bankName = input[2];

			var thirdThreeuple = new Threeuple<string, double, string>(name, accountBalance, bankName);

			Console.WriteLine(thirdThreeuple);
		}
	}
	}
