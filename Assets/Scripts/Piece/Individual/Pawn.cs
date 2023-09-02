using System;
using ModelLogic;

public class Pawn : IPiece
{
    private PieceActionConfirmation _pieceAction = default;

    public void Init(PieceActionConfirmation data) { _pieceAction = data; }

    public int SearchSquare(int x, int z)
    {
        throw new NotImplementedException();
    }
}
