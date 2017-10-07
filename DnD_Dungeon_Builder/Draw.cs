using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Dungeon_Builder
{
   static class Draw
    {
        static public void DrawGridTiles(int xTiles, int yTiles, int tileSize, ref Bitmap bitmap, int selectedTileX = -1, int selectedTileY = -1)
        {
            bitmap = new Bitmap(tileSize * xTiles + 1, tileSize * yTiles + 1);
            Graphics g = Graphics.FromImage(bitmap);

            for (int Xi = 0; Xi < xTiles; Xi++)
            {
                for (var Yi = 0; Yi < yTiles; Yi++)
                {
                    // Draw tile outline
                    Pen pen = new Pen(Color.Black);

                    g.DrawRectangle(pen, Xi * tileSize, Yi * tileSize, tileSize, tileSize);
                }
            }

            if (selectedTileX >= 0 && selectedTileY >= 0)
            {
                Pen pen = new Pen(Color.Red);
                g.DrawRectangle(pen, selectedTileX * tileSize, selectedTileY * tileSize, tileSize, tileSize);
            }
            g.Dispose();
        }

        static public void DrawIsometricTiles(int xTiles, int yTiles, int tileSize, ref Bitmap bitmap, Color backgroudColor, int selectedTileX = -1, int selectedTileY = -1)
        {
            int bitmapOffset = 100;
            Size bitmapSize = new Size(tileSize * xTiles * 2 + bitmapOffset, tileSize * yTiles + bitmapOffset);
            
            if (yTiles - xTiles > 0) bitmapSize.Width += ((yTiles - xTiles) * tileSize * 2);
            if (xTiles - yTiles > 0) bitmapSize.Height += (int)Math.Floor((xTiles - yTiles) * tileSize * 0.5);
            
            bitmap = new Bitmap(bitmapSize.Width, bitmapSize.Height);
            Graphics g = Graphics.FromImage(bitmap);

            var IsoW = tileSize; // cell width
            var IsoH = tileSize / 2; // cell height
            var IsoX = bitmap.Width / 2;
            var IsoY = 0;

            g.Clear(backgroudColor);

            for (var y = 0; y < yTiles; y++)
            {
                for (var x = 0; x < xTiles; x++)
                {
                    var rx = Coordinate.IsoToScreenX(x, y, IsoX, IsoW);
                    var ry = Coordinate.IsoToScreenY(x, y, IsoY, IsoH);
                    
                    if (yTiles - xTiles < 0) rx = rx + ((yTiles - xTiles) * IsoW);
                    ry += bitmapOffset/2;

                    Pen pen = new Pen(Color.Black);

                    g.DrawLine(pen, rx, ry, rx - IsoW, ry + IsoH);
                    g.DrawLine(pen, rx - IsoW, ry + IsoH, rx, ry + IsoH * 2);
                    g.DrawLine(pen, rx, ry + IsoH * 2, rx + IsoW, ry + IsoH);
                    g.DrawLine(pen, rx + IsoW, ry + IsoH, rx, ry);
                }
            }

            if (selectedTileX >= 0 && selectedTileY >= 0)
            {
                var rx = Coordinate.IsoToScreenX(selectedTileX, selectedTileY, IsoX, IsoW);
                var ry = Coordinate.IsoToScreenY(selectedTileX, selectedTileY, IsoY, IsoH);

                if (yTiles - xTiles < 0) rx = rx + ((yTiles - xTiles) * IsoW);
                ry += bitmapOffset / 2;

                Pen pen = new Pen(Color.Red);

                g.DrawLine(pen, rx, ry, rx - IsoW, ry + IsoH);
                g.DrawLine(pen, rx - IsoW, ry + IsoH, rx, ry + IsoH * 2);
                g.DrawLine(pen, rx, ry + IsoH * 2, rx + IsoW, ry + IsoH);
                g.DrawLine(pen, rx + IsoW, ry + IsoH, rx, ry);
            }
            
            g.Dispose();
        }

        static public void ClearDrawing(ref Bitmap bitmap)
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.Transparent);
            g.Dispose();
        }
    }
}
