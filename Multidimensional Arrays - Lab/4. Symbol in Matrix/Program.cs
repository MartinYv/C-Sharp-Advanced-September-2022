using System;
using System.Collections.Generic;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[,] matrix = new string[size, size];

            for (int row = 0; row < size; row++)
            {
                string rowInfo = Console.ReadLine();
                List<string> cols = new List<string>();

                foreach (var item in rowInfo)
                {
                    cols.Add(item.ToString());
                }

                for (int col = 0; col < cols.Count; col++)
                {
                    matrix[row, col] = cols[col];
                }
            }

            string toFind = Console.ReadLine();
            bool doesItContain = false;

            for (int row = 0; row < size; row++)
            {
                if (doesItContain == true)
                {
                    break;
                }

                for (int col = 0; col < size; col++)
                {

                    if (matrix[row, col].Contains(toFind))
                    {
                        Console.WriteLine($"({row}, {col})");
                        doesItContain = true;
                        break;
                    }
                }
            }

            if (doesItContain == false)
            {
                Console.WriteLine($"{toFind} does not occur in the matrix");
            }
        }
    }
}

//int size = int.Parse(Console.ReadLine());
//string[,] matrix = new string[size, size];
//
//for (int row = 0; row < size; row++)
//{
//    string rowInfo = Console.ReadLine();
//    List<string> cols = new List<string>();
//
//    foreach (var item in rowInfo)
//    {
//        cols.Add(item.ToString());
//    }
//
//    for (int col = 0; col < cols.Count; col++)
//    {
//        matrix[row, col] = cols[col];
//    }
//}
//
//string toFind = Console.ReadLine();
//
//for (int row = 0; row < size; row++)
//{
//
//    for (int col = 0; col < size; col++)
//    {
//
//        if (matrix[row, col].Contains(toFind))
//        {
//            Console.WriteLine($"({row}, {col})");
//            return;
//        }
//    }
//}
//
//Console.WriteLine($"{toFind} does not occur in the matrix");
//        }
//    }
//}
//