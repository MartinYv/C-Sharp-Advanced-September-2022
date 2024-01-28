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

            int rowIndex = 0;
            int colIndex = 0;
            int maxSum = 0;
           
            for (int row = 0; row < rows; row++)                              //   0 1 2 3 4 5 6     
            {                                                                 // 0|0|1|2|3|4|5|6|    00+01 => 01+02 => 02+03...
                for (int col = 0; col < cols + 1; col++)                      // 1|0|1|2|3|4|5|6|    10+11 => 11+12 => 12+13...
                {                                                             // 2|0|1|2|3|4|5|6|
                    int sum = 0;

                    if (col == cols - 1 || row == rows - 1)
                    {
                        break;
                    }
                    sum += matrix[row, col] + matrix[row, col + 1];
                    sum += matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (sum > maxSum)
                    {
                        rowIndex = row;
                        colIndex = col;
                        maxSum = sum;
                    }
                }
            }

            Console.WriteLine($"{matrix[rowIndex, colIndex]} {matrix[rowIndex, colIndex + 1]} ");
            Console.WriteLine($"{matrix[rowIndex + 1, colIndex]} {matrix[rowIndex + 1, colIndex + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}