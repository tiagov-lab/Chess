using System.Collections.Generic;

namespace Chess.MovementStrategy
{
    internal class KnightMoveStrategy : IMoveStrategy
    {
        public List<Coordinate> GetPossibleMoves(Piece piece, Board board)
        {
            List<Coordinate> possibleMoves = new List<Coordinate>();

            int x = piece.Position.X;
            int y = piece.Position.Y;

            // All possible knight moves
            Coordinate[] knightMoves = new Coordinate[]
            {
                // Top left
                new Coordinate(x - 1, y + 1),
                // Top
                new Coordinate(x, y + 1),
                // Top right
                new Coordinate(x + 1, y + 1),
                // Left
                new Coordinate(x - 1, y),
                // Right
                new Coordinate(x + 1, y),
                // Bottom left
                new Coordinate(x - 1, y - 1),
                // Bottom
                new Coordinate(x, y - 1),
                // Bottom right
                new Coordinate(x + 1, y - 1),
            };

            foreach (Coordinate move in knightMoves)
            {
                if (MoveUtils.canMoveToCell(board, piece, move))
                {
                    possibleMoves.Add(move);
                }
            }

            return possibleMoves;
        }
    }
}