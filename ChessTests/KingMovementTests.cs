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
        testBoard.SetPiece(piece.Coordinate, piece);    

        // Act
        var possibleMoveCount = piece.GetPossibleMoves(testBoard, piece.Coordinate, piece).Count();

        // Assert
        Assert.AreEqual(8, possibleMoveCount);
    }

    [TestMethod]
    public void Tests_King_CannotMoveToCheck()
    {
        // Arrange
        Board testBoard = new Board();
        testBoard.RemoveAllPieces();
        var testKing = new Piece(new Coordinate(3, 3), Gameloop.Colour.White, Gameloop.PieceType.King);
        var testRookOne = new Piece(new Coordinate(4, 2), Gameloop.Colour.Black, Gameloop.PieceType.Rook);
        var testRookTwo = new Piece(new Coordinate(4, 4), Gameloop.Colour.Black, Gameloop.PieceType.Rook);

        testBoard.SetPiece(testKing.Coordinate, testKing);
        testBoard.SetPiece(testRookOne.Coordinate, testRookOne);
        testBoard.SetPiece(testRookTwo.Coordinate, testRookTwo);
        var CorrectPositionOne = new Coordinate(2, 3);


        // In this position, King should only have one legal move, to b3/3,2
        var CorrectPosition = new Coordinate(2, 3);

        // Act
        MoveUtils.MoveRandomly(testBoard, testKing);
        var kingPosition = testKing.Coordinate;


        // Assert
        Assert.AreEqual(CorrectPosition, kingPosition);
    }
}
