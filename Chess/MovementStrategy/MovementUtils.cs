using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.MovementStrategy
{
    public static class MoveUtils
    {
        public static List<(int, int)> GetLinearMoves(Piece piece, Board board, int[] dx, int[] dy)
        {
            var moves = new List<(int, int)>();
            for (int i = 0; i < dx.Length; i++)
            {
                int x = piece.Pos.X;
                int y = piece.Pos.Y;
                while (true)
                {
                    x += dx[i];
                    y += dy[i];

                    if (!board.IsValidPosition(x, y))
                        break;

                    if (board[y, x] == null)
                    {
                        moves.Add((x, y));
                    }

                    else
                    {
                        if (board[y, x].Color != piece.Color)
                            moves.Add((x, y));
                        break;
                    }
                }
            }
            return moves;
        }

        public static List<(int, int)> GetFixedMoves(Piece piece, Board board, int[] dx, int[] dy)
        {
            var moves = new List<(int, int)>();
            for (int i = 0; i < dx.Length; i++)
            {
                int x = piece.Pos.X + dx[i];
                int y = piece.Pos.Y + dy[i];
                if (board.IsValidPosition(x, y) && (board[y, x] == null || board[y, x].Color != piece.Color))
                {
                    moves.Add((x, y));
                }
            }
            return moves;
        }

    }
}
