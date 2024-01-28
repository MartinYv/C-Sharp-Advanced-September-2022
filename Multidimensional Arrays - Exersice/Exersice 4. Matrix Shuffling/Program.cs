using System;
using System.Linq;

namespace Exersice_4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            string[,] matrix = new string[rowsAndCols[0], rowsAndCols[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] colsInfo = Console.ReadLine().Split(" ");

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colsInfo[col];
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input=="END")
                {
                    break;
                }

                string[] info = input.Split();

                if (info.Length > 5 || info.Length <5)
                {
                    Console.WriteLine($"Invalid input!");
                    continue;
                }
                int row = int.Parse(info[1]);
                int col = int.Parse(info[2]);
                int row2 = int.Parse(info[3]);
                int col2 = int.Parse(info[4]);

                if (info[0]!="swap" || row<0 || row> matrix.GetLength(0) || row2 < 0 || row2 > matrix.GetLength(0)||
                    col < 0 || col > matrix.GetLength(1) ||col2 < 0 || col2 > matrix.GetLength(1))
                {
                    Console.WriteLine($"Invalid input!");
                    continue;
                }
                else
                {
                    string tempElement = matrix[row, col];
                    matrix[row, col] = matrix[row2, col2];
                    matrix[row2, col2] = tempElement;

                    for (int roww = 0; roww < matrix.GetLength(0); roww++)
                    {
                        for (int coll = 0; coll < matrix.GetLength(1); coll++)
                        {
                            Console.Write($"{matrix[roww, coll]} ");
                        }
                        Console.WriteLine();
                    }

                }
                
            }
        }
    }
}
