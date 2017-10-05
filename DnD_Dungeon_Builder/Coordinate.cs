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
        static public int ScreenToIsoX(int globalX, int globalY, int isoX, int isoW, int isoY, int isoH)
        {
            return ((globalX - isoX) / isoW + (globalY - isoY) / isoH) / 2;
        }
        static public int ScreenToIsoY(int globalX, int globalY, int isoX, int isoW, int isoY, int isoH)
        {
            return ((globalY - isoY) / isoH - (globalX - isoX) / isoW) / 2;
        }
    }
}
