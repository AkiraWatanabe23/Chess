using Constants;
using System;

public class Rook : IPiece
{
    private GameSystemData _systemData = new();

    public int SearchSquare(int x, int z)
    {
        int movableDir = 0;

        if (_systemData.TryGetCell(x + 1, z + 0)) movableDir += Consts.Right;
        if (_systemData.TryGetCell(x - 1, z + 0)) movableDir += Consts.Left;
        if (_systemData.TryGetCell(x + 0, z + 1)) movableDir += Consts.Upper;
        if (_systemData.TryGetCell(x + 0, z - 1)) movableDir += Consts.Lower;

        return movableDir;
    }

    public int SearchLoop(Func<bool> func, Action action, Action finishedAction)
    {
        int count = 0;

        for (; func(); action())
        {
            //if (_board[_checkHol].Array[_checkVer] == 0)
            //{
            //    count++;
            //}
        }
        finishedAction();

        return count;
    }
}
