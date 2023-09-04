using Constants;

namespace GameData
{
    /// <summary> 盤面のデータ </summary>
    public class BoardData
    {
        private PieceDatas _pieceDatas = new();
        private CellData[,] _boardData = default;

        /// <summary> 駒選択時に選ばれたセル </summary>
        private CellData _selectedCell = default;

        public PieceDatas PieceDatas => _pieceDatas;
        public CellData[,] Board => _boardData;

        /// <summary> 盤面データの初期化処理 </summary>
        public void Init()
        {
            _boardData = new CellData[Consts.BoardSize, Consts.BoardSize];
            for (int row = 0; row < Consts.BoardSize; row++)
            {
                for (int column = 0; column < Consts.BoardSize; column++)
                {
                    var piece = GetPieceType(row, column);
                    var movement = GetMovementInstance(piece);

                    _boardData[row, column].CellDataUpdate(piece, movement, row, column);
                }
            }
        }

        /// <summary> ターンが切り替わった時に盤面の選択状態等をリセットする </summary>
        private void EnterNewTurn()
        {
            foreach (var cell in _boardData)
            {
                cell.CellSelected(false);
                cell.CellMovable(false);
            }
        }

        private PieceType GetPieceType(int row, int column)
        {
            return Consts.InitialBoard[row, column] switch
            {
                0  => PieceType.None,
                1  => PieceType.Pawn,
                -1 => PieceType.Pawn,
                2  => PieceType.Knight,
                -2 => PieceType.Knight,
                3  => PieceType.Bishop,
                -3 => PieceType.Bishop,
                4  => PieceType.Rook,
                -4 => PieceType.Rook,
                5  => PieceType.Queen,
                -5 => PieceType.Queen,
                6  => PieceType.King,
                -6 => PieceType.King,
            };
        }

        private IPiece GetMovementInstance(PieceType piece)
        {
            return piece switch
            {
                PieceType.Pawn => _pieceDatas.Pawn,
                PieceType.Knight => _pieceDatas.Knight,
                PieceType.Bishop => _pieceDatas.Bishop,
                PieceType.Rook => _pieceDatas.Rook,
                PieceType.Queen => _pieceDatas.Queen,
                PieceType.King => _pieceDatas.King,
                _ => null
            };
        }
    }

    public class PieceDatas
    {
        public IPiece Pawn { get; private set; } = new Pawn();
        public IPiece Knight { get; private set; } = new Knight();
        public IPiece Bishop { get; private set; } = new Bishop();
        public IPiece Rook { get; private set; } = new Rook();
        public IPiece Queen { get; private set; } = new Queen();
        public IPiece King { get; private set; } = new King();
    }
}
