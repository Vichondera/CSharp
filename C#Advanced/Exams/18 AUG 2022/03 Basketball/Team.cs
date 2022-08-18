using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basketball
{
    public class Team
    {
        public Team(string name, int openPositions, char group)
        {
            this.Name = name;
            this.OpenPositions = openPositions;
            this.Group = group;
            this.Players = new List<Player>();
        }
        public string Name { get; set; }

        public int OpenPositions { get; set; }

        public char Group { get; set; }

        public ICollection<Player> Players { get; set; }

        public int Count => this.Players.Count;

        public string AddPlayer(Player player)
        {

            if(string.IsNullOrEmpty(player.Name) || string.IsNullOrEmpty(player.Position))
            {
                return "Invalid player's information.";
            }

            if(this.OpenPositions == 0)
            {
                return "There are no more open positions.";
            }

            if(player.Rating < 80)
            {
               return "Invalid player's rating.";
            }
            this.Players.Add(player);
            this.OpenPositions--;
            return $"Successfully added {player.Name} to the team. Remaining open positions: {this.OpenPositions}.";
        }

        public bool RemovePlayer(string name)
        {
            Player p = this.Players.FirstOrDefault(x => x.Name == name);
           if(p == null)
            {
                return false;
            }

            this.Players.Remove(p);
            return true;
        }

        public int RemovePlayerByPosition(string position)
        {
            List<Player> players = this.Players.Where(x => x.Position == position).ToList();
            var numOfRemoved = players.Count;
            if(numOfRemoved > 0)
            {
                foreach (var item in players)
                {
                    this.Players.Remove(item);
                }
            }

            return numOfRemoved;
           
        }

        public Player RetirePlayer(string name)
        {
            Player p = this.Players.FirstOrDefault(x => x.Name == name);
            if(p == null)
            {
                return null;
            }
            p.Retired = true;

            return p;
        }

        public List<Player> AwardPlayers(int games)
        {
            var awardedPl = new List<Player>();
            foreach (var player in this.Players.Where(x=>x.Games > 0))
            {
                awardedPl.Add(player);
            }
            return awardedPl;
        }

        public string Report()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Active players competing for Team {this.Name} from Group {this.Group}:");
            foreach (var item in Players)
            {
                sb.AppendLine(item.Name);
            }

            return sb.ToString();
        }
    }
}
