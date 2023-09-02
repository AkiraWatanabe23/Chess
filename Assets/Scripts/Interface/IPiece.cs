using System;

/// <summary> 各駒の探索方向を調べる関数を持つインターフェース </summary>
public interface IPiece
{
    /// <summary> どの方向に何マス進めるか </summary>
    /// <param name="row"> 行 </param>
    /// <param name="column"> 列 </param>
    public int SearchSquare(int row, int column);

    /// <summary> 探索用のループ </summary>
    /// <param name="func"> ループを続ける条件式 </param>
    /// <param name="action"> ループ内で実行される処理 </param>
    /// <param name="finishedAction"> ループ終了後に実行される処理 </param>
    /// <returns> 何マス進めるか </returns>
    public int SearchLoop(Func<bool> func, Action action = null, Action finishedAction = null)
    {
        int count = 0;

        while (func())
        {
            count++;
            action();
        }
        finishedAction();

        return count;
    }
}
