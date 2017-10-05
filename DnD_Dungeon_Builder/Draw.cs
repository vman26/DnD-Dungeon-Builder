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

        static public void DrawIsometricTiles(int xTiles, int yTiles, int tileSize, Point origin, ref Bitmap bitmap, int selectedTileX = -1, int selectedTileY = -1)
        {
            bitmap = new Bitmap(tileSize * xTiles + 1, tileSize * yTiles + 1);
            Graphics g = Graphics.FromImage(bitmap);

            var IsoW = tileSize; // cell width
            var IsoH = tileSize / 2; // cell height
            var IsoX = origin.X / 2;
            var IsoY = 20;

            for (var y = 0; y < yTiles; y++)
            {
                for (var x = 0; x < xTiles; x++)
                {
                    var rx = Coordinate.IsoToScreenX(x, y, IsoX, IsoW);
                    var ry = Coordinate.IsoToScreenY(x, y, IsoY, IsoH);

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

                Pen pen = new Pen(Color.Red);

                g.DrawLine(pen, rx, ry, rx - IsoW, ry + IsoH);
                g.DrawLine(pen, rx - IsoW, ry + IsoH, rx, ry + IsoH * 2);
                g.DrawLine(pen, rx, ry + IsoH * 2, rx + IsoW, ry + IsoH);
                g.DrawLine(pen, rx + IsoW, ry + IsoH, rx, ry);
            }




            //        int tileColumnOffset = tileSize;
            //int tileRowOffset = tileSize / 2;

            //for (var Xi = 0; Xi < xTiles; Xi++)
            //{
            //    for (var Yi = 0; Yi < yTiles; Yi++)
            //    {
            //        var offX = Xi * tileColumnOffset / 2 + Yi * tileColumnOffset / 2 + origin.X;
            //        var offY = Yi * tileRowOffset / 2 - Xi * tileRowOffset / 2 + origin.Y;

            //        Pen pen = new Pen(Color.Black);

            //        g.DrawLine(pen, offX, offY + tileRowOffset / 2, offX + tileColumnOffset / 2, offY);
            //        g.DrawLine(pen, offX + tileColumnOffset / 2, offY, offX + tileColumnOffset, offY + tileRowOffset / 2);
            //        g.DrawLine(pen, offX + tileColumnOffset, offY + tileRowOffset / 2, offX + tileColumnOffset / 2, offY + tileRowOffset);
            //        g.DrawLine(pen, offX + tileColumnOffset / 2, offY + tileRowOffset, offX, offY + tileRowOffset / 2);
            //    }
            //}

            //if (selectedTileX >= 0 && selectedTileY >= 0)
            //{
            //    var offX = selectedTileX * tileColumnOffset / 2 + selectedTileY * tileColumnOffset / 2 + origin.X;
            //    var offY = selectedTileY * tileRowOffset / 2 - selectedTileX * tileRowOffset / 2 + origin.Y;

            //    Pen pen = new Pen(Color.Red);

            //    g.DrawLine(pen, offX, offY + tileRowOffset / 2, offX + tileColumnOffset / 2, offY);
            //    g.DrawLine(pen, offX + tileColumnOffset / 2, offY, offX + tileColumnOffset, offY + tileRowOffset / 2);
            //    g.DrawLine(pen, offX + tileColumnOffset, offY + tileRowOffset / 2, offX + tileColumnOffset / 2, offY + tileRowOffset);
            //    g.DrawLine(pen, offX + tileColumnOffset / 2, offY + tileRowOffset, offX, offY + tileRowOffset / 2);
            //}


            g.Dispose();
        }

        static public void ClearDrawing(ref Bitmap bitmap)
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            g.Dispose();
        }
    }
}
