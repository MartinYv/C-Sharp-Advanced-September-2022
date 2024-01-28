using System;
using System.Linq;

namespace _5._Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rowsAndCols = Console.ReadLine().Split(", ");
            int rows = int.Parse(rowsAndCols[0]);
            int cols = int.Parse(rowsAndCols[1]);

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] colsInfo = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = colsInfo[col];
                }
            }

            for (int row = 0; row < rows; row++)                              //   0 1 2 3 4 5 6     00+01 => 01+02 => 02+03
            {                                                                 // 0|0|1|2|3|4|5|6|    10+11 => 11+12 => 12+13
                int sum = 0;                                                  // 1|0|1|2|3|4|5|6|
                int one = 1;                                                  // 2|0|1|2|3|4|5|6|
                for (int col = 0; col < cols; col++)                          
                {
                    sum += matrix[row, col] + matrix[row, col + 1];
                    sum += matrix[one, col + 1];
                    break;
                }
                one++;
            }
          
          
          
          


        }
    }
}
