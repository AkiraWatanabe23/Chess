using System.Threading.Tasks;
using UnityEngine;

/// <summary> Playerの入力を受け付けるクラス </summary>
public class InputReceiver : MonoBehaviour
{
    /// <summary> 駒が選択状態にあるか </summary>
    private bool _isPieceSelected = false;
    private DataPresenter _presenter = default;

    public bool IsPieceSelected { get => _isPieceSelected; set => _isPieceSelected = value; }

    private async void Start()
    {
        TryGetComponent(out _presenter);
#if UNITY_EDITOR
        if (!_presenter) { Debug.LogError("Presenterの取得に失敗しました"); }
#endif

        await ReceiveAsync();
    }

    /// <summary> Playerの入力時の処理 </summary>
    private void InputReceive()
    {
#if UNITY_EDITOR
        Debug.Log("get input");
        return;
#endif

        //動かす駒を決定
        if (!_isPieceSelected) { _presenter?.PieceSelect(); }
        //駒の移動先を決定
        else if (_isPieceSelected) { _presenter?.MovePosSetting(); }
    }

    /// <summary> Playerの入力待機 </summary>
    private async Task ReceiveAsync()
    {
#if UNITY_EDITOR
        Debug.Log("input waiting...");
#endif

        bool isInput = false;
        while (!isInput)
        {
            isInput = Input.GetKeyDown(KeyCode.Return);
            await Task.Yield();
        }
        InputReceive();
        //再度入力待ちをする
        await ReceiveAsync();
    }
}
