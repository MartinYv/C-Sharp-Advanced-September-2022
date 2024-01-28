using System;
using System.Collections.Generic;
using System.Linq;

namespace Exersice_7._The_V___Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vloger> vlogers = new List<Vloger>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Statistics")
                {
                    break;
                }

                string[] tokens = input.Split();

                if (tokens[1] == "joined")
                {
                    string currVlogger = tokens[0];

                    if (vlogers.Any(x => x.Name == currVlogger))
                    {
                        continue;
                    }
                    else
                    {
                        vlogers.Add(new Vloger(currVlogger));
                    }
                }

                if (tokens[1] == "followed")
                {
                    string vlogerName = tokens[0];
                    string vlogerToFollow = tokens[2];

                    var vlogerDoesExis = vlogers.Find(x => x.Name == vlogerName);
                    var toFollowDoesExis = vlogers.Find(x => x.Name == vlogerToFollow);

                    if (vlogerName == vlogerToFollow || !vlogers.Any(v => v.Name == vlogerName) || !vlogers.Any(v => v.Name == vlogerToFollow))
                    {
                       
                            continue;
                        }
                    else
                        {
                            vlogerDoesExis.Following.Add(vlogerToFollow);
                            toFollowDoesExis.Followers.Add(vlogerName);
                        }
                    }
                }

                vlogers = vlogers.OrderByDescending(v => v.Followers.Count).ThenBy(v => v.Following.Count).ToList();

                int count = 1;

                Console.WriteLine($"The V-Logger has a total of {vlogers.Count} vloggers in its logs.");
                foreach (Vloger vloger in vlogers)
                {
                    Console.WriteLine($"{count}. {vloger.Name} : {vloger.Followers.Count} followers, {vloger.Following.Count} following");
                    if (count == 1)
                    {
                        foreach (var item in vloger.Followers)
                        {
                            Console.WriteLine($"*  {item}");
                        }
                    }
                    count++;
                }
            }
        class Vloger
        {
            public Vloger(string name)
            {
                Name = name;
                Followers = new SortedSet<string>();
                Following = new HashSet<string>();
            }
            public string Name { get; set; }
            public SortedSet<string> Followers { get; set; }
            public HashSet<string> Following { get; set; }
        }
    }
}
