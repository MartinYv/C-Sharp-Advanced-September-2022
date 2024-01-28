using System;

namespace _7._Pascal_Triangle
{
	class Program
	{
		static void Main(string[] args)
		{
            int number = int.Parse(Console.ReadLine());

            long[][] triangle = new long[number][];

            for (int i = 0; i < number; i++)
            {
                triangle[i] = new long[i + 1];
                triangle[i][0] = 1;
                triangle[i][i] = 1;
            }

            for (int i = 0; i < number; i++)
            {
                if (triangle[i].Length > 2)
                {
                    for (int j = 1; j < triangle[i].Length - 1; j++)
                    {
                        triangle[i][j] = triangle[i - 1][j] + triangle[i - 1][j - 1];
                    }
                }
            }

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < triangle[i].Length; j++)
                {
                    Console.Write($"{triangle[i][j]} ");
                }
                Console.WriteLine();
            }
        }
	}
}
