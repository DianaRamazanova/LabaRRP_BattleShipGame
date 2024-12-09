using LabaRRP_BattleShip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipGame
{
    public class Leaderboard
    {
        private const string LeaderboardFile = @"C:\Users\понини\LabaRRP_BattleShipGame";

        public List<Player> GetTopPlayers()
        {
            if (!File.Exists(LeaderboardFile))
            {
                return new List<Player>();
            }

            var lines = File.ReadAllLines(LeaderboardFile);
            var players = lines.Select(line =>
            {
                var parts = line.Split(',');
                return new Player { Name = parts[0], Score = int.Parse(parts[1]) };
            }).ToList();

            return players.OrderByDescending(p => p.Score).Take(10).ToList();
        }

        public void AddPlayer(Player player)
        {
            var players = GetTopPlayers();
            players.Add(player);
            players = players.OrderByDescending(p => p.Score).Take(10).ToList();

            var lines = players.Select(p => $"{p.Name},{p.Score}").ToList();
            File.WriteAllLines(LeaderboardFile, lines);
        }
    }
}