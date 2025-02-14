// See https://aka.ms/new-console-template for more information
using Chess;
using Chess.MovementStrategy;
using System.Diagnostics.Metrics;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Board testBoard = new Board();
testBoard.RemoveAllPieces();

var king = new Piece(new Coordinate(3, 3), Gameloop.Colour.White, Gameloop.PieceType.King);
var rook1 = new Piece(new Coordinate(4, 4), Gameloop.Colour.Black, Gameloop.PieceType.Rook); // Need to think of more descriptive names
var rook2 = new Piece(new Coordinate(4, 2), Gameloop.Colour.Black, Gameloop.PieceType.Rook);



testBoard.DisplayBoard();