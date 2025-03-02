// See https://aka.ms/new-console-template for more information
using Chess;
using Chess.MovementStrategy;
using System.Diagnostics.Metrics;
Console.OutputEncoding = System.Text.Encoding.UTF8;

var tempBoard = new Board();

RenderGame.DisplayBoard(tempBoard);