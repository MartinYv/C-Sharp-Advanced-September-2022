using System;

namespace _05._Date_Modifier
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] firstDate = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int[] secondDate = Console.ReadLine().Split().Select(int.Parse).ToArray();

			DateModifier dateModifier = new DateModifier();

			Console.WriteLine(Math.Abs(dateModifier.GetDifference(firstDate, secondDate).TotalDays));
		}
	}
}
