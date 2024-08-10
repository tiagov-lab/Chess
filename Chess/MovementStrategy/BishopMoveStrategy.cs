using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.MovementStrategy
{
    internal class BishopMoveStrategy : IMoveStrategy
    {
        public List<Coordinate> GetPossibleMoves(Piece piece, Board board)
        {
            List<Coordinate> possibleMoves = new List<Coordinate>();

            int x = piece.Position.X;
            int y = piece.Position.Y;

            // All Queen directions
            Coordinate[] bishopDirections = new Coordinate[]
            {
                // Top left
                new Coordinate(x - 1, y + 1),
                // Top right
                new Coordinate(x + 1, y + 1),
                // Bottom left
                new Coordinate(x - 1, y - 1),
                // Bottom right
                new Coordinate(x + 1, y - 1),
            };

            foreach (Coordinate direction in bishopDirections)
            {
                possibleMoves.AddRange(MoveUtils.getMovesInDirection(board, piece, direction));
            }
            return possibleMoves;
        }
    }
}
