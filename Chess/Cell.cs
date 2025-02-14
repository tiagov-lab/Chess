using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Chess
{
    public class Cell
    {

        public Coordinate Position { get; }

        public Piece? Piece = null;

        public bool isOccupied()
        {
            if (Piece == null)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        public Cell(int inputX, int inputY)
        {
            Position = new Coordinate(inputX, inputY);
        }

        public void PlacePiece(Piece inputPiece)
        {
            if (isOccupied())
            {
                // Add code here for keeping track of eaten pieces
            }

            Piece = inputPiece;
        }

        public void RemovePiece()
        {
            Piece = null;
        }

        public override string ToString()
        {
            return Position.ToString();
        }
    }
}
