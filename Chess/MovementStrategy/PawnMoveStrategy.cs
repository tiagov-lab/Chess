using System;
using System.Collections.Generic;

namespace Chess.MovementStrategy
{
    internal class PawnMoveStrategy : IMoveStrategy
    {
        public List<(int, int)> GetPossibleMoves(Piece piece, Board board)
        {
            var possibleMoves = new List<(int, int)>();

            // Calculate relative positions based on color
            int forwardOne = piece.Color == Piece.Colour.White ? 1 : -1;
            int forwardTwo = piece.Color == Piece.Colour.White ? 2 : -2;

            (int, int) oneForward = (piece.Pos.X + forwardOne, piece.Pos.Y);
            (int, int) twoForward = (piece.Pos.X + forwardTwo, piece.Pos.Y );
            (int, int) captureLeft = (piece.Pos.X - 1, piece.Pos.Y + forwardOne);
            (int, int) captureRight = (piece.Pos.X + 1, piece.Pos.Y + forwardOne);

            // Check one space forward
            var nextPiece = board.GetPieceAt(oneForward.Item1, oneForward.Item2);

            if (nextPiece == null) 
                
            {
                possibleMoves.Add(oneForward);

                // Check twospace forward
                bool isStartingRank = (piece.Color == Piece.Colour.White && piece.Pos.Y == 1) ||
                                      (piece.Color == Piece.Colour.Black && piece.Pos.Y == 6);
                if (isStartingRank && board.GetPieceAt(twoForward.Item1, twoForward.Item2) == null)
                {
                    possibleMoves.Add(twoForward);
                }
            }

            // Check diagonal captures
            CheckDiagonalCapture(board, piece, captureLeft, possibleMoves);
            CheckDiagonalCapture(board, piece, captureRight, possibleMoves);

            // TODO: Implement en passant logic

            return possibleMoves;
        }

        private void CheckDiagonalCapture(Board board, Piece piece, (int, int) capturePos, List<(int, int)> possibleMoves)
        {
            if (board.IsValidPosition(capturePos.Item1, capturePos.Item2))
            {
                Piece? targetPiece = board[capturePos.Item2, capturePos.Item1];
                if (targetPiece != null && targetPiece.Color != piece.Color)
                {
                    possibleMoves.Add(capturePos);
                }
            }
        }
    }
}