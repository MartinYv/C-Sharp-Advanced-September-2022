using System;

namespace _02.Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int limitOfCommands = int.Parse(Console.ReadLine());

            int commandsCount = 0;

            int currRow = 0;
            int currCol = 0;

            bool stepOnFinishLine = false;
 
            char[,] matrix = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                string colInfo = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = colInfo[col];


                    if (matrix[row, col] == 'f')
                    {
                        currRow = row;
                        currCol = col;
                    }
                }
            }
            string command = Console.ReadLine();
            while (limitOfCommands != commandsCount)
            {

                if (command == "up" && currRow - 1 >= 0 ||
                    command == "down" && currRow + 1 < matrix.GetLength(0) ||
                    command == "left" && currCol - 1 >= 0 ||
                    command == "right" && currCol + 1 < matrix.GetLength(1))
                {

                    if (command == "up")
                    {
                        matrix[currRow, currCol] = '-';
                        currRow--;


                        if (matrix[currRow, currCol] == 'F')
                        {
                            matrix[currRow, currCol] = 'f';
                            stepOnFinishLine = true;
                            break;
                        }

                        else if (matrix[currRow, currCol] == 'B')
                        {
                            currRow--;
                            if (currRow < 0)
                            {
                                currRow = matrix.GetLength(0) - 1;
                            }

                            matrix[currRow, currCol] = 'f';
                        }
                        else if (matrix[currRow, currCol] == 'T')
                        {
                            currRow++;
                            matrix[currRow, currCol] = 'f';
                        }
                        else
                        {
                            matrix[currRow, currCol] = 'f';
                        }
                    }

                    else if (command == "down")
                    {
                        matrix[currRow, currCol] = '-';
                        currRow++;

                        if (matrix[currRow, currCol] == 'F')
                        {
                            matrix[currRow, currCol] = 'f';
                            stepOnFinishLine = true;
                            break;
                        }

                        else if (matrix[currRow, currCol] == 'B')
                        {
                            currRow++;

                            if (currRow >= matrix.GetLength(0))
                            {
                                currRow = 0;
                            }

                            matrix[currRow, currCol] = 'f';
                        }
                        else if (matrix[currRow, currCol] == 'T')
                        {
                            currRow--;
                            matrix[currRow, currCol] = 'f';
                        }
                        else
                        {
                            matrix[currRow, currCol] = 'f';
                        }
                    }

                    else if (command == "left")
                    {
                        matrix[currRow, currCol] = '-';
                        currCol--;

                        if (matrix[currRow, currCol] == 'F')
                        {
                            matrix[currRow, currCol] = 'f';
                            stepOnFinishLine = true;
                            break;
                        }

                        else if (matrix[currRow, currCol] == 'B')
                        {
                            currCol--;

                            if (currCol < 0)
                            {
                                currCol = matrix.GetLength(1) - 1;
                            }

                            matrix[currRow, currCol] = 'f';
                        }
                        else if (matrix[currRow, currCol] == 'T')
                        {
                            currCol++;
                            matrix[currRow, currCol] = 'f';
                        }
                        else
                        {
                            matrix[currRow, currCol] = 'f';
                        }
                    }


                    else if (command == "right")
                    {
                        matrix[currRow, currCol] = '-';
                        currCol++;

                        if (matrix[currRow, currCol] == 'F')
                        {
                            matrix[currRow, currCol] = 'f';
                            stepOnFinishLine = true;
                            break;
                        }

                        else if (matrix[currRow, currCol] == 'B')
                        {
                            currCol++;

                            if (currCol >= matrix.GetLength(1))
                            {
                                currCol = 0;
                            }

                            matrix[currRow, currCol] = 'f';
                        }
                        else if (matrix[currRow, currCol] == 'T')
                        {
                            currCol--;
                            matrix[currRow, currCol] = 'f';
                        }
                        else
                        {
                            matrix[currRow, currCol] = 'f';
                        }
                    }
                }
                else
                {

                    if (command == "up")
                    {
                        matrix[currRow, currCol] = '-';

                        currRow = matrix.GetLength(0) - 1;

                        if (matrix[currRow, currCol] == 'F')
                        {
                            matrix[currRow, currCol] = 'f';
                            stepOnFinishLine = true;

                            break;
                        }

                        matrix[currRow, currCol] = 'f';
                    }
                    else if (command == "down")
                    {
                        matrix[currRow, currCol] = '-';

                        currRow = 0;

                        if (matrix[currRow, currCol] == 'F')
                        {
                            matrix[currRow, currCol] = 'f';
                            stepOnFinishLine = true;

                            break;
                        }

                        matrix[currRow, currCol] = 'f';
                    }

                    else if (command == "left")
                    {
                        matrix[currRow, currCol] = '-';

                        currCol = matrix.GetLength(1) - 1;

                        if (matrix[currRow, currCol] == 'F')
                        {
                            matrix[currRow, currCol] = 'f';
                            stepOnFinishLine = true;

                            break;
                        }

                        matrix[currRow, currCol] = 'f';
                    }

                    else if (command == "right")
                    {
                        matrix[currRow, currCol] = '-';

                        currCol = 0;

                        if (matrix[currRow, currCol] == 'F')
                        {
                            matrix[currRow, currCol] = 'f';
                            stepOnFinishLine = true;

                            break;
                        }

                        matrix[currRow, currCol] = 'f';
                    }
                }

                //  for (int row = 0; row < size; row++)
                //  {
                //      for (int col = 0; col < size; col++)
                //      {
                //          Console.Write(matrix[row, col]);
                //      }
                //      Console.WriteLine();
                //  }

                commandsCount++;

                if (commandsCount == limitOfCommands)
                {
                    stepOnFinishLine = false;
                    break;
                }

                command = Console.ReadLine();
            }


            if (stepOnFinishLine == true)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
