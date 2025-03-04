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

    /// <summary>
    /// Calculates all valid moves in a specific direction from a piece's position.
    /// </summary>
    /// <param name="inputBoard">The current chess board</param>
    /// <param name="inputPiece">The piece to calculate moves for</param>
    /// <param name="offsetVector">The directional offset vector (e.g., (0,1) for up, (1,0) for right)</param>
    /// <returns>A list of valid coordinates the piece can move to in the specified direction</returns>
    public static List<Coordinate> GetMovesInDirection(Board inputBoard, Piece inputPiece, Coordinate offsetVector)
    {
        var moves = new List<Coordinate>();
        var currentPos = CoordinateExtension.Offset(inputPiece.Coordinate, offsetVector);

        while (inputBoard.IsValidPosition(currentPos))
        {
            if (CanMoveToCell(inputBoard, inputPiece, currentPos))
            {
                moves.Add(currentPos);
                currentPos = CoordinateExtension.Offset(currentPos, offsetVector);
            }
            else
            {
                break;
            }
        }

        return moves;

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

    public static List<Coordinate> GetEnemyPossibleMoves(Piece piece, Board inputBoard) 
    {
        return PieceTracker.GetEnemyPieces(piece)
            .SelectMany(enemy => enemy.GetPossibleMoves(inputBoard, piece.Coordinate, piece))
            .ToList();
    }

}
