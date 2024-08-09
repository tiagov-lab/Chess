using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public struct Coordinate
    {
        public int X;
        public int Y;

        public Coordinate(int inputX, int inputY)
        {
            this.X = inputX;
            this.Y = inputY;
        }

        public override string ToString()
        {
            return $"{X}, {Y}";
        }
    }
}
