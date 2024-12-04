using LabaRRP_BattleShip;
using System;

namespace BattleShipGame.Core
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
        }

        //public bool IsGameOver()
       // {
         //   return 
        //}
    }
}