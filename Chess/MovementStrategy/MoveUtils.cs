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
        removePieceFromCurrentCell(inputBoard, inputPiece, inputCoordinate);
        addPieceToNewCell(inputBoard, inputPiece, inputCoordinate);
        updatePiecesPosition(inputPiece, inputCoordinate); // Does this belong to the piece class?
    }
    
    private static void removePieceFromCurrentCell(Board inputBoard, Piece inputPiece, Coordinate inputCoordinate)
    {
        inputBoard.Cells[inputPiece.Position.X, inputPiece.Position.Y].RemovePiece();
    }

    private static void addPieceToNewCell(Board inputBoard, Piece inputPiece, Coordinate inputCoordinate)
    {
        inputBoard.Cells[inputCoordinate.X, inputCoordinate.Y].PlacePiece(inputPiece);
    }

    private static void updatePiecesPosition(Piece inputPiece, Coordinate inputCoordinate)
    {
        inputPiece.Position = inputCoordinate;
    }


    public static bool canMoveToCell(Board inputBoard, Piece inputPiece, Coordinate inputCoordinate)
    {
        // This needs to be checked before the inputCoordinate is searched in the board to avoid error.
        if (!inputBoard.IsValidPosition(inputCoordinate))
        {
            return false;
        }
        else
        {
            Cell movingToCell = inputBoard.Cells[inputCoordinate.X, inputCoordinate.Y];

            // If the cell is occupied by a piece of the same color, return false
            if (movingToCell.isOccupied && movingToCell.Piece.Color == inputPiece.Color)
            {
                return false;
            }
        }

        // The move is valid if the cell is empty or occupied by an opponent's piece
        return true;
    }
    public static List<Coordinate> getMovesInDirection(Board inputBoard, Piece inputPiece, Coordinate inputDirection)
    {
        // Helper method for pieces that can move indefinitelty in one direction (Queen, Bishop and Rook)
        // Takes in one direction as a Coordinate and searches continously.
        // (x, y + 1)  as input would search for all spaces upwads, (x, y - 1) downwards, etc.

        List<Coordinate> possibleMoves = new List<Coordinate>();
        int currentX = inputPiece.Position.X;
        int currentY = inputPiece.Position.Y;

        while (true)
        {
            currentX += inputDirection.X;
            currentY += inputDirection.Y;
            Coordinate newPosition = new Coordinate(currentX, currentY);

            if (!inputBoard.IsValidPosition(newPosition))
            {
                break;
            }

            if (canMoveToCell(inputBoard, inputPiece, newPosition))
            {
                possibleMoves.Add(newPosition);
            }
            else
            {
                break;
            }
        }

        return possibleMoves;
    }
}

