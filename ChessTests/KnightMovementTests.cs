using Chess;

namespace ChessTests;

[TestClass]
public class KnightMovementTests
{

    [TestMethod]
    public void KnightInCenter_ShouldHaveEightPossibleMoves()
    {
        // Arrange
        Board testBoard = new Board();
        testBoard.RemoveAllPieces();
        var knight = new Piece(new Coordinate(3, 3), Gameloop.Colour.White, Gameloop.PieceType.Knight);

        // Act
        var possibleMoves = knight.GetPossibleMoves(testBoard);

        // Assert
        Assert.AreEqual(8, possibleMoves.Count);
    }
}
