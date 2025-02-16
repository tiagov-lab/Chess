using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.MovementStrategy
{
    internal class BishopMoveStrategy : IMoveStrategy
    {
        public List<Coordinate> GetPossibleMoves(Board inputBoard, Piece piece, Coordinate inputCoordinate)
        {
            List<Coordinate> possibleMoves = new List<Coordinate>();

            int x = piece.Coordinate.X;
            int y = piece.Coordinate.Y;

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
                possibleMoves.AddRange(MoveUtils.GetMovesInDirection(inputBoard, piece, direction));
            }
            return possibleMoves;
        }
    }
}
