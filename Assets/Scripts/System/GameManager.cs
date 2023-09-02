using Constants;
using ModelLogic;
using System;
using UnityEngine;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    [Tooltip("持ち時間（min）")]
    [SerializeField]
    private int _allottedTime = 10;
    [SerializeField]
    private bool _isPause = false;

    private float _timer = 0f;
    private Turn _currentTurn = Turn.White;

    private const Turn _playerColor = Turn.White;
    private const Turn _enemyColor = Turn.Black;

    public PieceActionConfirmation PieceAction { get; private set; } = new();

    protected override bool DontDestroyOnLoad => true;

    protected override void Awake()
    {
        base.Awake();
        _timer = _allottedTime * 60f;
    }

    private void Update()
    {
        if (_isPause) { return; }

        TimerCount();
    }

    private void TimerCount()
    {
        //Playerのターンでなければ、何もしない
        if (_currentTurn != _playerColor) { return; }

        _timer -= Time.deltaTime;
        if (_timer <= 0f)
        {
            _isPause = true;

            //タイムアップ（仮でシーンのリロード）
            Fade.Instance.RegisterFadeOutEvent(
                new Action[] { () => SceneLoader.LoadToScene(SceneNames.InGame) });
            Fade.Instance.StartFadeOut();
        }
    }

    /// <summary> ターンの切り替え </summary>
    public void ChangeTurn()
    {
        _currentTurn
            = _currentTurn == _playerColor ? _enemyColor : _playerColor;
    }
}
