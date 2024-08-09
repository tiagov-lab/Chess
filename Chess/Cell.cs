
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
        public string ?name; // Should the cell store the name, or should the position store the name?
        public Piece ?Piece;
        public Position Position;
        public bool isOccupied = false;    

        public Cell(int inputX, int inputY)
        {
            Position = new Position(inputX,inputY);
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

    }
}
