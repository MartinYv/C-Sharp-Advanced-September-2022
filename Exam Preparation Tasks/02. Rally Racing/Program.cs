using System;
using System.Linq;

namespace _02._Rally_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            string racingNumber = Console.ReadLine();

            char[,] matrix = new char[size, size];
            int currRow = 0;
            int currColl = 0;


            int traveledDistance = 0;

            bool stepOnFinish = false;



            for (int row = 0; row < size; row++)
            {
                char[] colsInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = colsInfo[col];
                }
            }

            string command;
            while ((command= Console.ReadLine()) != "End")
            {
                

                if (command == "up")
                {
                    currRow--;
                }
                else if (command == "down")
                {
                    currRow++;
                }
                else if (command == "left")
                {
                    currColl--;
                }
                else if (command== "right")
                {
                    currColl++;
                }


                if (matrix[currRow,currColl] == '.')
                {
                    traveledDistance += 10;
                }

                else if (matrix[currRow, currColl] == 'T')
                {
                    matrix[currRow, currColl] = '.';

                    for (int row = 0; row < size; row++)
                    {
                        
                        for (int col = 0; col < size; col++)
                        {
                            if (matrix[row, col] == 'T')
                            {
                                currRow = row;
                                currColl = col;
                                break;
                            }
                        }
                    }

                    matrix[currRow, currColl] = '.';
                    traveledDistance += 30;
                }

                else if (matrix[currRow, currColl] == 'F')
                {
                    stepOnFinish = true;
                    matrix[currRow, currColl] = 'C';
                    traveledDistance += 10;

                    break;
                }


            }

            if (stepOnFinish== true)
            {
                Console.WriteLine($"Racing car {racingNumber} finished the stage!");
            }
            else
            {
                matrix[currRow, currColl] = 'C';
                Console.WriteLine($"Racing car {racingNumber} DNF.");
            }
                Console.WriteLine($"Distance covered {traveledDistance} km.");


            for (int row = 0; row < size; row++)
            {

                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row,col]);
                }
            Console.WriteLine();
            }
        }
    }
}
