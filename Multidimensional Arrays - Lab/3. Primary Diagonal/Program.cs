using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] rowsData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = rowsData[col];                 
                }
            }

            int sum = 0;                                //   0 1 2
            for (int i = 0; i < size; i++)              // 0|0|1|2|   [0][0]  
            {                                           // 1|0|1|2|           + [1][1]
                sum += matrix[i, i];                    // 2|0|1|2|                      + [2][2]
            }

            Console.WriteLine(sum);

        }
    }
}
