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
            // Check if rook is in first space
             // Take colour into account
            //
             // Check if there is a piece in tile ahead, break loop
             // If there isn't, check if there is an enemy piece in diagonal spaces
               // Add those spaces to list
            throw new NotImplementedException();
        }
    }
}
