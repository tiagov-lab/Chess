// See https://aka.ms/new-console-template for more information
using Chess;
using Chess.MovementStrategy;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Board testBoard = new Board();
testBoard.RemoveAllPieces();
var knight = new Piece(new Coordinate(3, 3), Gameloop.Colour.White, Gameloop.PieceType.Knight);


for (int i = 0; i < 10; i++)
{
    var possibleMoves = knight.GetPossibleMoves(testBoard);
    MoveUtils.movePiece(testBoard, knight, possibleMoves[0]);
    testBoard.DisplayBoard();
}