﻿using Chess;
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
        private string whiteTile = " ";
        private string blackTile = "#";

        public Piece[,] board;

        public Board()
        {
            board = new Piece[8, 8];
            InitializeBoard();
        }

        // Indexer
        public Piece? this[int row, int col]
        {
            get
            {
                if (IsValidPosition(row, col))
                    return board[row, col];
                return null;
            }
            set
            {
                // Don't use now! Figure out a better way later
                if (IsValidPosition(row, col))
                    board[row, col] = value;
            }
        }

        private void InitializeBoard()
        {
            // Place white pieces
            PlacePiece(0, 0, Colour.White, PieceType.Rook);
            PlacePiece(0, 1, Colour.White, PieceType.Knight);
            PlacePiece(0, 2, Colour.White, PieceType.Bishop);
            PlacePiece(0, 3, Colour.White, PieceType.Queen);
            PlacePiece(0, 4, Colour.White, PieceType.King);
            PlacePiece(0, 5, Colour.White, PieceType.Bishop);
            PlacePiece(0, 6, Colour.White, PieceType.Knight);
            PlacePiece(0, 7, Colour.White, PieceType.Rook);

            // Place white pawns
            for (int col = 0; col < 8; col++)
            {
                PlacePiece(1, col, Colour.White, PieceType.Pawn);
            }

            // Place black pieces
            PlacePiece(7, 0, Colour.Black, PieceType.Rook);
            PlacePiece(7, 1, Colour.Black, PieceType.Knight);
            PlacePiece(7, 2, Colour.Black, PieceType.Bishop);
            PlacePiece(0, 3, Colour.White, PieceType.Queen);
            PlacePiece(7, 4, Colour.Black, PieceType.King);
            PlacePiece(7, 5, Colour.Black, PieceType.Bishop);
            PlacePiece(7, 6, Colour.Black, PieceType.Knight);
            PlacePiece(7, 7, Colour.Black, PieceType.Rook);

            // Place black pawns
            for (int col = 0; col < 8; col++)
            {
                PlacePiece(6, col, Colour.Black, PieceType.Pawn);
            }
        }

        private void PlacePiece(int x, int y, Colour color, PieceType type)
        {
            board[y, x] = new Piece(new Position(x, y), color, type);
        }

        public void displayBoard()
        {
            bool isWhite = true;
            Console.Clear();

            for (int col = 0; col < 8; col++)
            {
                for (int row = 0; row < 8; row++)
                {
                    if (board[row, col] == null)
                    {
                        if (isWhite)
                        {
                            Console.Write(whiteTile);
                        }
                        else
                        {
                            Console.Write(blackTile);
                        }
                    }
                    else
                    {
                        Console.Write(board[row, col]);
                    }

                    isWhite = !isWhite;
                }

                isWhite = !isWhite;

                Console.WriteLine();
            }
        }

        public Piece? GetPieceAt(int x, int y)
        {
            if (IsValidPosition(x, y))
                return board[y, x];
            return null;
        }

        public bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x < 8 && y >= 0 && y < 8;
        }
    }
}

   


