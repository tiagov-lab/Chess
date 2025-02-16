using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class NoPieceFoundExeption : Exception
    {
        public Coordinate Coordinate { get; }

        public NoPieceFoundExeption(Coordinate inputCoordinate)
            : base($"No piece found at {inputCoordinate}")
        {
            Coordinate = inputCoordinate;
        }
    }
}

