using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.MovementStrategy
{
    internal class KingMoveStrategy : IMoveStrategy
    {
        public List<Coordinate> GetPossibleMoves(Piece piece, Board board)
        {
            List<Coordinate> possibleMoves = new List<Coordinate>();
            List<Coordinate> enemyPossibleMoves = GetEnemyPossibleMoves(piece, board);

            int x = piece.Coordinate.X;
            int y = piece.Coordinate.Y;


            // All possible king moves
            Coordinate[] kingMoves = new Coordinate[]
            {
                // Top left
                new(x - 1, y + 1),
                // Top
                new(x, y + 1),
                // Top right
                new(x + 1, y + 1),
                // Left
                new(x - 1, y),
                // Right
                new(x + 1, y),
                // Bottom left
                new Coordinate(x - 1, y - 1),
                // Bottom
                new Coordinate(x, y - 1),
                // Bottom right
                new Coordinate(x + 1, y - 1),
            };

            // Remove moves where king would be in check
            var kingMovesMinusEnemyMoves = kingMoves.Except(enemyPossibleMoves);

            foreach (Coordinate move in kingMovesMinusEnemyMoves)
            {
                if (MoveUtils.CanMoveToCell(board, piece, move))
                {
                    possibleMoves.Add(move);
                }
            }
            return possibleMoves;
        }

        private List<Coordinate> GetEnemyPossibleMoves(Piece piece, Board inputBoard) // should it moved to MoveUtils?
        {
            List<Coordinate> possibleMoves = new List<Coordinate>();

            var EnemyPieces =
                from p in Piece.PieceList
                where p.Color != piece.Color
                select p;

            if (EnemyPieces.Count() == 0)
            {
                return possibleMoves;
            }

            foreach (var p in EnemyPieces)
            {
                var tempMoves = p.GetPossibleMoves(inputBoard);

                possibleMoves.AddRange(tempMoves);
            }

            return possibleMoves;
        }
    }
}