using UnityEngine;

/// <summary> Playerの入力を受け付けるクラス </summary>
public class InputReceiver : MonoBehaviour
{
    [Tooltip("持ち時間（min）")]
    [SerializeField]
    private int _allottedTime = 10;

    private float _timer = 0f;
    private bool _isPieceSelected = false;

    private void Start()
    {
        _timer = _allottedTime * 60f;
    }

    private void Update()
    {
        if (GameManager.Instance.CurrentTurn == Constants.Turn.White) { _timer -= Time.deltaTime; }

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
