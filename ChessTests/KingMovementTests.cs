using Chess;

namespace ChessTests;

[TestClass]
public class KingMovementTests
{
    [TestMethod]
    public void Tests_KingInCenter_Has8PossibleMoves()
    {
        // Arrange
        Board testBoard = new Board();
        testBoard.RemoveAllPieces();
        var piece = new Piece(new Coordinate(3, 3), Gameloop.Colour.White, Gameloop.PieceType.King);

        // Act
        var possibleMoveCount = piece.GetPossibleMoves(testBoard).Count();

        // Assert
        Assert.AreEqual(8, possibleMoveCount);
    }

    [TestMethod]
    public void Tests_King_CanMoveMultipleTimes()
    {

    }

    [TestMethod]
    public void Tests_King_CannotMoveToCheck()
    {
        // Arrange
        Board testBoard = new Board();
        testBoard.RemoveAllPieces();
        var king = new Piece(new Coordinate(3, 3), Gameloop.Colour.White, Gameloop.PieceType.King);
        var rook1 = new Piece(new Coordinate(3, 3), Gameloop.Colour.Black, Gameloop.PieceType.Rook); // Need to think of more descriptive names
        var rook2 = new Piece(new Coordinate(3, 3), Gameloop.Colour.Black, Gameloop.PieceType.Rook);

        // Act

        // Assert
    }
}
