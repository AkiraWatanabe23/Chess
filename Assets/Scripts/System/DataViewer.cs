using Constants;
using UnityEngine;

public class DataViewer : MonoBehaviour
{
    #region 駒のPrefab一覧
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
        Init();
    }

    public void Init()
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
        GameObject piece = null;

        switch (pieceNum)
        {
            case 1:
                piece = Instantiate(_pawnWhitePrefab);
                break;
            case 2:
                piece = Instantiate(_knightWhitePrefab);
                break;
            case 3:
                piece = Instantiate(_bishopWhitePrefab);
                break;
            case 4:
                piece = Instantiate(_rookWhitePrefab);
                break;
            case 5:
                piece = Instantiate(_queenWhitePrefab);
                break;
            case 6:
                piece = Instantiate(_kingWhitePrefab);
                break;
            case -1:
                piece = Instantiate(_pawnBlackPrefab);
                break;
            case -2:
                piece = Instantiate(_knightBlackPrefab);
                break;
            case -3:
                piece = Instantiate(_bishopBlackPrefab);
                break;
            case -4:
                piece = Instantiate(_rookBlackPrefab);
                break;
            case -5:
                piece = Instantiate(_queenBlackPrefab);
                break;
            case -6:
                piece = Instantiate(_kingBlackPrefab);
                break;
        }
        piece.transform.position = pos;
    }

    public void DisplayBoard()
    {

    }
}
