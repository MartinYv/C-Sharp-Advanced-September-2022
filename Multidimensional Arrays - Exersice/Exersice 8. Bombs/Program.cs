using System;
using System.Linq;

namespace Exersice_8._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
             int number = int.Parse(Console.ReadLine());

        int[,] matrix = new int[number, number];

        for (int i = 0; i < number; i++)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int j = 0; j < number; j++)
            {
                matrix[i, j] = data[j];
            }
        }

        bool[,] bombLocations = new bool[number, number];

        string[] bombs = Console.ReadLine().Split();

        for (int i = 0; i < bombs.Length; i++)
        {
            int[] indexes = bombs[i].Split(",").Select(int.Parse).ToArray();

            int row = indexes[0], col = indexes[1];

            bombLocations[row, col] = true;

            if (bombLocations[row, col] == true && matrix[row, col] > 0)
            {
                if (row - 1 >= 0)
                {
                    if (matrix[row - 1, col] > 0)
                    {
                        matrix[row - 1, col] -= matrix[row, col];
                    }

                    if (col - 1 >= 0)
                    {
                        if (matrix[row - 1, col - 1] > 0)
                        {
                            matrix[row - 1, col - 1] -= matrix[row, col];
                        }
                    }

                    if (col + 1 < number)
                    {
                        if (matrix[row - 1, col + 1] > 0)
                        {
                            matrix[row - 1, col + 1] -= matrix[row, col];
                        }
                    }
                }

                if (col - 1 >= 0)
                {
                    if (matrix[row, col - 1] > 0)
                    {
                        matrix[row, col - 1] -= matrix[row, col];
                    }
                }

                if (col + 1 < number)
                {
                    if (matrix[row, col + 1] > 0)
                    {
                        matrix[row, col + 1] -= matrix[row, col];
                    }
                }

                if (row + 1 < number)
                {
                    if (matrix[row + 1, col] > 0)
                    {
                        matrix[row + 1, col] -= matrix[row, col];
                    }
                    
                    if (col - 1 >= 0)
                    {
                        if (matrix[row + 1, col -1 ] > 0)
                        {
                            matrix[row + 1, col - 1] -= matrix[row, col];
                        }
                    }

                    if (col + 1 < number)
                    {
                        if (matrix[row + 1, col + 1] > 0)
                        {
                            matrix[row + 1, col + 1] -= matrix[row, col];
                        }
                    }
                }

                matrix[row, col] = 0;
            }
        }

        var stringBuilder = new StringBuilder();
        int cells = 0, sum = 0;

        for (int row = 0; row < number; row++)
        {
            string line = string.Empty;

            for (int col = 0; col < number; col++)
            {
                if (matrix[row, col] > 0)
                {
                    cells++;
                    sum += matrix[row, col];
                }

                line += matrix[row, col] + " ";
            }
            stringBuilder.AppendLine(line);
        }
        Console.WriteLine($"Alive cells: {cells}");
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine(stringBuilder.ToString().TrimEnd());
    }
}
    
