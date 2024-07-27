// See https://aka.ms/new-console-template for more information
using Chess;
using Chess.MovementStrategy;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Board b = new Board();



foreach (var item in Piece.PieceList)
{

    if (item.Type == Piece.PieceType.Pawn)
    {

        var moves = item.GetPossibleMoves(b);

        if (moves.Count > 0)
        {
            Console.WriteLine(moves);
        }
        else
        {
            item.GetPossibleMoves(b);
        }
        
    }

}