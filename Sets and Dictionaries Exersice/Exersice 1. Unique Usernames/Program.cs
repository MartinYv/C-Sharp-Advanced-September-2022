using System;
using System.Collections.Generic;

namespace Exersice_1._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfUsers = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();

            for (int i = 0; i < countOfUsers; i++)
            {
                set.Add(Console.ReadLine());
            }

            foreach (var userName in set)
            {
                Console.WriteLine(userName);
            }
        }
    }
}
