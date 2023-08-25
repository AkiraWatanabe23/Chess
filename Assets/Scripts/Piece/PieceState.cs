using Constants;
using UnityEngine;

public class PieceState : MonoBehaviour
{
    [SerializeField]
    private PieceType _pieceType = PieceType.Pawn;

    private IPiece _movement = default;
    private int _indexRow = 0;
    private int _indexColumn = 0;

    public int IndexRow => _indexRow;
    public int IndexColumn => _indexColumn;

    private void Start()
    {
        _movement = _pieceType switch
        {
            PieceType.Pawn => new Pawn(),
            PieceType.Knight => new Knight(),
            PieceType.Bishop => new Bishop(),
            PieceType.Rook => new Rook(),
            PieceType.Queen => new Queen(),
            PieceType.King => new King(),
            _ => null
        };
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            //駒を選ぶ -> マスを選ぶ
            var dir = _movement.SearchSquare(_indexRow, _indexColumn);
        }
    }

    private void MoveCheck(int dir)
    {
        int row = _indexRow;
        int column = _indexColumn;

        //以下探索ループ処理
        if ((dir | Consts.Left) == Consts.Left)
        {
            var left = _movement.SearchLoop(
                () => 0 <= column && GameManager.Instance.SystemData[row, column] == 0,
                () => { column--; },
                () => { column = _indexColumn; });
        }
        if ((dir | Consts.UpperLeft) == Consts.UpperLeft)
        {
            var upperLeft = _movement.SearchLoop(
                () => 0 <= row && 0 <= column && GameManager.Instance.SystemData[row, column] == 0,
                () => { row--; column--; },
                () => { row = _indexRow; column = _indexColumn; });
        }
        if ((dir | Consts.Upper) == Consts.Upper)
        {
            var upper = _movement.SearchLoop(
                () => 0 <= row && GameManager.Instance.SystemData[row, column] == 0,
                () => { row--; },
                () => { row = _indexRow; });
        }
        if ((dir | Consts.UpperRight) == Consts.UpperRight)
        {
            var upperRight = _movement.SearchLoop(
                () => 0 <= row && column < Consts.BoardSize && GameManager.Instance.SystemData[row, column] == 0,
                () => { row--; column++; },
                () => { row = _indexRow; column = _indexColumn; });
        }
        if ((dir | Consts.Right) == Consts.Right)
        {
            var right = _movement.SearchLoop(
                () => column < Consts.BoardSize && GameManager.Instance.SystemData[row, column] == 0,
                () => { column++; },
                () => { column = _indexColumn; });
        }
        if ((dir | Consts.LowerRight) == Consts.LowerRight)
        {
            var lowerRight = _movement.SearchLoop(
                () => row < Consts.BoardSize && column < Consts.BoardSize && GameManager.Instance.SystemData[row, column] == 0,
                () => { row++; column++; },
                () => { row = _indexRow; column = _indexColumn; });
        }
        if ((dir | Consts.Lower) == Consts.Lower)
        {
            var lower = _movement.SearchLoop(
                () => row < Consts.BoardSize && GameManager.Instance.SystemData[row, column] == 0,
                () => { row++; },
                () => { row = _indexRow; });
        }
        if ((dir | Consts.LowerLeft) == Consts.LowerLeft)
        {
            var lowerLeft = _movement.SearchLoop(
                () => row < Consts.BoardSize && 0 <= column && GameManager.Instance.SystemData[row, column] == 0,
                () => { row++; column--; },
                () => { row = _indexRow; column = _indexColumn; });
        }
    }
}
