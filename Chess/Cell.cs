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

        public Piece Piece
        {
            get => _piece;
            set
            {
                _piece = value;
                isOccupied = _piece != null;
            }
        }

        public bool isOccupied { get; private set; }

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
