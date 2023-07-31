using System;

[Serializable]
public class Diagonal : PieceMoveBase
{
    public override int SearchLoop(Func<bool> func, Action action, Action finishedAction)
    {
        throw new NotImplementedException();
    }

    public override int SearchSquare(int x, int z)
    {
        int movableDir = 0;

        return movableDir;
    }
}
