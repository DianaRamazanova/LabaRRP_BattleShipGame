using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaRRP_BattleShip
{
    public class Cell
    {
        public bool IsOccupied { get; set; }
        public bool IsHit { get; set; }

        public Cell()
        {
            IsOccupied = false;
            IsHit = false;
        }
    }
}
