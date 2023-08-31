using UnityEngine;

/// <summary> Playerの入力を受け付けるクラス </summary>
public class InputReceiver
{
    /// <summary> 持ち時間（min） </summary>
    private int _allottedTime = 10;

    private float _timer = 0f;
    private bool _isPieceSelected = false;

    public void Init(int allotted)
    {
        _allottedTime = allotted;
        _timer = _allottedTime * 60f;
    }

    public void Update()
    {
        TimerCount();

        if (Input.GetKeyDown(KeyCode.Return) && !_isPieceSelected)
        {
            //動かす駒を決定
        }
        else if (Input.GetKeyDown(KeyCode.Return) && _isPieceSelected)
        {
            //駒の移動先を決定
        }
    }

    private void TimerCount()
    {
        if (GameManager.Instance.CurrentTurn != GameManager.Instance.PlayerColor) { return; }

        _timer -= Time.deltaTime;
        if (_timer <= 0f)
        {
            //タイムアップ
        }
    }
}
