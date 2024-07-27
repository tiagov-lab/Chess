using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Position
    {
        public int X;
        public int Y;

        public Position(int inputX, int inputY)
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
