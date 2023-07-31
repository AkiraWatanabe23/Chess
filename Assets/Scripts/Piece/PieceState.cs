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
}
