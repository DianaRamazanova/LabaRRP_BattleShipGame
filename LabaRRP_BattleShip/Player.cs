using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaRRP_BattleShip
{
    public class Player
    {
        public Cell[,] Grid { get; set; }
        public List<Ship> Ships { get; set; }

        public Player()
        {
            Grid = new Cell[10, 10];
            Ships = new List<Ship>();
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Grid[i, j] = new Cell();
                }
            }
        }

        public void PlaceShip(Ship ship, int x, int y, bool isVertical)
        {
            ship.Cells = new List<Cell>();
            for (int i = 0; i < ship.Length; i++)
            {
                int newX = isVertical ? x : x + i;
                int newY = isVertical ? y + i : y;
                Grid[newX, newY].IsOccupied = true;
                ship.Cells.Add(Grid[newX, newY]);
            }
            Ships.Add(ship);
        }
    }
}
