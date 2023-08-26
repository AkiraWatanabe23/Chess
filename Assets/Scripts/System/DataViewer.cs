using Constants;
using UnityEngine;

public class DataViewer : MonoBehaviour
{
    #region 駒のPrefab一覧
    [SerializeField]
    private GameObject _gameBoardPrefab = default;
    [SerializeField]
    private GameObject _pawnWhitePrefab = default;
    [SerializeField]
    private GameObject _pawnBlackPrefab = default;
    [SerializeField]
    private GameObject _knightWhitePrefab = default;
    [SerializeField]
    private GameObject _knightBlackPrefab = default;
    [SerializeField]
    private GameObject _bishopWhitePrefab = default;
    [SerializeField]
    private GameObject _bishopBlackPrefab = default;
    [SerializeField]
    private GameObject _rookWhitePrefab = default;
    [SerializeField]
    private GameObject _rookBlackPrefab = default;
    [SerializeField]
    private GameObject _queenWhitePrefab = default;
    [SerializeField]
    private GameObject _queenBlackPrefab = default;
    [SerializeField]
    private GameObject _kingWhitePrefab = default;
    [SerializeField]
    private GameObject _kingBlackPrefab = default;
    #endregion

    private void Start()
    {
        InitializeBoardSetting();
    }

    private void InitializeBoardSetting()
    {
        for (int row = 0; row < Consts.BoardSize; row++)
        {
            for (int column = 0; column < Consts.BoardSize; column++)
            {
                PieceSetting(Consts.InitialBoard[row, column], new Vector3(row, 0f, column));
            }
        }
    }

    private void PieceSetting(int pieceNum, Vector3 pos)
    {
        Instantiate(_gameBoardPrefab);

        GameObject piece = pieceNum switch
        {
            1 => Instantiate(_pawnWhitePrefab),
            2 => Instantiate(_knightWhitePrefab),
            3 => Instantiate(_bishopWhitePrefab),
            4 => Instantiate(_rookWhitePrefab),
            5 => Instantiate(_queenWhitePrefab),
            6 => Instantiate(_kingWhitePrefab),
            -1 => Instantiate(_pawnBlackPrefab),
            -2 => Instantiate(_knightBlackPrefab),
            -3 => Instantiate(_bishopBlackPrefab),
            -4 => Instantiate(_rookBlackPrefab),
            -5 => Instantiate(_queenBlackPrefab),
            -6 => Instantiate(_kingBlackPrefab),
            _ => null
        };

        if (piece) { piece.transform.position = pos; }
    }

    public void DisplayBoard() { }
}
