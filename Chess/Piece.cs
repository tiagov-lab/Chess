using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
        
        public Dictionary<PieceType, char> Colours { get; set; }

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
            switch (this.Color)
            {
                case Colour.White:
                    switch (this.Type)
                    {
                        case PieceType.King: return "\u2654";
                        case PieceType.Queen: return "\u2655";
                        case PieceType.Rook: return "\u2656";
                        case PieceType.Bishop: return "\u2657";
                        case PieceType.Knight: return "\u2658";
                        case PieceType.Pawn: return "\u2659";
                        default: return "?";
                    }

                case Colour.Black:
                    switch (this.Type)
                    {
                        case PieceType.King: return "\u265A";
                        case PieceType.Queen: return "\u265B";
                        case PieceType.Rook: return "\u265C";
                        case PieceType.Bishop: return "\u265D";
                        case PieceType.Knight: return "\u265E";
                        case PieceType.Pawn: return "\u265F";
                        default: return "?";
                    }

                default:
                    return "?";
            }
        }
    }
}
