public class GameSystemData
{
    private int[,] _board = default;

    public int this[int row, int column]
    {
        get => _board[row, column];
        set => _board[row, column] = value;
    }
}
