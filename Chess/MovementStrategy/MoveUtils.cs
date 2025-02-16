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
        AddPieceToNewCell(inputBoard, inputPiece, inputCoordinate);
        RemovePieceFromCurrentCell(inputBoard, inputCoordinate);
        UpdatePiecesCoordinate(inputPiece, inputCoordinate);
    }
    private static void AddPieceToNewCell(Board inputBoard, Piece inputPiece, Coordinate inputCoordinate)
    {
        inputBoard.SetPiece(inputCoordinate, inputPiece);
    }

    private static void RemovePieceFromCurrentCell(Board inputBoard, Coordinate inputCoordinate)
    {
        inputBoard.RemovePiece(inputCoordinate);
    }

    private static void UpdatePiecesCoordinate(Piece inputPiece, Coordinate inputCoordinate)
    {
        inputPiece.Coordinate = inputCoordinate;
    }


    public static bool CanMoveToCell(Board inputBoard, Piece inputPiece, Coordinate inputCoordinate)
    {
        if (!inputBoard.IsValidPosition(inputCoordinate))
        {
            return false;
        }
        else
        {
            Cell movingToCell = inputBoard.GetCell(inputCoordinate);

            if (movingToCell.isOccupied())
            {
                if (movingToCell.Piece != null)
                {
                    if (movingToCell.Piece.Color == inputPiece.Color)
                    {
                        return false;
                    }
                }
            }
        }

        return true;
    }

    public static List<Coordinate> GetMovesInDirection(Board inputBoard, Piece inputPiece, Coordinate inputDirection)
    {
        // Helper method for pieces that can move indefinitelty in one direction (Queen, Bishop and Rook)
        // Takes in one direction as a Coordinate and searches continously.
        // (x, y + 1)  as input would search for all spaces upwads, (x, y - 1) downwards, etc.

        List<Coordinate> possibleMoves = new List<Coordinate>();
        int currentX = inputPiece.Coordinate.X;
        int currentY = inputPiece.Coordinate.Y;
        int moveCounter = 0;

        while (moveCounter < Board.BoardSize)
        {
            currentX += inputDirection.X;
            currentY += inputDirection.Y;
            Coordinate newPosition = new Coordinate(currentX, currentY);

            if (!inputBoard.IsValidPosition(newPosition))
            {
                break;
            }

            if (CanMoveToCell(inputBoard, inputPiece, newPosition))
            {
                possibleMoves.Add(newPosition);
            }
            else
            {
                break;
            }

            moveCounter++;
        }

        return possibleMoves;
    }

    public static Coordinate GetRandomMove(Board inputBoard, Piece inputPiece)
    {
        var random = new Random();
        var possibleMoves = inputPiece.GetPossibleMoves(inputBoard, inputPiece.Coordinate, inputPiece);
        var randomMoveIndex = random.Next(possibleMoves.Count);

        return possibleMoves[randomMoveIndex];
    }

    public static void MoveRandomly(Board inputBoard, Piece inputPiece)
    {
        MovePiece(inputBoard, inputPiece, GetRandomMove(inputBoard, inputPiece));
    }

}

