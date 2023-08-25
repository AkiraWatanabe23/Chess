using UnityEngine;

/// <summary> Playerの入力を受け付けるクラス </summary>
public class InputReceiver : MonoBehaviour
{
    private bool _isPieceSelected = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && !_isPieceSelected)
        {
            //動かす駒を決定
        }
        else if (Input.GetKeyDown(KeyCode.Return) && _isPieceSelected)
        {
            //駒の移動先を決定
        }
    }
}
