using Chess;

namespace ChessTests;

[TestClass]
public class RookMovementTests
{
    [TestMethod]
    public void Tests_RookInA1_Has14PossibleMoves()
    {
        // Arrange
        Board testBoard = new Board();
        testBoard.RemoveAllPieces();
        var piece = new Piece(new Coordinate(1, 1), Gameloop.Colour.White, Gameloop.PieceType.Rook);

        // Act
        var possibleMoveCount = piece.GetPossibleMoves(testBoard, piece.Coordinate, piece).Count();

        // Assert
        Assert.AreEqual(14, possibleMoveCount);
    }

    [TestMethod]
    public void MovesInStraightLines()
    {
        // Arrange
        Board testBoard = new Board();
        testBoard.RemoveAllPieces();
        var rook = new Piece(new Coordinate(1, 1), Gameloop.Colour.White, Gameloop.PieceType.Rook);
        var rookTwo = new Piece(new Coordinate(1, 2), Gameloop.Colour.White, Gameloop.PieceType.Rook);
        testBoard.SetPiece(rook);
        testBoard.SetPiece(rookTwo);

        // Act
        var possibleMoves = rook.GetPossibleMoves(testBoard, rook.Coordinate, rook);

        // Assert
        Assert.AreEqual(7, possibleMoves.Count);
    }
}
