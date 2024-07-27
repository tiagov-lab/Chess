using Chess.MovementStrategy;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static Chess.Piece;

namespace Chess
{
    public class Piece
    {
        public static List<Piece> PieceList = new List<Piece>();
        public Position Pos { get; set; }
        public Gameloop.Colour Color { get; set; }
        public Gameloop.PieceType Type { get; set; }

        private IMoveStrategy moveStrategy;


        public Piece(Position inputPosition, Gameloop.Colour inputColor, Gameloop.PieceType inputType)
        {
            Pos = inputPosition;
            Color = inputColor;
            Type = inputType;
            PieceList.Add(this);
            SetMoveStrategy();
        }

        public override string ToString()
        {
            switch (this.Color)
            {
                case Gameloop.Colour.White:
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

        private void SetMoveStrategy()
        {
            moveStrategy = Type switch
            {
                PieceType.Pawn => new PawnMoveStrategy(),
                PieceType.Rook => new RookMoveStrategy(),
                PieceType.Knight => new KnightMoveStrategy(),
                PieceType.Bishop => new BishopMoveStrategy(),
                PieceType.Queen => new QueenMoveStrategy(),
                PieceType.King => new KingMoveStrategy(),
                _ => throw new ArgumentException("Unknown piece type")
            };
        }

        public List<(int,int)> GetPossibleMoves(Board board)
        {
            return moveStrategy.GetPossibleMoves(this, board);
        }
    }
}
