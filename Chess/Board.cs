using Chess;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Chess.Piece;


namespace Chess
{
    public class Board
    {
        private const int BoardSize = 8;
        private readonly string whiteTile = " ";
        private readonly string blackTile = "#";

        public Cell[,] Cells { get; private set; }

        public Board()
        {
            Cells = new Cell[BoardSize, BoardSize];
            InitializeBoard();
        }

        // Indexer
        public Cell this[int row, int col]
        {
            get
            {
                if (IsValidPosition(row, col))
                    return Cells[row, col];
                throw new IndexOutOfRangeException("Invalid board position");
            }
        }

        private void InitializeBoard()
        {
            // Initialize all cells
            for (int row = 0; row < BoardSize; row++)
            {
                for (int col = 0; col < BoardSize; col++)
                {
                    Cells[row, col] = new Cell(row, col);
                }
            }

            // Place white pieces
            PlacePiece(0, 0, Gameloop.Colour.White, Gameloop.PieceType.Rook);
            PlacePiece(0, 1, Gameloop.Colour.White, Gameloop.PieceType.Knight);
            PlacePiece(0, 2, Gameloop.Colour.White, Gameloop.PieceType.Bishop);
            PlacePiece(0, 3, Gameloop.Colour.White, Gameloop.PieceType.Queen);
            PlacePiece(0, 4, Gameloop.Colour.White, Gameloop.PieceType.King);
            PlacePiece(0, 5, Gameloop.Colour.White, Gameloop.PieceType.Bishop);
            PlacePiece(0, 6, Gameloop.Colour.White, Gameloop.PieceType.Knight);
            PlacePiece(0, 7, Gameloop.Colour.White, Gameloop.PieceType.Rook);

            // Place white pawns
            for (int col = 0; col < BoardSize; col++)
            {
                PlacePiece(1, col, Gameloop.Colour.White, Gameloop.PieceType.Pawn);
            }

            // Place black pieces
            PlacePiece(7, 0, Gameloop.Colour.Black, Gameloop.PieceType.Rook);
            PlacePiece(7, 1, Gameloop.Colour.Black, Gameloop.PieceType.Knight);
            PlacePiece(7, 2, Gameloop.Colour.Black, Gameloop.PieceType.Bishop);
            PlacePiece(7, 3, Gameloop.Colour.Black, Gameloop.PieceType.Queen);
            PlacePiece(7, 4, Gameloop.Colour.Black, Gameloop.PieceType.King);
            PlacePiece(7, 5, Gameloop.Colour.Black, Gameloop.PieceType.Bishop);
            PlacePiece(7, 6, Gameloop.Colour.Black, Gameloop.PieceType.Knight);
            PlacePiece(7, 7, Gameloop.Colour.Black, Gameloop.PieceType.Rook);

            // Place black pawns
            for (int col = 0; col < BoardSize; col++)
            {
                PlacePiece(6, col, Gameloop.Colour.Black, Gameloop.PieceType.Pawn);
            }
        }

        private void PlacePiece(int row, int col, Gameloop.Colour color, Gameloop.PieceType type)
        {
            Cells[row, col].PlacePiece(
                new Piece(new Position(col, row), color, type)
                );
        }

        public void DisplayBoard()
        {
            Console.Clear();

        
        }

        public bool IsValidPosition(int row, int col)
        {
            return row >= 0 && row < BoardSize && col >= 0 && col < BoardSize;
        }
    }
}

