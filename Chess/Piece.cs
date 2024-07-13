using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static Chess.Piece;

namespace Chess
{
    public class Piece
    {
        public (int X, int Y) Position { get; set; }
        public Colour Color { get; set; }
        public PieceType Type { get; set; }

        public enum Colour
        {
            White,
            Black
        }

        public enum PieceType
        {
            Pawn,
            Rook,
            Knight,
            Bishop,
            Queen,
            King
        }

        public Piece(int x, int y, Colour color, PieceType type)
        {
            Position = (x, y);
            Color = color;
            Type = type;
        }

        public void MoveTo(int x, int y)
        {
            Position = (x, y);
        }

        public override string ToString()
        {
              // If white
                // Switch statement
                // "case Rook: return ♖" etc

            return "♖";
        }
    }
}
