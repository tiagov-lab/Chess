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
                new Coordinate(x + 1, y + 2),
                new Coordinate(x + 2, y + 1),
                new Coordinate(x + 2, y - 1),
                new Coordinate(x + 1, y - 2),
                new Coordinate(x - 1, y - 2),
                new Coordinate(x - 2, y - 1),
                new Coordinate(x - 2, y + 1),
                new Coordinate(x - 1, y + 2)
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