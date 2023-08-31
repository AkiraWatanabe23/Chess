using Constants;
using UnityEngine;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    [SerializeField]
    private bool _isPause = false;

    private float _timer = 0f;
    private Turn _currentTurn = Turn.White;
    private Turn _playerColor = Turn.White;
    private Turn _enemyColor  = Turn.Black;
    private GameSystemData _systemData = new();

    public Turn CurrentTurn => _currentTurn;
    public Turn PlayerColor => _playerColor;
    public Turn EnemyColor => _enemyColor;
    public GameSystemData SystemData => _systemData;

    protected override bool DontDestroyOnLoad => true;

    private void Update()
    {
        if (_isPause) { return; }

        _timer -= Time.deltaTime;
        if (_timer <= 0f)
        {
            ChangeTurn();
        }
    }

    private void ChangeTurn()
    {
        _currentTurn
            = _currentTurn == Turn.White ? Turn.Black : Turn.White;
    }
}
