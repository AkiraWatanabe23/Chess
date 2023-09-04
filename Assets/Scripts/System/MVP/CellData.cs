using Constants;

namespace GameData
{
    public class CellData
    {
        //以下駒のデータ
        public PieceType PieceType { get; private set; }
        public IPiece Movement { get; private set; }
        //以下セルのインデックス
        public int Row { get; private set; }
        public int Column { get; private set; }
        //以下探索時に使用するフラグ
        public bool IsSelected { get; private set; }
        public bool IsMovable { get; private set; }

        /// <summary> データの更新 </summary>
        public void CellDataUpdate(PieceType pieceType, IPiece piece, int row, int column)
        {
            PieceType = pieceType;
            Movement = piece;
            Row = row;
            Column = column;
        }

        /// <summary> セルにいる駒の情報を更新 </summary>
        public void CellPieceDataUpdate(PieceType pieceType, IPiece piece)
        {
            PieceType = pieceType;
            Movement = piece;
        }

        /// <summary> セルの選択状態の切り替え </summary>
        public void CellSelected(bool selected)
        {
            IsSelected = selected;
        }

        /// <summary> セルの移動可能フラグの切り替え </summary>
        public void CellMovable(bool movable)
        {
            IsMovable = movable;
        }
    }
}
