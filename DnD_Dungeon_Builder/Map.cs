using System;
using System.Collections.Generic;

namespace DnD_Dungeon_Builder
{
    class Map<T>
    {
        int rows, cols;
        List<List<T>> grid;
        public List<List<T>> Grid { get { return grid; } }
        public int Rows { get { return rows; } }
        public int Columns { get { return cols; } }
        public string Name { get; private set; }

        public Map(int columns, int rows, string name)
        {
            this.cols = columns;
            this.rows = rows;
            this.Name = name;

            initMap();
        }

        private void initMap()
        {
            grid = new List<List<T>>();
            for (int col = 0; col < cols; col++)
            {
                grid.Add(new List<T>());
                for (int row = 0; row < rows; row++)
                {
                    grid[col].Add(default(T));
                }
            }
        }

        public void AddColumn()
        {
            grid.Add(new List<T>());
            for (int row = 0; row < rows; row++)
            {
                grid[grid.Count-1].Add(default(T));
            }
            cols++;
        }

        public void AddRow()
        {
            foreach (List<T> column in grid)
            {
                column.Add(default(T));
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
            foreach (List<T> row in grid)
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

        public void AddObject(int x, int y, T tObject)
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

        public override string ToString()
        {
            return Name;
        }
    }
}
