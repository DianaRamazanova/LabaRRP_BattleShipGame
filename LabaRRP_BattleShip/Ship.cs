using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaRRP_BattleShip
{
    public class Ship
    {
        public int Length { get; set; }
        public bool IsSunk { get; set; }
        public List<Cell> Cells { get; set; }

        public Ship(int length)
        {
            Length = length;
            IsSunk = false;
            Cells = new List<Cell>();
        }
    }
}
