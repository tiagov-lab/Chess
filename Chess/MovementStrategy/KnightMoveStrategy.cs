using System.Collections.Generic;
using System.Text;

namespace Chess.MovementStrategy
{
    internal class KnightMoveStrategy : IMoveStrategy
    {
        public List<Coordinate> GetPossibleMoves(Board board, Piece piece, Coordinate inputCoordinate)
        {
            {
                List<Coordinate> possibleMoves = new List<Coordinate>();

                int x = piece.Coordinate.X;
                int y = piece.Coordinate.Y;

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
                    if (MoveUtils.CanMoveToCell(board, piece, move))
                    {
                        possibleMoves.Add(move);
                    }
                }

                return possibleMoves;
            }


        }
    }
}