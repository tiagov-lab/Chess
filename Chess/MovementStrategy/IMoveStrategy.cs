using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.MovementStrategy
{
    public interface IMoveStrategy
    {
        List<(int, int)> GetPossibleMoves(Piece piece, Board board);
    }
}
