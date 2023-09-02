using Constants;
using ModelLogic;

public class Rook : IPiece
{
    private PieceActionConfirmation _pieceAction = default;

    public void Init(PieceActionConfirmation data) { _pieceAction = data; }

    public int SearchSquare(int row, int column)
    {
        int movableDir = 0;

        if (_pieceAction.TryMoveRight(row + 0, column + 1) > 0) { movableDir += Consts.Right; }
        if (_pieceAction.TryMoveLeft(row + 0, column - 1) > 0)  { movableDir += Consts.Left; }
        if (_pieceAction.TryMoveUp(row - 1, column + 0) > 0)    { movableDir += Consts.Upper; }
        if (_pieceAction.TryMoveDown(row + 1, column + 0) > 0)  { movableDir += Consts.Lower; }

        return movableDir;
    }
}
