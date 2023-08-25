using Constants;

public class Rook : IPiece
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

        return movableDir;
    }
}
