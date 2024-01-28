using System;
using System.Linq;

namespace Multidimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] info = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = info[0];
            int cols = info[1];

            int[,] matrix = new int[rows, cols];
           
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));

            int sum = 0;
            for (int row = 0; row < rows; row++)
            {
                int[] rowsData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowsData[col];                  
                    sum += matrix[row, col];
                }

            }

                Console.WriteLine(sum);
           
        }
    }
}
