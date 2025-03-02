using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public static class RenderGame
    {
        private static string whiteTile = "█";
        private static string blackTile = "░";

        public static void DisplayBoard(Board inputBoard)
        {
            StringBuilder boardDisplay = new StringBuilder();
            bool isWhite = true;

            for (int i = Board.BoardSize; i > 0; i--)
            {
                for (int j = Board.BoardSize; j > 0; j--)
                {
                    var tempCoordinate = new Coordinate(i, j);

                    if ( inputBoard.GetCell(tempCoordinate).isOccupied() )
                    {
                        boardDisplay.Append(inputBoard.GetPiece(tempCoordinate));
                    }

                    else
                    {
                        boardDisplay.Append(isWhite ? whiteTile : blackTile);
                    }

                    isWhite = !isWhite;
                }
                isWhite = !isWhite;
                boardDisplay.AppendLine();
            }

            Console.WriteLine(boardDisplay.ToString());


            //StringBuilder boardDisplay = new StringBuilder();
            //bool isWhite = true;

            //for (int x = 0; x < BoardSize; x++)
            //{
            //    for (int y = 0; y < BoardSize; y++)
            //    {
            //        if (Cells[y, x].isOccupied())
            //        {
            //            boardDisplay.Append(Cells[y, x].Piece);
            //        }
            //        else
            //        {
            //            boardDisplay.Append(isWhite ? whiteTile : blackTile);
            //        }
            //        isWhite = !isWhite;
            //    }
            //    isWhite = !isWhite;
            //    boardDisplay.AppendLine();
            //}

            //Console.Write(boardDisplay.ToString());
        }
    }
}
