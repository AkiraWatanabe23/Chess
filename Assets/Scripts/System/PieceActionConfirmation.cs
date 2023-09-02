using Constants;

namespace ModelLogic
{
    /// <summary> 駒の移動範囲の判定を行うクラス </summary>
    public class PieceActionConfirmation
    {
        private int[,] _board = default;

        public int this[int row, int column] //インデクサ
        {
            get => _board[row, column];
            set => _board[row, column] = value;
        }

        /// <summary> 指定したマスが空いているかの判定を行う </summary>
        public bool TryGetCell(int row, int column)
        {
            if (0 <= row && row < Consts.BoardSize &&
                0 <= column && column < Consts.BoardSize &&
                _board[row, column] == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary> 指定方向に何マス進めるかを調べる（左） </summary>
        public int TryMoveLeft(int row, int column)
        {
            return GetMovableLength(row, column, SearchDirection.None, SearchDirection.Decrement);
        }

        /// <summary> 指定方向に何マス進めるかを調べる（左上） </summary>
        public int TryMoveUpperLeft(int row, int column)
        {
            return GetMovableLength(row, column, SearchDirection.Decrement, SearchDirection.Decrement);
        }

        /// <summary> 指定方向に何マス進めるかを調べる（上） </summary>
        public int TryMoveUp(int row, int column)
        {
            return GetMovableLength(row, column, SearchDirection.Decrement, SearchDirection.None);
        }

        /// <summary> 指定方向に何マス進めるかを調べる（右上） </summary>
        public int TryMoveUpperRight(int row, int column)
        {
            return GetMovableLength(row, column, SearchDirection.Decrement, SearchDirection.Increment);
        }

        /// <summary> 指定方向に何マス進めるかを調べる（右） </summary>
        public int TryMoveRight(int row, int column)
        {
            return GetMovableLength(row, column, SearchDirection.None, SearchDirection.Increment);
        }

        /// <summary> 指定方向に何マス進めるかを調べる（右下） </summary>
        public int TryMoveLowerRight(int row, int column)
        {
            return GetMovableLength(row, column, SearchDirection.Increment, SearchDirection.Increment);
        }

        /// <summary> 指定方向に何マス進めるかを調べる（下） </summary>
        public int TryMoveDown(int row, int column)
        {
            return GetMovableLength(row, column, SearchDirection.Increment, SearchDirection.None);
        }

        /// <summary> 指定方向に何マス進めるかを調べる（左下） </summary>
        public int TryMoveLowerLeft(int row, int column)
        {
            return GetMovableLength(row, column, SearchDirection.Increment, SearchDirection.Decrement);
        }

        /// <summary> 各方向の進行マスを調べる基底関数 </summary>
        private int GetMovableLength(int row, int column, SearchDirection rowDir, SearchDirection columnDir)
        {
            //指定された方向に何マス進めるか表現する値
            int count = 0;

            // 方向を表現する値を 0,1,-1 にコンバージョン
            rowDir = rowDir == SearchDirection.None ?
                SearchDirection.None : (int)rowDir > 0 ? SearchDirection.Increment : SearchDirection.Decrement;
            columnDir = columnDir == SearchDirection.None ?
                SearchDirection.None : (int)columnDir > 0 ? SearchDirection.Increment : SearchDirection.Decrement;

            // 探索開始位置を取得
            row += (int)rowDir;
            column += (int)columnDir;

            for (; TryGetCell(row, column); Increment(ref row, ref column))
            {
                count++;
            }

            return count;

            void Increment(ref int x, ref int y)
            {
                x += (int)rowDir;
                y += (int)columnDir;
            }
        }
    }

    public enum SearchDirection
    {
        None = 0,
        Increment = 1,
        Decrement = -1,
    }
}
