namespace Chess
{
    public class Board
    {
        public const int BoardSize = 8;

        private static Dictionary<Coordinate, Cell> CellDict = new()
{
    { new Coordinate(1, 1), new Cell() },
    { new Coordinate(1, 2), new Cell() },
    { new Coordinate(1, 3), new Cell() },
    { new Coordinate(1, 4), new Cell() },
    { new Coordinate(1, 5), new Cell() },
    { new Coordinate(1, 6), new Cell() },
    { new Coordinate(1, 7), new Cell() },
    { new Coordinate(1, 8), new Cell() },

    { new Coordinate(2, 1), new Cell() },
    { new Coordinate(2, 2), new Cell() },
    { new Coordinate(2, 3), new Cell() },
    { new Coordinate(2, 4), new Cell() },
    { new Coordinate(2, 5), new Cell() },
    { new Coordinate(2, 6), new Cell() },
    { new Coordinate(2, 7), new Cell() },
    { new Coordinate(2, 8), new Cell() },

    { new Coordinate(3, 1), new Cell() },
    { new Coordinate(3, 2), new Cell() },
    { new Coordinate(3, 3), new Cell() },
    { new Coordinate(3, 4), new Cell() },
    { new Coordinate(3, 5), new Cell() },
    { new Coordinate(3, 6), new Cell() },
    { new Coordinate(3, 7), new Cell() },
    { new Coordinate(3, 8), new Cell() },

    { new Coordinate(4, 1), new Cell() },
    { new Coordinate(4, 2), new Cell() },
    { new Coordinate(4, 3), new Cell() },
    { new Coordinate(4, 4), new Cell() },
    { new Coordinate(4, 5), new Cell() },
    { new Coordinate(4, 6), new Cell() },
    { new Coordinate(4, 7), new Cell() },
    { new Coordinate(4, 8), new Cell() },

    { new Coordinate(5, 1), new Cell() },
    { new Coordinate(5, 2), new Cell() },
    { new Coordinate(5, 3), new Cell() },
    { new Coordinate(5, 4), new Cell() },
    { new Coordinate(5, 5), new Cell() },
    { new Coordinate(5, 6), new Cell() },
    { new Coordinate(5, 7), new Cell() },
    { new Coordinate(5, 8), new Cell() },

    { new Coordinate(6, 1), new Cell() },
    { new Coordinate(6, 2), new Cell() },
    { new Coordinate(6, 3), new Cell() },
    { new Coordinate(6, 4), new Cell() },
    { new Coordinate(6, 5), new Cell() },
    { new Coordinate(6, 6), new Cell() },
    { new Coordinate(6, 7), new Cell() },
    { new Coordinate(6, 8), new Cell() },

    { new Coordinate(7, 1), new Cell() },
    { new Coordinate(7, 2), new Cell() },
    { new Coordinate(7, 3), new Cell() },
    { new Coordinate(7, 4), new Cell() },
    { new Coordinate(7, 5), new Cell() },
    { new Coordinate(7, 6), new Cell() },
    { new Coordinate(7, 7), new Cell() },
    { new Coordinate(7, 8), new Cell() },

    { new Coordinate(8, 1), new Cell() },
    { new Coordinate(8, 2), new Cell() },
    { new Coordinate(8, 3), new Cell() },
    { new Coordinate(8, 4), new Cell() },
    { new Coordinate(8, 5), new Cell() },
    { new Coordinate(8, 6), new Cell() },
    { new Coordinate(8, 7), new Cell() },
    { new Coordinate(8, 8), new Cell() }
};

        public void setPiece(Coordinate inputCoordinate, Piece inputPiece)
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

        public Piece getPiece(Coordinate inputCoordinate)
        {
            if (IsValidPosition(inputCoordinate))
            {
                return CellDict[inputCoordinate].Piece;
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

        private void InitializeBoardPieces()
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
