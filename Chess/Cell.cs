
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Cell
    {
        public Piece ?Piece;
        public Coordinate Position;
        public bool isOccupied = false;    

        public Cell(int inputX, int inputY)
        {
            Position = new Coordinate(inputX,inputY);
        }

        public void PlacePiece(Piece inputPiece) 
        {
            if (isOccupied)
            {
                // Add code here for keeping track of eaten pieces
            }

            else
            {
                isOccupied = true;
            }

            Piece = inputPiece;
        }

        public void RemovePiece()
        {
            Piece = null;
            isOccupied = false;
        }

        public override string ToString()
        {
            return Position.ToString();
        }

    }
}
