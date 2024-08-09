using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public struct Coordinate
    {
        public string ?name;
        public int X;
        public int Y;

        public Coordinate(int inputX, int inputY)
        {
            this.X = inputX;
            this.Y = inputY;

            name = positionNamer(inputX, inputY);
        }

        public override string ToString()
        {
            return $"{X}, {Y}";
        }

        public string positionNamer(int inputX, int inputY)
        {
            StringBuilder sb = new StringBuilder();

            // Turning X into letter
            sb.Append(Convert.ToChar(96 + inputX + 1));

            /// Add Y
            sb.Append(inputY);

            return sb.ToString();
        }
    }
}
