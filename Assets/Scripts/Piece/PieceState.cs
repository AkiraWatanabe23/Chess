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
            var dir = _movement.SearchSquare(_indexRow, _indexColumn);
        }
    }

    private void MoveCheck(int dir)
    {
        int row = _indexRow;
        int column = _indexColumn;

        //以下処理後述
        if ((dir | Consts.Left) == Consts.Left)
        {
            //条件は見直す
            var left = _movement.SearchLoop(() => 0 <= row, () => { row--; }, () => { row = _indexRow; });
        }
        if ((dir | Consts.UpperLeft) == Consts.UpperLeft) { }
        if ((dir | Consts.Upper) == Consts.Upper) { }
        if ((dir | Consts.UpperRight) == Consts.UpperRight) { }
        if ((dir | Consts.Right) == Consts.Right) { }
        if ((dir | Consts.LowerRight) == Consts.LowerRight) { }
        if ((dir | Consts.Lower) == Consts.Lower) { }
        if ((dir | Consts.LowerLeft) == Consts.LowerLeft) { }
    }
}
