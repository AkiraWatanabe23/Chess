using Constants;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Range(1f, 60f)]
    [Tooltip("1手あたりの持ち時間")]
    private float _allottedTime = 1f;
    [SerializeField]
    private bool _isPause = false;

    private float _timer = 0f;
    private Turn _currentTurn = Turn.White;
    private GameSystemData _systemData = new();

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

    private void Start()
    {
        _timer = _allottedTime;
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

        _timer = _allottedTime;
    }
}
