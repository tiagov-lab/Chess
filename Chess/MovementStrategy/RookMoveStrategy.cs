using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.MovementStrategy
{
    internal class RookMoveStrategy : IMoveStrategy
    {
        public List<Coordinate> GetPossibleMoves(Board inputBoard, Piece inputPiece, Coordinate inputCoordinate)
        {
            List<Coordinate> possibleMoves = new List<Coordinate>();

            int x = inputPiece.Coordinate.X;
            int y = inputPiece.Coordinate.Y;

            // All Queen directions
            Coordinate[] rookDirections = new Coordinate[]
            {
                // Top
                new Coordinate(x, y + 1),
                // Left
                new Coordinate(x - 1, y),
                // Right
                new Coordinate(x + 1, y),
                // Bottom
                new Coordinate(x, y - 1),
            };

            foreach (Coordinate direction in rookDirections)
            {
                possibleMoves.AddRange(MoveUtils.GetMovesInDirection(inputBoard, inputPiece, direction));
            }
            return possibleMoves;
        }
    }
}
