using System;
using System.Drawing;
using System.Drawing.Drawing2D;

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


        static public void DrawGridTiles(ref Bitmap bitmap, Position position = Position.NotSet)
        {
            Graphics g = Graphics.FromImage(bitmap);
            int size = Math.Min(bitmap.Width, bitmap.Height);
            int x = 0;
            int y = 0;

            if (bitmap.Height < bitmap.Width)
            {
                x = (bitmap.Width - size) / 2;
            }
            else
            {
                y = (bitmap.Height - size) / 2;
            }

            // Draw tile outline
            Pen pen = new Pen(Color.Black);
            Pen positionPen = new Pen(Color.Red);
            size-=1;

            g.DrawLine((position == Position.West) ? positionPen : pen, x, y, x, y + size);
            g.DrawLine((position == Position.South) ? positionPen : pen, x, y + size, x + size, y + size);
            g.DrawLine((position == Position.East) ? positionPen : pen, x + size, y + size, x + size, y);
            g.DrawLine((position == Position.North) ? positionPen : pen, x + size, y, x, y);
            g.Dispose();
        }

        static public void DrawIsometricTiles(ref Bitmap bitmap, Position position = Position.NotSet)
        {
            Graphics g = Graphics.FromImage(bitmap);
            int size = bitmap.Width / 2;

            var IsoW = size; // cell width
            var IsoH = size / 2; // cell height
            var IsoX = bitmap.Width / 2;
            var IsoY = 0;

            int x = 0;
            int y = 0;

            var rx = Coordinate.IsoToScreenX(x, y, IsoX, IsoW);
            var ry = Coordinate.IsoToScreenY(x, y, IsoY, IsoH);

            ry += bitmap.Height - IsoW - 2;
            
            Pen pen = new Pen(Color.Black);
            Pen positionPen = new Pen(Color.Red);

            g.DrawLine((position == Position.West) ? positionPen : pen, rx, ry, rx - IsoW, ry + IsoH);
            g.DrawLine((position == Position.South) ? positionPen : pen, rx - IsoW, ry + IsoH, rx, ry + IsoH * 2);
            g.DrawLine((position == Position.East) ? positionPen : pen, rx, ry + IsoH * 2, rx + IsoW, ry + IsoH);
            g.DrawLine((position == Position.North) ? positionPen : pen, rx + IsoW, ry + IsoH, rx, ry);

            g.Dispose();
        }

        static public void ClearDrawing(ref Bitmap bitmap)
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.Transparent);
            g.Dispose();
        }

        public static GraphicsPath Transparent(Image im)
        {
            int x;
            int y;
            Bitmap bmp = new Bitmap(im);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            Color mask = bmp.GetPixel(0, 0);

            for (x = 0; x <= bmp.Width - 1; x++)
            {
                for (y = 0; y <= bmp.Height - 1; y++)
                {
                    if (!bmp.GetPixel(x, y).Equals(mask))
                    {
                        gp.AddRectangle(new Rectangle(x, y, 1, 1));
                    }
                }
            }
            bmp.Dispose();
            return gp;

        }
    }
}
