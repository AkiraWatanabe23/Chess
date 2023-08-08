using System.Collections.Generic;

namespace Constants
{
    public class Consts
    {
        public static int[,] InitialBoard = new int[,]
        {
            { -4, -2, -3, -5, -6, -3, -2, -4 },
            { -1, -1, -1, -1, -1, -1, -1, -1 },
            {  0,  0,  0,  0,  0,  0,  0,  0 },
            {  0,  0,  0,  0,  0,  0,  0,  0 },
            {  0,  0,  0,  0,  0,  0,  0,  0 },
            {  0,  0,  0,  0,  0,  0,  0,  0 },
            {  1,  1,  1,  1,  1,  1,  1,  1 },
            {  4,  2,  3,  5,  6,  3,  2,  4 },
        };

        public const int BoardSize = 8;

        public const int Left = 1;
        public const int UpperLeft = 2;
        public const int Upper = 4;
        public const int UpperRight = 8;
        public const int Right = 16;
        public const int LowerRight = 32;
        public const int Lower = 64;
        public const int LowerLeft = 128;

        public static readonly Dictionary<SceneNames, string> Scenes = new()
        {
            [SceneNames.TitleScene] = "Title",
            [SceneNames.InGameScene] = "InGame",
            [SceneNames.ResultScene] = "Result",
        };
    }

    public enum SceneNames
    {
        TitleScene,
        InGameScene,
        ResultScene,
    }

    public enum PieceType
    {
        Pawn = 1,
        Knight,
        Bishop,
        Rook,
        Queen,
        King,
    }

    public enum Turn
    {
        White = 1,
        Black = -1
    }
}
