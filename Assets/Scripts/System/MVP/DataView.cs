using Constants;
using GameData;
using UnityEngine;

/// <summary> ゲームデータを画面に反映するクラス </summary>
public class DataView : MonoBehaviour
{
    #region 駒のPrefab一覧
    [SerializeField]
    private GameObject _gameBoard = default;
    [SerializeField]
    private GameObject _pawnWhite = default;
    [SerializeField]
    private GameObject _pawnBlack = default;
    [SerializeField]
    private GameObject _knightWhite = default;
    [SerializeField]
    private GameObject _knightBlack = default;
    [SerializeField]
    private GameObject _bishopWhite = default;
    [SerializeField]
    private GameObject _bishopBlack = default;
    [SerializeField]
    private GameObject _rookWhite = default;
    [SerializeField]
    private GameObject _rookBlack = default;
    [SerializeField]
    private GameObject _queenWhite = default;
    [SerializeField]
    private GameObject _queenBlack = default;
    [SerializeField]
    private GameObject _kingWhite = default;
    [SerializeField]
    private GameObject _kingBlack = default;
    #endregion

    private Transform _piecesParent = default;

    private void Start()
    {
        InitializeBoardSetting();
    }

    private void InitializeBoardSetting()
    {
        var board = Instantiate(_gameBoard);
        _piecesParent = board.transform;

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
        GameObject piece = pieceNum switch
        {
            1 => Instantiate(_pawnWhite),
            2 => Instantiate(_knightWhite),
            3 => Instantiate(_bishopWhite),
            4 => Instantiate(_rookWhite),
            5 => Instantiate(_queenWhite),
            6 => Instantiate(_kingWhite),
            -1 => Instantiate(_pawnBlack),
            -2 => Instantiate(_knightBlack),
            -3 => Instantiate(_bishopBlack),
            -4 => Instantiate(_rookBlack),
            -5 => Instantiate(_queenBlack),
            -6 => Instantiate(_kingBlack),
            _ => null
        };

        //マスに駒がなければ処理終了
        if (!piece) { return; }

        piece.transform.position = pos;
        piece.transform.SetParent(_piecesParent);
    }

    /// <summary> 盤面の最新状態をゲーム画面に描画 </summary>
    public void DisplayBoard(CellData[,] cellData) { }
}
