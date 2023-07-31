using Constants;
using UnityEngine;

public class PieceState : MonoBehaviour
{
    [SerializeField]
    private PieceType _pieceType = PieceType.Pawn;

    private IPiece _movement = default;

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
}
