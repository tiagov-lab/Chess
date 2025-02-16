using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.MovementStrategy
{
    public interface IMoveStrategy
    {
        List<Coordinate> GetPossibleMoves(Board inputBoard, Piece inputPiece, Coordinate inputCoordinate);
    }
}
