namespace Chess
{
    public class Board
    {
        public const int BoardSize = 8;

        private static Dictionary<Coordinate, Cell> CellDict = new();

        public static void InitCellDict()
        {
            for (int x = 1; x < BoardSize + 1; x++)
            {
                for (int y = 1; y < BoardSize + 1; y++)
                {
                    CellDict[new Coordinate(x, y)] = new Cell();
                }
            }
        }

        public void SetPiece(Coordinate inputCoordinate, Piece inputPiece)
        {
            if (IsValidPosition(inputCoordinate))
            {
                CellDict[inputCoordinate].PlacePiece(inputPiece);
            }
            else
            {
                throw new InvalidCoordinateException(inputCoordinate);
            }
        }

        public Piece ?GetPiece(Coordinate inputCoordinate)
        {
            if (IsValidPosition(inputCoordinate))
            {
                if (CellDict[inputCoordinate].Piece != null)
                {
                    return CellDict[inputCoordinate].Piece;
                }
                else
                {
                    throw new NoPieceFoundExeption(inputCoordinate);
                }
                
            }
            else
            {
                throw new InvalidCoordinateException(inputCoordinate);
            }
        }

        public Cell GetCell(Coordinate inputCoordinate)
        {
            if (IsValidPosition(inputCoordinate))
            {
                return CellDict[inputCoordinate];
            }
            else
            {
                throw new InvalidCoordinateException(inputCoordinate);
            }
        }

        public Board()
        {
            InitCellDict();


        }


        private void InitializeBoardPieces()
        {
            
        }

        private void InitializeBlackPieces()
        {

        }

        private void InitializeWhitePieces()
        {

        }

        private void InitializePawnRows()
        {

        }




        public bool IsValidPosition(Coordinate inputCoordinate)
        {
            if (CellDict.ContainsKey(inputCoordinate))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RemoveAllPieces()
        {
            foreach (var Key in CellDict.Keys)
            {
                CellDict[Key].RemovePiece();
            }
        }
    }
}
