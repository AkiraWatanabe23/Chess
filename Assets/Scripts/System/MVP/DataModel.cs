using GameData;
using ModelLogic;
using System;
using UnityEngine;

public class DataModel : MonoBehaviour
{
    private readonly PieceLogic _logic = new();
    private readonly BoardData _boardData = new();

    public BoardData BoardData => _boardData;

    public event Action DataChanged = default;

    /// <summary> Playerからの入力が入ったときに実行される </summary>
    public void DataInput()
    {
        //駒の選択

        //どのマスが選ばれたかを取得
        //そのマスに自分が動かせる駒があるか
        //駒があった場合、移動範囲の探索を行う

        //違ったら（相手の駒、空のマス）
        //何もしない
    }

    /// <summary> データの更新が行われたときに実行される </summary>
    public void DataUpdate()
    {
        //駒を移動させる入力だった場合
        //移動させ、盤面のデータを更新する

        //別の駒の選択が行われた場合
        //元々選択状態だった駒を解除し、再設定を行う

        //それ以外（空のマス選んだとか）
        //何もしない

        //UIの更新処理
        DataChanged?.Invoke();
    }
}
