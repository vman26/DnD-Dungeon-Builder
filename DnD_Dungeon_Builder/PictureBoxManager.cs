using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace DnD_Dungeon_Builder
{
    public class PictureBoxManager
    {
        List<List<ClickThroughPictureBox>> grid;
        public List<List<ClickThroughPictureBox>> Grid { get { return grid; } }
        public int Rows { get { return rows; } }
        public int Columns { get { return cols; } }

        private Control parent;

        private GridType type;
        private Form form;
        private int rows, cols;
        private Point offset
        {
            get
            {
                Point tmp = Point.Empty;
                if (parent != null)
                {
                    Control p = parent;
                    while (p != null && !(p is Form))
                    {
                        tmp.Offset(p.Location);
                        p = p.Parent;
                    }
                }
                return tmp;
            }
        }

        public PictureBoxManager(int cols, int rows, GridType type, Form form, Control parent = null)
        {
            this.cols = cols;
            this.rows = rows;
            this.type = type;
            this.form = form;
            this.parent = parent;

            

            initMap();
        }

        private ClickThroughPictureBox newPictureBox()
        {
            ClickThroughPictureBox pb = new ClickThroughPictureBox
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                Parent = parent,
                BackColor = Color.Transparent,
            };
            /*form.Controls.Add(pb);
            pb.BringToFront();*/
            return pb;
        }

        private void removePictureBox(ClickThroughPictureBox pb)
        {
            form.Controls.Remove(pb);
        }

        private void initMap()
        {
            grid = new List<List<ClickThroughPictureBox>>();
            for (int col = 0; col < cols; col++)
            {
                grid.Add(new List<ClickThroughPictureBox>());
                for (int row = 0; row < rows; row++)
                {
                    grid[col].Add(newPictureBox());
                }
            }
            form.Invalidate();
        }

        public void AddColumn()
        {
            grid.Add(new List<ClickThroughPictureBox>());
            for (int row = 0; row < rows; row++)
            {
                grid[grid.Count - 1].Add(newPictureBox());
            }
            cols++;
            form.Invalidate();
        }

        public void AddRow()
        {
            foreach (List<ClickThroughPictureBox> column in grid)
            {
                column.Add(newPictureBox());
            }
            rows++;
            form.Invalidate();
        }

        public void DeleteColumn(int columnIndex)
        {
            if (!(columnIndex >= 0 && columnIndex < grid.Count))
            {
                throw new IndexOutOfRangeException("The given column is not within range of the map!");
            }
            grid.RemoveAt(columnIndex);
            cols--;
            form.Invalidate();
        }

        public void DeleteRow(int rowIndex)
        {
            foreach (List<ClickThroughPictureBox> row in grid)
            {
                if (!(rowIndex >= 0 && rowIndex < row.Count))
                {
                    throw new IndexOutOfRangeException("The given column is not within range of the map!");
                }
                grid.RemoveAt(rowIndex);
            }
            rows--;
            form.Invalidate();
        }

        public void ClearMap()
        {
            initMap();
        }

        public void AddObject(int x, int y, Bitmap tObject)
        {
            if (!(x >= 0 && x < grid.Count))
            {
                throw new IndexOutOfRangeException("The given x is not within range of the map!");
            }
            if (!(y >= 0 && y < grid[x].Count))
            {
                throw new IndexOutOfRangeException("The given y is not within range of the map!");
            }
            grid[x][y].Image = (Bitmap)tObject?.Clone();
            grid[x][y].Invalidate();
        }

        public PictureBox GetObject(int x, int y)
        {
            if (!(x >= 0 && x < grid.Count))
            {
                throw new IndexOutOfRangeException("The given x is not within range of the map!");
            }
            if (!(y >= 0 && y < grid[x].Count))
            {
                throw new IndexOutOfRangeException("The given y is not within range of the map!");
            }
            return grid[x][y];
        }

        public List<PictureBox> GetObjects()
        {
            List<PictureBox> pbList = new List<PictureBox>();
            foreach (List<ClickThroughPictureBox> row in grid)
            {
                foreach (ClickThroughPictureBox pb in row)
                {
                    pbList.Add(pb);
                }
            }
            return pbList;
        }

        public void RemoveObject(int x, int y)
        {
            GetObject(x, y).Image = null;
            grid[x][y].Invalidate();
        }

        public void Draw(int xTiles, int yTiles, int tileSize)
        {
            if (type == GridType.TwoDimensional)
            {
                for (int x = 0; x < xTiles; x++)
                {
                    for (var y = 0; y < yTiles; y++)
                    {
                        Point location = new Point(x * tileSize + offset.X, y * tileSize + offset.Y);
                        Size size = new Size(tileSize, tileSize);
                        PictureBox pb = GetObject(x, y);
                        pb.Location = location;
                        pb.Size = size;

                        //g.DrawRectangle(pen, Xi * tileSize, Yi * tileSize, tileSize, tileSize);
                    }
                }
            }
            else if (type == GridType.Isometric)
            {
                int bitmapOffset = 100;
                Size bitmapSize = new Size(tileSize * xTiles * 2 + bitmapOffset, tileSize * yTiles + bitmapOffset);

                if (yTiles - xTiles > 0) bitmapSize.Width += ((yTiles - xTiles) * tileSize * 2);
                if (xTiles - yTiles > 0) bitmapSize.Height += (int)Math.Floor((xTiles - yTiles) * tileSize * 0.5);

                var IsoW = tileSize; // cell width
                var IsoH = tileSize / 2; // cell height
                var IsoX = bitmapSize.Width / 2;
                var IsoY = 0;

                for (var y = 0; y < yTiles; y++)
                {
                    for (var x = 0; x < xTiles; x++)
                    {
                        var rx = Coordinate.IsoToScreenX(x, y, IsoX, IsoW);
                        var ry = Coordinate.IsoToScreenY(x, y, IsoY, IsoH);

                        if (yTiles - xTiles < 0) rx = rx + ((yTiles - xTiles) * IsoW);
                        ry += bitmapOffset / 2;

                        Point location = new Point(rx - IsoW + offset.X, (ry + IsoH * 2) - (IsoW * 2) + offset.Y);
                        Size size = new Size(IsoW * 2, IsoW * 2);
                        PictureBox pb = GetObject(x, y);
                        pb.Location = location;
                        pb.Size = size;

                        /*g.DrawLine(pen, rx, ry, rx - IsoW, ry + IsoH);
                        g.DrawLine(pen, rx - IsoW, ry + IsoH, rx, ry + IsoH * 2);
                        g.DrawLine(pen, rx, ry + IsoH * 2, rx + IsoW, ry + IsoH);
                        g.DrawLine(pen, rx + IsoW, ry + IsoH, rx, ry);*/
                    }
                }
            }
            form.Invalidate();
        }

        public Bitmap CombineImages(Size bitmapSize)
        {
            //a holder for the result
            Bitmap result = new Bitmap(bitmapSize.Width, bitmapSize.Height, PixelFormat.Format64bppArgb);

            //use a graphics object to draw the resized image into the bitmap
            using (Graphics graphics = Graphics.FromImage(result))
            {
                //set the resize quality modes to high quality
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.CompositingMode = CompositingMode.SourceOver;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;

                //draw the images into the target bitmap
                for (int x = 0; x < cols; x++)
                {
                    for (var y = 0; y < rows; y++)
                    {
                        PictureBox pb = grid[x][y];
                        if (pb.Image != null)
                        {
                            Point location = pb.Location;
                            location.Offset(-offset.X, -offset.Y);
                            Rectangle r = new Rectangle(location, pb.Size);
                            graphics.DrawImage(pb.Image, r);
                        }
                    }
                }
            }
            return result;
        }
    }
}
