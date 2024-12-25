using System;
using System.Linq;

namespace LabaRRP_BattleShip
{
    public class Game
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public bool IsPlayer1Turn { get; set; }

        public Game()
        {
            Player1 = new Player();
            Player2 = new Player();
            IsPlayer1Turn = true;
        }

        public void MakeMove(int x, int y)
        {
            Player opponent = IsPlayer1Turn ? Player2 : Player1;
            bool hit = opponent.CheckHit(x, y);
            if (hit)
            {
                if (opponent.Ships.All(s => s.IsSunk))
                {
                    IsGameOver();
                }
            }
            IsPlayer1Turn = !IsPlayer1Turn;
        }

        public bool IsGameOver()
        {
            return Player1.Ships.All(s => s.IsSunk) || Player2.Ships.All(s => s.IsSunk);
        }
    }
}