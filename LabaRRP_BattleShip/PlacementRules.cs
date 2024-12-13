using System;
using System.Collections.Generic;

namespace LabaRRP_BattleShip
{
    public class PlacementRules
    {
        private const int GridSize = 10;
        private Cell[,] _grid;
        private List<Ship> _ships;

        private int _oneDeckCount = 0;
        private int _twoDeckCount = 0;
        private int _threeDeckCount = 0;
        private int _fourDeckCount = 0;

        public PlacementRules(Cell[,] grid)
        {
            _grid = grid;
            _ships = new List<Ship>();
        }

        public bool PlaceShip(Ship ship, int x, int y, bool isVertical)
        {
            // Проверка на количество кораблей
            if (ship.Length == 1 && _oneDeckCount >= 4)
            {
                return false;
            }
            if (ship.Length == 2 && _twoDeckCount >= 3)
            {
                return false;
            }
            if (ship.Length == 3 && _threeDeckCount >= 2)
            {
                return false;
            }
            if (ship.Length == 4 && _fourDeckCount >= 1)
            {
                return false;
            }

            // Проверка, что корабль помещается на поле
            for (int i = 0; i < ship.Length; i++)
            {
                int newX = isVertical ? x : x + i;
                int newY = isVertical ? y + i : y;

                // Проверка выхода за границы поля
                if (newX < 0 || newX >= GridSize || newY < 0 || newY >= GridSize)
                {
                    return false;
                }

                // Проверка, что клетка не занята другим кораблем
                if (_grid[newX, newY].IsOccupied)
                {
                    return false;
                }

                // Проверка, что корабли не касаются друг друга
                for (int dx = -1; dx <= 1; dx++)
                {
                    for (int dy = -1; dy <= 1; dy++)
                    {
                        int neighborX = newX + dx;
                        int neighborY = newY + dy;

                        if (neighborX >= 0 && neighborX < GridSize && neighborY >= 0 && neighborY < GridSize)
                        {
                            if (_grid[neighborX, neighborY].IsOccupied)
                            {
                                return false;
                            }
                        }
                    }
                }
            }


            ship.Cells = new List<Cell>();
            for (int i = 0; i < ship.Length; i++)
            {
                int newX = isVertical ? x : x + i;
                int newY = isVertical ? y + i : y;
                _grid[newX, newY].IsOccupied = true;
                ship.Cells.Add(_grid[newX, newY]);
            }
            _ships.Add(ship);


            if (ship.Length == 1) _oneDeckCount++;
            if (ship.Length == 2) _twoDeckCount++;
            if (ship.Length == 3) _threeDeckCount++;
            if (ship.Length == 4) _fourDeckCount++;

            return true;
        }
    }
}
