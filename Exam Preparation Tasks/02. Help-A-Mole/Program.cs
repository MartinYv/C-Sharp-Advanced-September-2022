using System;

namespace _02._Help_A_Mole
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            int rowPosotion = 0;
            int colPosition = 0;
            int pointsCollected = 0;


            for (int row = 0; row < size; row++)
            {
                string colsInfo = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = colsInfo[col];

                    if (matrix[row, col] == 'M')
                    {
                        rowPosotion = row;
                        colPosition = col;
                    }
                   
                }
            }

            matrix[rowPosotion, colPosition] = '-';

            string command;
            while ((command = Console.ReadLine()) != "End" && pointsCollected < 25)
            {

                if (command == "down" && rowPosotion + 1 < matrix.GetLength(0) ||
                    command == "up" && rowPosotion - 1 >= 0 ||
                    command == "right" && colPosition + 1 < matrix.GetLength(1) || 
                    command == "left" && colPosition - 1 >= 0)
                {
                    if (command == "up")
                    {
                        rowPosotion -= 1;
                    }
                    else if (command == "down")
                    {
                        rowPosotion += 1;
                    }
                    else if (command == "left")
                    {
                        colPosition -= 1;
                    }
                    else if (command == "right")
                    {
                        colPosition += 1;
                    }
                }

                else
                {
                    Console.WriteLine("Don't try to escape the playing field!");
                    continue;
                }



                if (matrix[rowPosotion, colPosition] == '-')
                {
                    continue;
                }

                else if (matrix[rowPosotion, colPosition] == 'S')
                {
                    matrix[rowPosotion, colPosition] = '-';
                    pointsCollected -= 3;

                    if (pointsCollected < 0)
                    {
                        pointsCollected = 0;
                    }

                    for (int row = 0; row < size; row++)
                    {
                        for (int col = 0; col < size; col++)
                        {
                            if (matrix[row,col]=='S')
                            {
                                rowPosotion = row;
                                colPosition = col;
                                break;
                            }
                        }                     
                    }
                    
                    
                    matrix[rowPosotion, colPosition] = '-';
                }
                
                else if (char.IsDigit(matrix[rowPosotion, colPosition]))
            {
                pointsCollected += int.Parse(matrix[rowPosotion, colPosition].ToString());
                matrix[rowPosotion, colPosition] = '-';
            }

        }


            if (pointsCollected >= 25)
            {
                Console.WriteLine("Yay! The Mole survived another game!");
                Console.WriteLine($"The Mole managed to survive with a total of {pointsCollected} points.");
            }
            else
            {
                Console.WriteLine("Too bad! The Mole lost this battle!");
                Console.WriteLine($"The Mole lost the game with a total of {pointsCollected} points.");
            }

            matrix[rowPosotion, colPosition] = 'M';
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
