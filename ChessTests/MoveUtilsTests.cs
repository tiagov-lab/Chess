using Chess;

namespace ChessTests;

[TestClass]
public class MoveUtilsTests
{
    [TestMethod]
    public void GetAllMovesInDirection()
    {
        // Arrange

        /// Initiliaze Board
        Board testBoard = new Board();
        testBoard.RemoveAllPieces();

        /// Add Knight
        var rook = new Piece(new Coordinate(1, 1), Gameloop.Colour.White, Gameloop.PieceType.Rook);
        testBoard.SetPiece(rook);

        /// CorrectMoves
        List<Coordinate> correctMoves = new List<Coordinate>();
        correctMoves.Add(new Coordinate(1, 2));
        correctMoves.Add(new Coordinate(1, 3));
        correctMoves.Add(new Coordinate(1, 4));
        correctMoves.Add(new Coordinate(1, 5));
        correctMoves.Add(new Coordinate(1, 6));
        correctMoves.Add(new Coordinate(1, 7));
        correctMoves.Add(new Coordinate(1, 8));

        correctMoves.Add(new Coordinate(2, 1));
        correctMoves.Add(new Coordinate(3, 1));
        correctMoves.Add(new Coordinate(4, 1));
        correctMoves.Add(new Coordinate(5, 1));
        correctMoves.Add(new Coordinate(6, 1));
        correctMoves.Add(new Coordinate(7, 1));
        correctMoves.Add(new Coordinate(8, 1));


        // Act
        var possibleMoves = rook.GetPossibleMoves(testBoard, rook.Coordinate, rook);

        // Assert
        Assert.AreEqual(correctMoves, possibleMoves);
    }



}
