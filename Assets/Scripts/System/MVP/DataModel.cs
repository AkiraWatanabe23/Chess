using ModelLogic;
using System;
using UnityEngine;

public class DataModel : MonoBehaviour
{
    private readonly PieceLogic _logic = new();

    public event Action DataChanged = default;

    /// <summary> Playerからの入力が入ったときに実行される </summary>
    public void DataInput()
    {

    }

    /// <summary> データの更新が行われたときに実行される </summary>
    public void DataUpdate()
    {

    }

    /// <summary> データの更新が行われたときに実行される </summary>
    private void DataChange()
    {
        DataChanged?.Invoke();
    }
}
