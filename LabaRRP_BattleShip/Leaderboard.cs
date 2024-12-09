using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipGame.Core
{
    class leaderboard
    {
        public class Player
        {
            public int PlayerId { get; set; }
            public string PlayerName { get; set; }
            public List<PlayerScore> PlayerScores { get; set; }
        }

        public class Match
        {
            public int MatchId { get; set; }
            public DateTime MatchStartDate { get; set; }
            public DateTime? MatchEndDate { get; set; }
            public List<Step> Steps { get; set; }
            public List<Ship> Ships { get; set; }
            public List<PlayerScore> PlayerScores { get; set; }
        }

        public class Step
        {
            public int StepId { get; set; }
            public int MatchId { get; set; }
            public Match Match { get; set; }
            public int PlayerId { get; set; }
            public Player Player { get; set; }
            public string AttackPlace { get; set; }
            public string AttackResult { get; set; }
        }

        public class Ship
        {
            public int ShipId { get; set; }
            public int MatchId { get; set; }
            public Match Match { get; set; }
            public int PlayerId { get; set; }
            public Player Player { get; set; }
            public int ShipLength { get; set; }
            public bool IsSunk { get; set; }
            public List<Cell> Cells { get; set; }
        }

        public class Cell
        {
            public int CellId { get; set; }
            public int ShipId { get; set; }
            public Ship Ship { get; set; }
            public int CellX { get; set; }
            public int CellY { get; set; }
            public bool IsHit { get; set; }
        }

        public class PlayerScore
        {
            public int PlayerId { get; set; }
            public Player Player { get; set; }
            public int MatchId { get; set; }
            public Match Match { get; set; }
            public int Score { get; set; }
        }