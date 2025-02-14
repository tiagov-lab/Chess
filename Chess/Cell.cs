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

        public Coordinate Coordinate { get; }

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
            Coordinate = new Coordinate(inputX, inputY);
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
            if (Piece == null)
            {

            }
            else
            {
                Piece.Die();
                Piece = null;
            }

        }

        public override string ToString()
        {
            return Coordinate.ToString();
        }
    }
}
