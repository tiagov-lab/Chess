using Chess;

namespace xUnitChessTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            Board testBoard = new Board();
            testBoard.RemoveAllPieces();
            var piece = new Piece(new Coordinate(1, 1), Gameloop.Colour.White, Gameloop.PieceType.Rook);

            // Act
            var possibleMoveCount = piece.GetPossibleMoves(testBoard, piece.Coordinate, piece).Count();

            // Assert
            Assert.Equal(14, possibleMoveCount);
        }
    }
}