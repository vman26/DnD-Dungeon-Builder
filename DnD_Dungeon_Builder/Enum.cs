using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Dungeon_Builder
{
    enum GridType
    {
        TwoDimensional = 0,
        Isometric = 1,
    }
    
    public enum Position
    {
        North = 0,
        East = 90,
        South = 180,
        West = 270,
        NotSet = -1
    }
}
