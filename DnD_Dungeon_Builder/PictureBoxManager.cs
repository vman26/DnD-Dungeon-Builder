using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Dungeon_Builder
{
    public class PictureBoxManager
    {
        int rows, cols;
        List<List<PictureBox>> grid;
        public List<List<PictureBox>> Grid { get { return grid; } }
        public int Rows { get { return rows; } }
        public int Columns { get { return cols; } }

        public PictureBoxManager(int cols, int rows)
        {
            this.cols = cols;
            this.rows = rows;

            initMap();
        }

        private void initMap()
        {
            grid = new List<List<PictureBox>>();
            for (int col = 0; col < cols; col++)
            {
                grid.Add(new List<PictureBox>());
                for (int row = 0; row < rows; row++)
                {
                    grid[col].Add(null);
                }
            }
        }

        public void AddColumn()
        {
            grid.Add(new List<PictureBox>());
            for (int row = 0; row < rows; row++)
            {
                grid[grid.Count - 1].Add(null);
            }
            cols++;
        }

        public void AddRow()
        {
            foreach (List<PictureBox> column in grid)
            {
                column.Add(null);
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
            foreach (List<PictureBox> row in grid)
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

        public void AddObject(int x, int y, PictureBox tObject)
        {
            if (!(x >= 0 && x < grid.Count))
            {
                throw new IndexOutOfRangeException("The given x is not within range of the map!");
            }
            if (!(y >= 0 && y < grid[x].Count))
            {
                throw new IndexOutOfRangeException("The given y is not within range of the map!");
            }
            grid[x][y] = tObject;
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

        public void RemoveObject(int x, int y)
        {
            grid[x][y] = null;
        }
    }
}
