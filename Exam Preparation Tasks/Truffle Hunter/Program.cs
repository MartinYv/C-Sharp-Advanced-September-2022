using System;
using System.Linq;

namespace Truffle_Hunter
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            int blackTrufflesCount = 0;
            int summerTrufflesCount = 0;
            int whiteTrufflesCount = 0;
            int wildRoarCollected = 0;


            for (int row = 0; row < size; row++)
            {
                char[] colInfo = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = colInfo[col];
                }
            }


            string command;
            while ((command = Console.ReadLine()) != "Stop the hunt")
            {
                string[] info = command.Split();

                if (info[0] == "Collect")   // B, S, W
                {
                    int row = int.Parse(info[1]);
                    int col = int.Parse(info[2]);

                    if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
                    {

                        if (matrix[row, col] == 'B')
                        {
                            matrix[row, col] = '-';
                            blackTrufflesCount++;
                        }

                        else if (matrix[row, col] == 'S')
                        {
                            matrix[row, col] = '-';
                            summerTrufflesCount++;
                        }

                        else if (matrix[row, col] == 'W')
                        {
                            matrix[row, col] = '-';
                            whiteTrufflesCount++;
                        }
                    }
                }


                else if (info[0] == "Wild_Boar")
                {
                    int row = int.Parse(info[1]);
                    int col = int.Parse(info[2]);
                    string direction = info[3];

                    if (direction == "up")
                    {
                        if (matrix[row, col] != '-')
                        {
                            wildRoarCollected++;
                            matrix[row, col] = '-';
                        }

                        while (row - 2 >= 0)
                        {

                            row -= 2;
                            if (matrix[row, col] != '-')
                            {
                                wildRoarCollected++;
                                matrix[row, col] = '-';
                            }
                        }
                    }


                    else if (direction == "down")
                    {
                        if (matrix[row, col] != '-')
                        {
                            wildRoarCollected++;
                            matrix[row, col] = '-';
                        }

                        while (row + 2 < matrix.GetLength(0))
                        {

                            row += 2;
                            if (matrix[row, col] != '-')
                            {
                                wildRoarCollected++;
                                matrix[row, col] = '-';
                            }
                        }
                    }

                    else if (direction == "left")
                    {
                        if (matrix[row, col] != '-')
                        {
                            wildRoarCollected++;
                            matrix[row, col] = '-';
                        }

                        while (col - 2 >= 0)
                        {

                            col -= 2;
                            if (matrix[row, col] != '-')
                            {
                                wildRoarCollected++;
                                matrix[row, col] = '-';
                            }
                        }
                    }

                    else if (direction == "right")
                    {
                        if (matrix[row, col] != '-')
                        {
                            wildRoarCollected++;
                            matrix[row, col] = '-';
                        }

                        while (col + 2 < matrix.GetLength(1))
                        {

                            col += 2;

                            if (matrix[row, col] != '-')
                            {
                                wildRoarCollected++;
                                matrix[row, col] = '-';
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"Peter manages to harvest {blackTrufflesCount} black, {summerTrufflesCount} summer, and {whiteTrufflesCount} white truffles.");
            Console.WriteLine($"The wild boar has eaten {wildRoarCollected} truffles.");

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
