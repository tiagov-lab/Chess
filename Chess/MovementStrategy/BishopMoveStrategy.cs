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

            // All Bishop directions
            Coordinate[] bishopDirections = new Coordinate[]
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

            foreach (Coordinate move in bishopDirections)
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
