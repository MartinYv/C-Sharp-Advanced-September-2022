using System;
using System.Linq;

namespace Exersice_5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string text = Console.ReadLine();

            string[,] matrix = new string[rowsAndCols[0], rowsAndCols[1]];

            int currWordIndex = 0;

            for (int  row = 0;  row < matrix.GetLength(0);  row++)
            {
                if (row%2==0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (currWordIndex == text.Length)
                        {
                            currWordIndex = 0;
                        }

                        matrix[row, col] = text[currWordIndex].ToString();
                        
                        currWordIndex++;
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1)-1; col >=0; col--)
                    {
                                          
                        if (currWordIndex == text.Length)
                        {
                            currWordIndex = 0;
                        }
                       
                        matrix[row, col] = text[currWordIndex].ToString();

                        currWordIndex++;
                    }
                }                             
            }

            for (int  row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row,col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
