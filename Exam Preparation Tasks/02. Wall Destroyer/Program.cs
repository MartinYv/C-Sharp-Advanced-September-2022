using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Wall_Destroyer
{
    class Program
    {
        static void Main(string[] args)
        {

            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            int currRow = 0;
            int currCol = 0;

            int holes = 1;
            int rods = 0;

            for (int row = 0; row < size; row++)
            {
                string colsInfo = Console.ReadLine();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = colsInfo[col];

                    if (matrix[row, col] == 'V')
                    {
                        currRow = row;
                        currCol = col;
                    }
                }
            }


            matrix[currRow, currCol] = '*';
            bool isHeElectocuted = false;

            string command;
            while ((command = Console.ReadLine()) != "End")
            {

                if (command == "up" && currRow - 1 >= 0 ||
                    command == "down" && currRow + 1 < matrix.GetLength(0) ||
                    command == "left" && currCol - 1 >= 0 ||
                    command == "right" && currCol + 1 < matrix.GetLength(1))
                {
                    if (command == "up")
                    {
                        currRow -= 1;

                        if (matrix[currRow, currCol] == 'R')
                        {
                            currRow += 1;
                            rods++;
                            Console.WriteLine("Vanko hit a rod!");
                        }

                        else if (matrix[currRow, currCol] == 'C')
                        {
                            isHeElectocuted = true;
                            holes++;
                            matrix[currRow, currCol] = 'E';
                            break;
                        }

                        else if (matrix[currRow, currCol] == '*')
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{currRow}, {currCol}]!");
                        }

                        else if (matrix[currRow, currCol] == '-')
                        {
                            matrix[currRow, currCol] = '*';
                            holes++;
                        }
                    }

                    else if (command == "down")
                    {
                        currRow += 1;

                        if (matrix[currRow, currCol] == 'R')
                        {
                            currRow -= 1;
                            rods++;
                            Console.WriteLine("Vanko hit a rod!");
                        }

                        else if (matrix[currRow, currCol] == 'C')
                        {
                            isHeElectocuted = true;
                            holes++;
                            matrix[currRow, currCol] = 'E';
                            break;
                        }

                        else if (matrix[currRow, currCol] == '*')
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{currRow}, {currCol}]!");
                        }

                        else if (matrix[currRow, currCol] == '-')
                        {
                            matrix[currRow, currCol] = '*';
                            holes++;
                        }
                    }

                    else if (command == "left")
                    {
                        currCol -= 1;

                        if (matrix[currRow, currCol] == 'R')
                        {
                            currCol += 1;
                            rods++;
                            Console.WriteLine("Vanko hit a rod!");
                        }

                        else if (matrix[currRow, currCol] == 'C')
                        {
                            isHeElectocuted = true;
                            holes++;
                            matrix[currRow, currCol] = 'E';
                            break;
                        }

                        else if (matrix[currRow, currCol] == '*')
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{currRow}, {currCol}]!");
                        }

                        else if (matrix[currRow, currCol] == '-')
                        {
                            matrix[currRow, currCol] = '*';
                            holes++;

                        }
                    }

                    else if (command == "right")
                    {
                        currCol += 1;

                        if (matrix[currRow, currCol] == 'R')
                        {
                            currCol -= 1;
                            rods++;
                            Console.WriteLine("Vanko hit a rod!");
                        }

                        else if (matrix[currRow, currCol] == 'C')
                        {
                            isHeElectocuted = true;
                            holes++;
                            matrix[currRow, currCol] = 'E';
                            break;
                        }

                        else if (matrix[currRow, currCol] == '*')
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{currRow}, {currCol}]!");
                        }

                        else if (matrix[currRow, currCol] == '-')
                        {
                            matrix[currRow, currCol] = '*';
                            holes++;

                        }
                    }
                }
            }


            if (isHeElectocuted == true)
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {holes} hole(s).");
            }
            else
            {
                Console.WriteLine($"Vanko managed to make {holes} hole(s) and he hit only {rods} rod(s).");
                matrix[currRow, currCol] = 'V';
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