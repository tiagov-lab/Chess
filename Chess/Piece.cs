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
        public Coordinate Position { get; set; }
        public Gameloop.Colour Color { get; set; }
        public Gameloop.PieceType Type { get; set; }

        private IMoveStrategy moveStrategy;

        public Piece(Coordinate inputPosition, Gameloop.Colour inputColor, Gameloop.PieceType inputType)
        {
            Position = inputPosition;
            Color = inputColor;
            Type = inputType;
            PieceList.Add(this);
            SetMoveStrategy();
        }

        public override string ToString()
        {
            string pieceNotation = Type switch
            {
                Gameloop.PieceType.King => "K",
                Gameloop.PieceType.Queen => "Q",
                Gameloop.PieceType.Rook => "R",
                Gameloop.PieceType.Bishop => "B",
                Gameloop.PieceType.Knight => "N",
                Gameloop.PieceType.Pawn => "P", // Ugh, pawn has no offical algebraic notation, this will do for now.
                _ => "?"
            };

            return Color == Gameloop.Colour.White ? pieceNotation.ToUpper() : pieceNotation.ToLower();
        }

        private void SetMoveStrategy()
        {
            moveStrategy = Type switch
            {
                Gameloop.PieceType.Pawn => new PawnMoveStrategy(),
                Gameloop.PieceType.Rook => new RookMoveStrategy(),
                Gameloop.PieceType.Knight => new KnightMoveStrategy(),
                Gameloop.PieceType.Bishop => new BishopMoveStrategy(),
                Gameloop.PieceType.Queen => new QueenMoveStrategy(),
                Gameloop.PieceType.King => new KingMoveStrategy(),
                _ => throw new ArgumentException("Unknown piece type")
            };
        }

        public List<Coordinate> GetPossibleMoves(Board board)
        {
            return moveStrategy.GetPossibleMoves(this, board);
        }
    }
}
