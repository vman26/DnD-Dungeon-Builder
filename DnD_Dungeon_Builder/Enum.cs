﻿using System;

namespace DnD_Dungeon_Builder
{
    public enum GridType
    {
        TwoDimensional = 0,
        Isometric = 1,
    }

    [Serializable]
    public enum Position
    {
        North = 0,
        East = 90,
        South = 180,
        West = 270,
        NotSet = -1
    }

    public enum Rotate
    {
        Clockwise = 90,
        CounterClockwise = -90
    }
}
