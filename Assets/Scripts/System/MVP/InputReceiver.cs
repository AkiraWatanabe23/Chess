using UnityEngine;

/// <summary> Playerの入力を受け付けるクラス </summary>
public class InputReceiver : MonoBehaviour
{
    private bool _isPieceSelected = false;
    private DataPresenter _presenter = default;

    public bool IsPieceSelected { get => _isPieceSelected; set => _isPieceSelected = value; }

    private void Start()
    {
        TryGetComponent(out _presenter);

#if UNITY_EDITOR
        if (!_presenter) { Debug.LogError("Presenterの取得に失敗しました"); }
#endif
    }

    private void Update()
    {
        Receiver();
    }

    /// <summary> Playerの入力待機 </summary>
    public void Receiver()
    {
        if (Input.GetKeyDown(KeyCode.Return) && !_isPieceSelected)
        {
            //動かす駒を決定
            _presenter?.PieceSelect();
        }
        else if (Input.GetKeyDown(KeyCode.Return) && _isPieceSelected)
        {
            //駒の移動先を決定
            _presenter?.MovePosSetting();
        }
    }
}
