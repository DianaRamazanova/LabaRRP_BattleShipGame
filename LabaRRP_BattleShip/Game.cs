using LabaRRP_BattleShip;
using System;
using System.Linq;

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
            //ход
            Player opponent = IsPlayer1Turn ? Player2 : Player1;
            Cell cell = opponent.Grid[x, y];
            if (cell.IsOccupied)
            {
                cell.IsHit = true;
                // проверка утопленного корабля
                Ship ship = opponent.Ships.FirstOrDefault(s => s.Cells.Contains(cell));
                if (ship != null && ship.Cells.All(c => c.IsHit))
                {
                    ship.IsSunk = true;
                }
            }
            IsPlayer1Turn = !IsPlayer1Turn;
        }

        //public bool IsGameOver()
       // {
         //   return 
        //}
    }
}