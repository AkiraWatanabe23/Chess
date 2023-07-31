using Constants;
using System;

public class Bishop : IPiece
{
    private GameSystemData _systemData = new();

    public int SearchSquare(int x, int z)
    {
        int movableDir = 0;

        if (_systemData.TryGetCell(x + 1, z + 1)) movableDir += Consts.UpperRight;
        if (_systemData.TryGetCell(x - 1, z + 1)) movableDir += Consts.UpperLeft;
        if (_systemData.TryGetCell(x + 1, z - 1)) movableDir += Consts.LowerRight;
        if (_systemData.TryGetCell(x - 1, z - 1)) movableDir += Consts.LowerLeft;

        return movableDir;
    }

    public int SearchLoop(Func<bool> func, Action action, Action finishedAction)
    {
        throw new NotImplementedException();
    }
}
