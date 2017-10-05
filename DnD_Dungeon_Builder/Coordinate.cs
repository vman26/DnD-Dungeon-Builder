using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Dungeon_Builder
{
    static class Coordinate
    {
        static public int IsoToScreenX(int localX, int localY, int isoX, int isoW)
        {
            return isoX + (localX - localY) * isoW;
        }
        static public int IsoToScreenY(int localX, int localY, int isoY, int isoH)
        {
            return isoY + (localX + localY) * isoH;
        }
        //static public int ScreenToIsoX(globalX, globalY)
        //{
        //    return ((globalX - IsoX) / IsoW + (globalY - IsoY) / IsoH) / 2;
        //}
        //static public int ScreenToIsoY(globalX, globalY)
        //{
        //    return ((globalY - IsoY) / IsoH - (globalX - IsoX) / IsoW) / 2;
        //}
    }
}
