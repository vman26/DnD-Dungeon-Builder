using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DnD_Dungeon_Builder
{
    public class PictureBoxManager
    {
        int rows, cols;
        List<List<ClickThroughPictureBox>> grid;
        public List<List<ClickThroughPictureBox>> Grid { get { return grid; } }
        public int Rows { get { return rows; } }
        public int Columns { get { return cols; } }

        public PictureBoxManager(int cols, int rows)
        {
            this.cols = cols;
            this.rows = rows;

            initMap();
        }

        private ClickThroughPictureBox newPictureBox()
        {
            ClickThroughPictureBox pb = new ClickThroughPictureBox();
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            return pb;
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
        }

        public void AddColumn()
        {
            grid.Add(new List<ClickThroughPictureBox>());
            for (int row = 0; row < rows; row++)
            {
                grid[grid.Count - 1].Add(newPictureBox());
            }
            cols++;
        }

        public void AddRow()
        {
            foreach (List<ClickThroughPictureBox> column in grid)
            {
                column.Add(newPictureBox());
            }
            rows++;
        }

        public void DeleteColumn(int columnIndex)
        {
            if (!(columnIndex >= 0 && columnIndex < grid.Count))
            {
                throw new IndexOutOfRangeException("The given column is not within range of the map!");
            }
            grid.RemoveAt(columnIndex);
            cols--;
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
            grid[x][y].Image = (Bitmap)tObject.Clone();
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
            grid[x][y].Image = null;
        }

        public void Draw()
        {

        }
    }
}
