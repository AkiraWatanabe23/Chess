﻿using System;

public class Knight : IPiece
{
    private GameSystemData _systemData = default;

    public void Init(GameSystemData data) { _systemData = data; }

    public int SearchSquare(int x, int z)
    {
        throw new NotImplementedException();
    }
}
