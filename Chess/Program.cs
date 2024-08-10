// See https://aka.ms/new-console-template for more information
using Chess;
using Chess.MovementStrategy;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Board b = new Board();

b.DisplayBoard();


var WhiteKnights = from p in Piece.PieceList
                   where p.Type == Gameloop.PieceType.Knight
                   select p;

foreach (var p in WhiteKnights)
{
    Console.WriteLine();

    Console.WriteLine($"{p}:{p.Position}");
    var MoveList = p.GetPossibleMoves(b);
    foreach (var move in MoveList)
    {
        Console.Write($"{move} ");
    }
}