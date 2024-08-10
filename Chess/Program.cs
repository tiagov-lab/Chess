// See https://aka.ms/new-console-template for more information
using Chess;
using Chess.MovementStrategy;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Board b = new Board();

b.DisplayBoard();


var List = b.Cells[0, 6].Piece.GetPossibleMoves(b);

foreach (var item in List)
{
    Console.WriteLine(
        (item.name)
    );
    
}