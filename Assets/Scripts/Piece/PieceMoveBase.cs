using System;

/// <summary> マス探索の基底クラス
///           「どの方向に」「何マス進めるか」を返す </summary>
public abstract class PieceMoveBase
{
    private GameSystemData _systemData = new();

    public GameSystemData SystemData => _systemData;

    /// <summary> 探索用の基底クラス </summary>
    public abstract int SearchSquare(int x, int z);

    /// <summary> 探索用のループ
    ///            (複数回のループでコードが長くなるのを避けるため) </summary>
    public abstract int SearchLoop(Func<bool> func, Action action, Action finishedAction);
}