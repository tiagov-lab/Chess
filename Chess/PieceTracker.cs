using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public static class PieceTracker
    {
        private static List<Piece> _activePieces = new List<Piece>();
        private static List<Piece> _capturedPieces = new List<Piece>();

        public static void AddToPieceTracker(Piece piece)
        {
            _activePieces.Add(piece);
        }

        public static void RemoveFromPieceTracker(Piece piece)
        {
            _activePieces.Remove(piece);
        }

        public static void AddToGraveyard(Piece piece)
        {
            RemoveFromPieceTracker(piece);
            _capturedPieces.Add(piece);
        }

        public static List<Piece> GetEnemyPieces(Piece piece)
        {
            return _activePieces
                .Where(p => p.Color != piece.Color)
                .ToList();
        }

    }
}
