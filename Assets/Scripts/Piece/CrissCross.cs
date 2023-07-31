using Constants;
using System;

[Serializable]
public class CrissCross : PieceMoveBase
{
    public override int SearchLoop(Func<bool> func, Action action, Action finishedAction)
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

    public override int SearchSquare(int x, int z)
    {
        int movableDir = 0;

        if (SystemData.TryGetCell(x + 1, z)) movableDir += Consts.Right;
        if (SystemData.TryGetCell(x - 1, z)) movableDir += Consts.Left;
        if (SystemData.TryGetCell(x, z + 1)) movableDir += Consts.Upper;
        if (SystemData.TryGetCell(x, z - 1)) movableDir += Consts.Lower;

        return movableDir;
    }
}
