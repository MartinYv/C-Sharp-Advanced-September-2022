using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Beaver_at_Work
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            int numberOfBranches = 0;

            int bRow = 0;
            int bCol = 0;


            for (int row = 0; row < size; row++)
            {
                char[] colsInfo = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = colsInfo[col];
                    if (char.IsLower(matrix[row, col]))
                    {
                        numberOfBranches++;
                    }
                    if (matrix[row, col] == 'B')
                    {
                        bRow = row;
                        bCol = col;
                    }
                }
            }

            List<char> collectedBranches = new List<char>();
            List<char> totalCollectedBranches = new List<char>();
            string command;
            while ((command = Console.ReadLine()) != "end" && numberOfBranches != totalCollectedBranches.Count)
            {
                if (command == "up" && bRow - 1 >= 0 ||
                    command == "down" && bRow + 1 < matrix.GetLength(0) ||
                    command == "left" && bCol - 1 > 0 ||
                    command == "right" && bCol + 1 < matrix.GetLength(1))
                {

                    if (command == "up")
                    {
                        matrix[bRow, bCol] = '-';

                        bRow -= 1;
                        if (matrix[bRow, bCol] == '-')
                        {
                            matrix[bRow, bCol] = 'B';
                            matrix[bRow + 1, bCol] = '-';
                        }

                        else if (char.IsLower(matrix[bRow, bCol]))
                        {
                            collectedBranches.Add(matrix[bRow, bCol]);
                            matrix[bRow, bCol] = 'B';
                            matrix[bRow + 1, bCol] = '-';
                           
                            totalCollectedBranches.Add(matrix[bRow, bCol]);
                        }

                        else if (matrix[bRow, bCol] == 'F')
                        {
                            matrix[bRow, bCol] = '-';

                            if (bRow - 1 < 0)
                            {
                                while (bRow + 1 < matrix.GetLength(0)) // отиваме надолу
                                {
                                    bRow += 1;
                                    
                                }


                                if (char.IsLower(matrix[bRow, bCol]))
                                {
                                    collectedBranches.Add(matrix[bRow, bCol]);
                                    totalCollectedBranches.Add(matrix[bRow, bCol]);
                                   
                                }
                                matrix[bRow, bCol] = 'B';
                            }

                            else
                            {
                                while (bRow - 1 >= 0) // отиваме нагоре
                                {
                                    bRow -= 1;
                                   
                                }
                                if (char.IsLower(matrix[bRow, bCol]))
                                {
                                    collectedBranches.Add(matrix[bRow, bCol]);                                                                       
                                    totalCollectedBranches.Add(matrix[bRow, bCol]);
                                }
                                matrix[bRow, bCol] = 'B';
                            }
                        }
                    }


                    else if (command == "down")
                    {
                        matrix[bRow, bCol] = '-';

                        bRow += 1;
                        if (matrix[bRow, bCol] == '-')
                        {
                            matrix[bRow, bCol] = 'B';
                            matrix[bRow - 1, bCol] = '-';
                        }

                        else if (char.IsLower(matrix[bRow, bCol]))
                        {
                            collectedBranches.Add(matrix[bRow, bCol]);
                            matrix[bRow, bCol] = 'B';
                            matrix[bRow - 1, bCol] = '-';

                            totalCollectedBranches.Add(matrix[bRow, bCol]);

                        }

                        else if (matrix[bRow, bCol] == 'F')
                        {
                            matrix[bRow, bCol] = '-';

                            if (bRow + 1 >= matrix.GetLength(0))
                            {
                                while (bRow - 1 >= 0) // отиваме нагоре
                                {
                                    bRow -= 1;
                                    
                                }
                                if (char.IsLower(matrix[bRow, bCol]))
                                {
                                    collectedBranches.Add(matrix[bRow, bCol]);                                                                        
                                    totalCollectedBranches.Add(matrix[bRow, bCol]);
                                }
                                matrix[bRow, bCol] = 'B';
                            }
                            else
                            {
                                while (bRow + 1 < matrix.GetLength(0))
                                {
                                    bRow += 1;
                                    
                                }

                                if (char.IsLower(matrix[bRow, bCol]))
                                {
                                    collectedBranches.Add(matrix[bRow, bCol]);
                                    totalCollectedBranches.Add(matrix[bRow, bCol]);                                   
                                }
                                matrix[bRow, bCol] = 'B';
                            }
                        }
                    }


                    else if (command == "left")
                    {
                        bCol -= 1;
                        if (matrix[bRow, bCol] == '-')
                        {
                            matrix[bRow, bCol] = 'B';
                            matrix[bRow, bCol + 1] = '-';
                        }

                        else if (char.IsLower(matrix[bRow, bCol]))
                        {
                            collectedBranches.Add(matrix[bRow, bCol]);
                            matrix[bRow, bCol] = 'B';
                            matrix[bRow, bCol + 1] = '-';

                            totalCollectedBranches.Add(matrix[bRow, bCol]);
                        }

                        else if (matrix[bRow, bCol] == 'F')
                        {
                            matrix[bRow, bCol] = '-';

                            if (bCol - 1 < 0)
                            {
                                while (bCol + 1 < matrix.GetLength(0))
                                {
                                    bCol += 1;
                                   
                                }
                                if (char.IsLower(matrix[bRow, bCol]))
                                {
                                    collectedBranches.Add(matrix[bRow, bCol]);                                                                   
                                    totalCollectedBranches.Add(matrix[bRow, bCol]);
                                }

                                matrix[bRow, bCol] = 'B';
                            }
                            else
                            {
                                while (bCol - 1 >= 0)
                                {
                                    bCol -= 1;
                                   
                                }
                                if (char.IsLower(matrix[bRow, bCol]))
                                {
                                    collectedBranches.Add(matrix[bRow, bCol]);
                                    totalCollectedBranches.Add(matrix[bRow, bCol]);
                                }

                                matrix[bRow, bCol] = 'B';
                            }
                        }
                    }


                  else  if (command == "right")
                    {
                        bCol += 1;
                        if (matrix[bRow, bCol] == '-')
                        {
                            matrix[bRow, bCol] = 'B';
                            matrix[bRow, bCol - 1] = '-';
                        }

                        else if (char.IsLower(matrix[bRow, bCol]))
                        {
                            collectedBranches.Add(matrix[bRow, bCol]);
                            matrix[bRow, bCol] = 'B';
                            matrix[bRow, bCol - 1] = '-';

                            totalCollectedBranches.Add(matrix[bRow, bCol]);
                        }

                        else if (matrix[bRow, bCol] == 'F')
                        {
                            matrix[bRow, bCol] = '-';

                            if (bCol + 1 >= matrix.GetLength(1))
                            {
                                while (bCol - 1 >= 0)
                                {
                                    bCol -= 1;
                                    
                                }
                                if (char.IsLower(matrix[bRow, bCol]))
                                {
                                    collectedBranches.Add(matrix[bRow, bCol]);                                                                   
                                    totalCollectedBranches.Add(matrix[bRow, bCol]);
                                }

                                matrix[bRow, bCol] = 'B';
                            }
                            else
                            {
                                while (bCol + 1 >= 0)
                                {
                                    bCol += 1;
                                    
                                }
                                if (char.IsLower(matrix[bRow, bCol]))
                                {
                                    collectedBranches.Add(matrix[bRow, bCol]);                                                                    
                                    totalCollectedBranches.Add(matrix[bRow, bCol]);
                                }

                                matrix[bRow, bCol] = 'B';
                            }
                        }
                    }
                }

                else // Ако излезне от матрицата
                {
                    if (collectedBranches.Count > 0)
                    {

                    collectedBranches.RemoveAt(collectedBranches.Count - 1);
                    }
                }
               
            }

            if (numberOfBranches == totalCollectedBranches.Count)
            {
                Console.WriteLine($"The Beaver successfully collect {collectedBranches.Count} wood branches: {string.Join(", ", collectedBranches)}.");
            }
            else
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {numberOfBranches - totalCollectedBranches.Count} branches left.");
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
