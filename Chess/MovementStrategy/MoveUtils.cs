using Chess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class MoveUtils
{
    public static void movePiece(Board inputBoard, Piece inputPiece, Coordinate inputCoordinate)
    {
        // Remove Piece from current cell 
        inputBoard.Cells[inputPiece.Pos.X, inputPiece.Pos.Y].RemovePiece();

        // Add Piece to new cell
        inputBoard.Cells[inputCoordinate.X, inputCoordinate.Y].PlacePiece(inputPiece);
    }

    public static bool canMoveToCell(Board inputBoard, Piece inputPiece, Coordinate inputCoordinate)
    {
        // This needs to be checked before the inputCoordinate is searched in the board to avoid error.
        if (!inputBoard.IsValidPosition(inputCoordinate.X, inputCoordinate.Y))
        {
            return false;
        }

        Cell movingToCell = inputBoard.Cells[inputCoordinate.X, inputCoordinate.Y];

        // If the cell is occupied by a piece of the same color, return false
        if (movingToCell.isOccupied && movingToCell.Piece.Color == inputPiece.Color)
        {
            return false;
        }

        // The move is valid if the cell is empty or occupied by an opponent's piece
        return true;
    }



}

