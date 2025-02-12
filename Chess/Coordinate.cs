using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public struct Coordinate
    {
        public string name;
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
            return $"{name}";
        }

        public string positionNamer(int inputX, int inputY)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(TurnXIntoChar(inputX));

            sb.Append((inputY + 1));   

            return sb.ToString();
        }
        
        private char TurnXIntoChar(int inputX)
        {
            return Convert.ToChar(97 + inputX);
        }

    }
}
