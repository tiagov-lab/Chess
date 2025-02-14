// See https://aka.ms/new-console-template for more information
using Chess;
using Chess.MovementStrategy;
using System.Diagnostics.Metrics;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Board testBoard = new Board();
testBoard.RemoveAllPieces();
var knight = new Piece(new Coordinate(3, 3), Gameloop.Colour.White, Gameloop.PieceType.King);

var SleepMS = 350;
var random = new Random();
int counter = 0;
while (counter < 1000000)
{
    Thread.Sleep(SleepMS);
    Console.SetCursorPosition(0, 0);
    var possibleMoves = knight.GetPossibleMoves(testBoard);
    // Select a random move from the possible moves
    var randomMoveIndex = random.Next(possibleMoves.Count);
    MoveUtils.movePiece(testBoard, knight, possibleMoves[randomMoveIndex]);
    testBoard.DisplayBoard();
    counter++;
}