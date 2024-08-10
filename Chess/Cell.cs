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
        private Piece _piece;
        public Coordinate Position { get; }

        public Piece ?Piece
        {
            get => _piece;
            set
            {
                _piece = value;
                isOccupied = true;
            }
        }

        public bool isOccupied { get; set; }

        public Cell(int inputX, int inputY)
        {
            Position = new Coordinate(inputX, inputY);
            isOccupied = false;
        }

        public void PlacePiece(Piece inputPiece)
        {
            if (isOccupied)
            {
                // Add code here for keeping track of eaten pieces
            }

            isOccupied = true;
            Piece = inputPiece;
        }

        public void RemovePiece()
        {
            isOccupied = false;
            Piece = null;
        }

        public override string ToString()
        {
            return Position.ToString();
        }
    }
}
