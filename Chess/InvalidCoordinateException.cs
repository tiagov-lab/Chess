using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class InvalidCoordinateException : Exception
    {
        public Coordinate Coordinate { get; }

        public InvalidCoordinateException(Coordinate inputCoordinate)
            : base($"{inputCoordinate} is invalid.")
        {
            Coordinate = inputCoordinate;
        }
    }
}
