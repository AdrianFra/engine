﻿using Engine.Contracts;
using World.Model;

namespace Landscape.Rendering
{
    public class PlantGrid : IPositionFilter
    {
        private bool[][] _values;
        private int _metersPerGridField;

        public PlantGrid(bool [][] values, int metersPerGridField)
        {
            _values = values;
            _metersPerGridField = metersPerGridField;
        }

        bool IPositionFilter.IsValid(Position position)
        {
            int x = (int)(position.X / _metersPerGridField);
            int z = (int)(position.Z / _metersPerGridField);

            if (_values.Length <= z)
                return false;
            if (_values[z].Length <= x)
                return false;

            return _values[z][x];
        }
    }
}
