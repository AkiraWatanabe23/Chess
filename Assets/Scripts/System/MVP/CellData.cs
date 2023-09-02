using Constants;

namespace GameData
{
    public class CellData
    {
        public PieceType PieceType { get; private set; }
        public IPiece Movement { get; private set; }
        public int Row { get; private set; }
        public int Column { get; private set; }

        /// <summary> データの更新 </summary>
        public void DataUpdate(PieceType pieceType, IPiece piece, int row, int column)
        {
            PieceType = pieceType;
            Movement = piece;
            Row = row;
            Column = column;
        }
    }
}
