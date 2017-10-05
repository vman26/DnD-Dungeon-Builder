using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Dungeon_Builder
{
    static class Mouse
    {
        static public Point Calculate2DGridPosition(Size pictureboxSize, Size tileCount, Point mousePosition)
        {
            int xPixelsPerTile = pictureboxSize.Width / tileCount.Width;
            int yPixelsPerTile = pictureboxSize.Height / tileCount.Height;
            int tileX = (mousePosition.X / xPixelsPerTile);
            int tileY = (mousePosition.Y / yPixelsPerTile);

            return new Point(tileX, tileY);
        }
    }
}
