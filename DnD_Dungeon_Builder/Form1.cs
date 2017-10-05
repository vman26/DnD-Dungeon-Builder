using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Dungeon_Builder
{
    public partial class Form1 : Form
    {
        int tileSize = 40;

        Map<int> map;

        Bitmap GridDrawArea;
        Bitmap IsometricDrawArea;

        public Form1()
        {
            InitializeComponent();

            GridDrawArea = new Bitmap(gridPb.Size.Width, gridPb.Size.Height);
            gridPb.Image = GridDrawArea;

            IsometricDrawArea = new Bitmap(isometricPb.Size.Width, isometricPb.Size.Height);
            isometricPb.Image = IsometricDrawArea;

            gridPb.SizeMode = PictureBoxSizeMode.AutoSize;
            gridPb.Anchor = AnchorStyles.None;
            isometricPb.SizeMode = PictureBoxSizeMode.AutoSize;
            isometricPb.Anchor = AnchorStyles.None;

            gridPanel.AutoScroll = true;
            isometricPanel.AutoScroll = true;

            map = new Map<int>(10, 10, "Test map");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resizeGridPanels();
            redrawTiles();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeGridPanels();
            redrawTiles();
        }

        void resizeGridPanels()
        {
            Size frameSize = ClientRectangle.Size; // Get size of frame without borders

            gridPanel.Location = new Point(0, 0);
            gridPanel.Size = new Size(frameSize.Width / 2, frameSize.Height);
            
            isometricPanel.Location = new Point(frameSize.Width / 2, 0);
            isometricPanel.Size = new Size(frameSize.Width / 2, frameSize.Height);
        }

        private void CenterPictureBox(PictureBox picBox, Bitmap picImage)
        {
            picBox.Anchor = AnchorStyles.None;
            picBox.Image = picImage;
            int x = (picBox.Parent.ClientSize.Width / 2) - (picImage.Width / 2);
            if (x < 0) x = 0;
            int y = (picBox.Parent.ClientSize.Height / 2) - (picImage.Height / 2);
            if (y < 0) y = 0;
            picBox.Location = new Point(x, y);
            picBox.Refresh();
            picBox.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
        }

        private void redrawTiles(int selectedTileX = -1, int selectedTileY = -1)
        {
            Draw.ClearDrawing(ref GridDrawArea);
            Draw.ClearDrawing(ref IsometricDrawArea);

            Draw.DrawGridTiles(map.Columns, map.Rows, tileSize, ref GridDrawArea, selectedTileX, selectedTileY);
            CenterPictureBox(gridPb, GridDrawArea);

            Draw.DrawIsometricTiles(map.Columns, map.Rows, tileSize, ref IsometricDrawArea, selectedTileX, selectedTileY);
            CenterPictureBox(isometricPb, IsometricDrawArea);
        }

        private void gridPb_MouseDown(object sender, MouseEventArgs e)
        {
            Point selectedTile = Mouse.Calculate2DGridPosition(gridPb.Size, new Size(map.Columns, map.Rows), e.Location);
            redrawTiles(selectedTile.X, selectedTile.Y);
        }
    }
}
