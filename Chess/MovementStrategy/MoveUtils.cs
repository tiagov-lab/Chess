using Chess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class MoveUtils
{
    public static void MovePiece(Board inputBoard, Piece inputPiece, Coordinate inputCoordinate)
    {
        // Remove Piece from current cell 
        inputBoard.Cells[inputPiece.Pos.X, inputPiece.Pos.Y].RemovePiece();

        // Add Piece to new cell
        inputBoard.Cells[inputCoordinate.X, inputCoordinate.Y].PlacePiece(inputPiece);
    }

    public static bool canMoveToCell(Board inputBoard, Piece inputPiece, Coordinate inputCoordinate)
    {
        Cell movingToCell = inputBoard.Cells[inputCoordinate.X, inputCoordinate.Y];

        if (inputBoard.IsValidPosition(inputCoordinate.X, inputCoordinate.Y))
        {
            if (movingToCell.isOccupied)
            {
                if (movingToCell.Piece.Color == inputPiece.Color)
                {
                    return false;
                }

                else
                {
                    return true;
                }

            }

            else
            {
                return true;
            }
        }

        else
        {
            return false;
        }

    }
}

