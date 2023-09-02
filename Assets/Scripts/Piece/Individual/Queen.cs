using Constants;
using ModelLogic;

public class Queen : IPiece
{
    private PieceActionConfirmation _pieceAction = default;

    public void Init(PieceActionConfirmation data) { _pieceAction = data; }

    public int SearchSquare(int row, int column)
    {
        int movableDir = 0;

        if (_pieceAction.TryMoveRight(row + 0, column + 1) > 0)      { movableDir += Consts.Right; }
        if (_pieceAction.TryMoveLeft(row + 0, column - 1) > 0)       { movableDir += Consts.Left; }
        if (_pieceAction.TryMoveUp(row - 1, column + 0) > 0)         { movableDir += Consts.Upper; }
        if (_pieceAction.TryMoveDown(row + 1, column + 0) > 0)       { movableDir += Consts.Lower; }
        if (_pieceAction.TryMoveUpperRight(row - 1, column + 1) > 0) { movableDir += Consts.UpperRight; }
        if (_pieceAction.TryMoveUpperLeft(row - 1, column - 1) > 0)  { movableDir += Consts.UpperLeft; }
        if (_pieceAction.TryMoveLowerRight(row + 1, column + 1) > 0) { movableDir += Consts.LowerRight; }
        if (_pieceAction.TryMoveLowerLeft(row + 1, column - 1) > 0)  { movableDir += Consts.LowerLeft; }

        return movableDir;
    }
}
