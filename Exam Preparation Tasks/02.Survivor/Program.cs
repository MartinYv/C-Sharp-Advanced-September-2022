using System;
using System.Linq;

namespace _02.Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int tokensCollected = 0;
            int opponentsTokensCollected = 0;

            char[][] matrix = new char[rows][];

            for (int row = 0; row < rows; row++)
            {
                char[] colsInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                matrix[row] = colsInput;
                //for (int col = 0; col < colsInput.Length; col++)
                //{
                //    matrix[row][col] = colsInput[col];
                //}
            }

            while (true)
            {
                string[] info = Console.ReadLine().Split();

                string command = info[0];

                if (command == "Find")
                {
                    int row = int.Parse(info[1]);
                    int col = int.Parse(info[2]);

                    if (IsSellValid(row, col, matrix))
                    {
                        if (matrix[row][col] == 'T')
                        {
                            matrix[row][col] = '-';
                            tokensCollected++;
                        }
                    }
                }


                else if (command == "Opponent")
                {
                    int row = int.Parse(info[1]);
                    int col = int.Parse(info[2]);
                    string direction = info[3];

                    Move(row, col, matrix, direction, ref opponentsTokensCollected);
                }

                else if (command == "Gong")
                {

                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int k = 0; k < matrix[i].Length; k++)
                        {
                            Console.Write($"{ matrix[i][k]} ");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine($"Collected tokens: {tokensCollected}");
                    Console.WriteLine($"Opponent's tokens: {opponentsTokensCollected}");
                    break;
                }
            }


        }
        static void Move(int row, int col, char[][] matrix, string direction, ref int opponentsTokensCollected)
        {
            int count = 0;
            if (direction == "up")
            {
                if (IsSellValid(row, col, matrix))
                {
                    if (matrix[row][col] == 'T')
                    {
                        opponentsTokensCollected++;
                        matrix[row][col] = '-';
                    }
                }

                while (row - 1 >= 0)
                {

                    row--;
                    if (IsSellValid(row, col, matrix))
                    {
                        if (matrix[row][col] == 'T')
                        {
                            opponentsTokensCollected++;
                            matrix[row][col] = '-';
                        }
                    }
                    else
                    {
                        row++;
                        break;
                    }

                    count++;

                    if (count == 3)
                    {
                        break;
                    }
                }
            }

            else if (direction == "down")
            {
                if (IsSellValid(row, col, matrix))
                {
                    if (matrix[row][col] == 'T')
                    {
                        opponentsTokensCollected++;
                        matrix[row][col] = '-';
                    }
                }



                while (row + 1 < matrix.GetLength(0))
                {
                    row++;
                    if (IsSellValid(row, col, matrix))
                    {
                        if (matrix[row][col] == 'T')
                        {
                            opponentsTokensCollected++;
                            matrix[row][col] = '-';
                        }
                    }
                    else
                    {
                        row--;
                        break;
                    }

                    count++;

                    if (count == 3)
                    {
                        break;
                    }
                }
            }

            else if (direction == "left")
            {

                if (IsSellValid(row, col, matrix))
                {
                    if (matrix[row][col] == 'T')
                    {
                        opponentsTokensCollected++;
                        matrix[row][col] = '-';
                    }
                }


                while (col - 1 >= 0)
                {
                    col--;
                    if (IsSellValid(row, col, matrix))
                    {
                        if (matrix[row][col] == 'T')
                        {
                            opponentsTokensCollected++;
                            matrix[row][col] = '-';
                        }
                    }
                    else
                    {
                        col++;
                        break;
                    }

                    count++;

                    if (count == 3)
                    {
                        break;
                    }
                }
            }

            else if (direction == "right")
            {
                if (IsSellValid(row, col, matrix))
                {
                    if (matrix[row][col] == 'T')
                    {
                        opponentsTokensCollected++;
                        matrix[row][col] = '-';
                    }
                }


                while (col + 1 < matrix[row].Length)
                {
                    col++;
                    if (IsSellValid(row, col, matrix))
                    {
                        if (matrix[row][col] == 'T')
                        {
                            opponentsTokensCollected++;
                            matrix[row][col] = '-';
                        }
                    }
                    else
                    {
                        col--;
                        break;
                    }

                    count++;

                    if (count == 3)
                    {
                        break;
                    }
                }
            }
        }

        static bool IsSellValid(int row, int col, char[][] matrix)
        {
            if (row >= 0 && row < matrix.GetLength(0) &&
                col >= 0 && col < matrix[row].Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
