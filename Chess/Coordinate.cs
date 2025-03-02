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

            sb.Append(TurnYIntoChar(inputY));  

            return sb.ToString();
        }
        
        private char TurnXIntoChar(int inputX)
        {
            return Convert.ToChar(96 + inputX);
        }
        private int TurnYIntoChar(int inputY)
        {
            return (inputY);
        }

        public static Coordinate operator +(Coordinate a, Coordinate b)
        {
            return new Coordinate(a.X + b.X, a.Y + b.Y);
        }

        public static Coordinate operator -(Coordinate a, Coordinate b)
        {
            return new Coordinate(a.X - b.X, a.Y - b.Y);
        }

    }
}
