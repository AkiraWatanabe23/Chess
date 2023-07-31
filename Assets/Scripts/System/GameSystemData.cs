using Constants;

public class GameSystemData
{
    private int[,] _board = default;

    public int this[int row, int column]
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
}
