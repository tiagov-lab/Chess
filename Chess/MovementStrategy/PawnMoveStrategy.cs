using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.MovementStrategy
{
    internal class PawnMoveStrategy : IMoveStrategy
    {
        public List<(int, int)> GetPossibleMoves(Piece piece, Board board)
        {
            var returnList = new List<(int, int)>();
            // Check if rook is in first space
            if (piece.Color == Piece.Colour.White)
            {
                if (piece.Position.Y == 1)
                {
                    // If there is another piece there
                    if (board[piece.Position.X, piece.Position.Y + 2] == null) 
                    {
                        returnList.Add((piece.Position.X, piece.Position.Y + 2));
                    }
                }
            }
            else
            {
                if (piece.Position.Y == 6)
                {
                    returnList.Add((piece.Position.X, piece.Position.Y - 2));
                }
            }
             // Take colour into account
            //
             // Check if there is a piece in tile ahead, break loop
             // If there isn't, check if there is an enemy piece in diagonal spaces
               // Add those spaces to list
            throw new NotImplementedException();
        }
    }
}
