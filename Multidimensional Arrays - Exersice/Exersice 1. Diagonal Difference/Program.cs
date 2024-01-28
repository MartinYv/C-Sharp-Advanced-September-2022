using System;
using System.Linq;

namespace Exersice_1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];
            int sum = 0;

            for (int row = 0; row < size; row++)
            {
                int[] colInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = colInfo[col];
                }
            }

            for (int i = 0; i < size; i++)
            {
                sum += matrix[i, i];
            }

            int rol = 0;
            int sum2 = 0;

            for (int k = size - 1; k >= 0; k--)
            {

                sum2 += matrix[k, rol];
                rol++;
            }

            Console.WriteLine(Math.Abs(sum - sum2));
        }
    }
}

