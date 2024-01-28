using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] matrix = new int[rows][];


              for (int row = 0; row < rows; row++)
              {
                  int[] colInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
                  matrix[row] = new int[colInfo.Length];
            
            
                  for (int col = 0; col < matrix[row].Length; col++)
                  {
                      matrix[row][col] = colInfo[col];
                  }
              }

         // for (int row = 0; row < matrix.Length; row++)                   Съкракена версия на горния код!
         // {
         //     matrix[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
         // }

            string[] input = Console.ReadLine().Split();
            while (input[0] != "END")
            {
                string command = input[0];
                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);
                int value = int.Parse(input[3]);

                
                if (row < 0 || row >= matrix.Length || col < 0 || col >= matrix[col].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    input = Console.ReadLine().Split();
                    continue;
                }

                if (command == "Add")
                {
                    matrix[row][col] += value;
                }
                else if (command == "Subtract")
                {
                    matrix[row][col] -= value;

                }

                input = Console.ReadLine().Split();
            }

     for (int row = 0; row < rows; row++)
     {
         for (int col = 0; col <  matrix[row].Length; col++)
         {
             Console.Write($"{matrix[row][col]} ");
         }
         Console.WriteLine();
     }
            
            //   foreach (int[] row in matrix)
            //   {
            //       Console.WriteLine(string.Join(" ",row));       Съкракена версия на горния код!
            //   }
        }
    }
}
