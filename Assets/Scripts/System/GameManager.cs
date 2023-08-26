using Constants;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private bool _isPause = false;

    private float _timer = 0f;
    private Turn _currentTurn = Turn.White;
    private GameSystemData _systemData = new();

    public Turn CurrentTurn => _currentTurn;
    public GameSystemData SystemData => _systemData;
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else { Destroy(gameObject); }
    }

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
