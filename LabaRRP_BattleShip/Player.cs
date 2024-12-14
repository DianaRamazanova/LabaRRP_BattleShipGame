using System;
using System.Collections.Generic;

namespace LabaRRP_BattleShip
{
    public class Player
    {
        public Cell[,] Grid { get; set; }
        public List<Ship> Ships { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }

        private readonly PlacementRules _placementRules;

        public Player()
        {
            Grid = new Cell[10, 10];
            Ships = new List<Ship>();
            InitializeGrid();
            _placementRules = new PlacementRules(Grid);
            Score = 0;
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

        public bool PlaceShip(Ship ship, int x, int y, bool isVertical)
        {
            bool isPlaced = _placementRules.PlaceShip(ship, x, y, isVertical);
            if (isPlaced)
            {
                Ships.Add(ship);
            }
            return isPlaced;
        }
    }
}