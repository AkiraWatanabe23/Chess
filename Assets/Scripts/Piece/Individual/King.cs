using Constants;

public class King : IPiece
{
    private GameSystemData _systemData = default;

    public void Init(GameSystemData data) { _systemData = data; }

    public int SearchSquare(int x, int z)
    {
        int movableDir = 0;

        if (_systemData.TryGetCell(x + 1, z + 0)) { movableDir += Consts.Right; }
        if (_systemData.TryGetCell(x - 1, z + 0)) { movableDir += Consts.Left; }
        if (_systemData.TryGetCell(x + 0, z + 1)) { movableDir += Consts.Upper; }
        if (_systemData.TryGetCell(x + 0, z - 1)) { movableDir += Consts.Lower; }
        if (_systemData.TryGetCell(x + 1, z + 1)) { movableDir += Consts.UpperRight; }
        if (_systemData.TryGetCell(x - 1, z + 1)) { movableDir += Consts.UpperLeft; }
        if (_systemData.TryGetCell(x + 1, z - 1)) { movableDir += Consts.LowerRight; }
        if (_systemData.TryGetCell(x - 1, z - 1)) { movableDir += Consts.LowerLeft; }

        return movableDir;
    }
}
