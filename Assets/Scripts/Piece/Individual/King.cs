using Constants;
using ModelLogic;

public class King : IPiece
{
    private PieceActionConfirmation _pieceAction = default;

    public void Init(PieceActionConfirmation data) { _pieceAction = data; }

    public int SearchSquare(int x, int z)
    {
        int movableDir = 0;

        if (_pieceAction.TryGetCell(x + 1, z + 0)) { movableDir += Consts.Right; }
        if (_pieceAction.TryGetCell(x - 1, z + 0)) { movableDir += Consts.Left; }
        if (_pieceAction.TryGetCell(x + 0, z + 1)) { movableDir += Consts.Upper; }
        if (_pieceAction.TryGetCell(x + 0, z - 1)) { movableDir += Consts.Lower; }
        if (_pieceAction.TryGetCell(x + 1, z + 1)) { movableDir += Consts.UpperRight; }
        if (_pieceAction.TryGetCell(x - 1, z + 1)) { movableDir += Consts.UpperLeft; }
        if (_pieceAction.TryGetCell(x + 1, z - 1)) { movableDir += Consts.LowerRight; }
        if (_pieceAction.TryGetCell(x - 1, z - 1)) { movableDir += Consts.LowerLeft; }

        return movableDir;
    }
}
