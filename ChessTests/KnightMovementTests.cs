using Chess;

namespace ChessTests;

[TestClass]
public class KnightMovementTests
{

    [TestMethod]
    public void Test_KnightInCenter_ShouldHaveEightPossibleMoves()
    {
        // Arrange
        Board testBoard = new Board();
        testBoard.RemoveAllPieces();
        var knight = new Piece(new Coordinate(3, 3), Gameloop.Colour.White, Gameloop.PieceType.Knight);
        testBoard.SetPiece(knight);

        // Act
        var possibleMoves = knight.GetPossibleMoves(testBoard, knight.Coordinate, knight);

        // Assert
        Assert.AreEqual(8, possibleMoves.Count);
    }

    [TestMethod]
    public void Knight_MovesInStraightLines()
    {
        // Arrange
        Board testBoard = new Board();
        testBoard.RemoveAllPieces();
        var knight = new Piece(new Coordinate(1, 1), Gameloop.Colour.White, Gameloop.PieceType.Knight);
        testBoard.SetPiece(knight);

        // Act
        var possibleMoves = knight.GetPossibleMoves(testBoard, knight.Coordinate, knight);

        // Assert
        Assert.AreEqual(14, possibleMoves.Count);
    }

}
