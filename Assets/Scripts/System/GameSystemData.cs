using Constants;

public class GameSystemData
{
    private int _row = 0;
    private int _column = 0;
    private int[,] _board = default;

    public int this[int row, int column] //インデクサ
    {
        get => _board[row, column];
        set => _board[row, column] = value;
    }

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

    public bool TryMoveLeft()
    {
        for (int column = _column - 1; column >= 0; column--)
        {
            if (TryGetCell(_row, column)) { return true; }
        }
        return false;
    }

    public bool TryMoveRight()
    {
        for (int column = _column + 1; column < Consts.BoardSize; column++)
        {
            if (TryGetCell(_row, column)) { return true; }
        }
        return false;
    }

    public bool TryMoveUp()
    {
        for (int row = _row - 1; row >= 0; row--)
        {
            if (TryGetCell(row, _column)) { return true; }
        }
        return false;
    }

    public bool TryMoveDown()
    {
        for (int row = _row + 1; row < Consts.BoardSize; row++)
        {
            if (TryGetCell(row, _column)) { return true; }
        }
        return false;
    }

}
