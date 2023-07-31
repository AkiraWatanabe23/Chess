using System;

public interface IPiece
{
    /// <summary> どの方向に進めるか </summary>
    public int SearchSquare(int x, int z);

    /// <summary> 探索用のループ（何マス進めるか） </summary>
    public int SearchLoop(Func<bool> func, Action action, Action finishedAction);
}
