using UnityEngine;

public class DataPresenter : MonoBehaviour
{
    [SerializeField]
    private DataModel _dataModel = default;
    [SerializeField]
    private DataView _dataView = default;

    private void Start()
    {
        if (!_dataModel) { return; }

        _dataModel.DataChanged += OnDataChanged;
    }

    /// <summary> 駒を選択する </summary>
    public void PieceSelect()
    {
        //modelのlogic内処理を実行
        _dataModel.DataInput();
    }

    /// <summary> 駒の移動先を選択する </summary>
    public void MovePosSetting()
    {
        //modelのlogic内処理を実行
        _dataModel.DataUpdate();
    }

    private void OnDataChanged()
    {
        //viewの描画処理
        _dataView.DisplayBoard();
    }

    private void OnDestroy()
    {
        _dataModel.DataChanged -= OnDataChanged;
    }
}
