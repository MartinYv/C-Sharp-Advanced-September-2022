using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basketball
{
    public class Team
    {
        //        Name: string
        //OpenPositions: int
        //Group: char

        private List<Player> players;

        public Team(string name, int openPosition, char group)
        {
             players = new List<Player>();

            Name = name;
            OpenPositions = openPosition;
            Group = group;
        }

        public string Name { get; set; }
        public int OpenPositions { get; set; }
        public char Group { get; set; }
        public int Count => players.Count;

        public int PlayersRemoved { get; set; }

        public string AddPlayer(Player player)
        {
            if (string.IsNullOrEmpty(player.Name) || string.IsNullOrEmpty(player.Position))
            {
                return $"Invalid player's information.";
            }
            else if (this.OpenPositions == 0)
            {
                return $"There are no more open positions.";
            }
            else if (player.Rating < 80)
            {
                return $"Invalid player's rating.";
            }
            else
            {
                this.players.Add(player);
                this.OpenPositions--;
                return $"Successfully added {player.Name} to the team. Remaining open positions: {this.OpenPositions}.";
            }
        }

        public bool RemovePlayer(string name)
        {
            bool doestExist = players.Any(x => x.Name == name);

            if (doestExist==true)
            {
                var currPlayer = players.First(x => x.Name == name);
                players.Remove(currPlayer);
                OpenPositions++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int RemovePlayerByPosition(string position)
        {
            int count = 0;


            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].Position == position)
                {
                    players.Remove(players[i]);
                    PlayersRemoved++;
                    OpenPositions++;
                    count++;
                }
            }
            if (count==0)
            {
                return 0;
            }
            else
            {
                return PlayersRemoved;
            }

        }
        public Player RetirePlayer(string name)
        {
            var player = players.FirstOrDefault(x => x.Name == name);

            if (player == null)
            {
                return null;
            }
            else
            {
                player.Retired = true;
                return player;
            }
        }

        public List<Player> AwardPlayers(int games)
        {
            List<Player> playersPlayedTheGames = players.Where(x => x.Games >= games).ToList();
            return playersPlayedTheGames;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Active players competing for Team {Name} from Group {Group}:");
            foreach (var player in players.Where(x=>x.Retired == false))
            {
                sb.AppendLine(player.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
