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
        int tileSize = 64;
        int originX = 0;
        int originY = 0;
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

            ClearDrawing(GridDrawArea);
            ClearDrawing(IsometricDrawArea);

            DrawGridTiles(map.Columns, map.Rows);
            CenterPictureBox(gridPb, GridDrawArea);

            DrawIsometricTiles(map.Columns, map.Rows);
            CenterPictureBox(isometricPb, IsometricDrawArea);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeGridPanels();
        }

        void resizeGridPanels()
        {
            Size frameSize = ClientRectangle.Size; // Get size of frame without borders

            gridPanel.Location = new Point(0, 0); // First panel
            gridPanel.Size = new Size(frameSize.Width / 2, frameSize.Height);
            
            isometricPanel.Location = new Point(frameSize.Width / 2, 0); // First panel
            isometricPanel.Size = new Size(frameSize.Width / 2, frameSize.Height);

            CenterPictureBox(gridPb, GridDrawArea);
            CenterPictureBox(isometricPb, IsometricDrawArea);

            this.originX = frameSize.Width / 2 - map.Columns * tileSize / 2;
            this.originY = frameSize.Height / 2;
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

        void DrawGridTiles(int xTiles, int yTiles)
        {
            GridDrawArea = new Bitmap(tileSize * xTiles + 1, tileSize * yTiles + 1);
            Graphics g = Graphics.FromImage(GridDrawArea);

            for (int Xi = 0; Xi < xTiles; Xi++)
            {
                for (var Yi = 0; Yi < yTiles; Yi++)
                {
                    // Draw tile outline
                    Pen pen = new Pen(Color.Black);
                    g.DrawRectangle(pen, Xi * tileSize, Yi * tileSize, tileSize, tileSize);
                }
            }
            g.Dispose();
        }

        void DrawIsometricTiles(int xTiles, int yTiles)
        {
            IsometricDrawArea = new Bitmap(tileSize * xTiles + 1, tileSize * yTiles + 1);
            Graphics g = Graphics.FromImage(IsometricDrawArea);

            int tileColumnOffset = tileSize;
            int tileRowOffset = tileSize / 2;

            for (var Xi = 0; Xi < xTiles; Xi++)
            {
                for (var Yi = 0; Yi < yTiles; Yi++)
                {
                    var offX = Xi * tileColumnOffset / 2 + Yi * tileColumnOffset / 2 + originX;
                    var offY = Yi * tileRowOffset / 2 - Xi * tileRowOffset / 2 + originY;
                    
                    Pen pen = new Pen(Color.Black);
                    g.DrawLine(pen, offX, offY + tileRowOffset / 2, offX + tileColumnOffset / 2, offY);
                    g.DrawLine(pen, offX + tileColumnOffset / 2, offY, offX + tileColumnOffset, offY + tileRowOffset / 2);
                    g.DrawLine(pen, offX + tileColumnOffset, offY + tileRowOffset / 2, offX + tileColumnOffset / 2, offY + tileRowOffset);
                    g.DrawLine(pen, offX + tileColumnOffset / 2, offY + tileRowOffset, offX, offY + tileRowOffset / 2);
                }
            }
            g.Dispose();
        }

        void ClearDrawing(Bitmap bitmap)
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            g.Dispose();
        }
    }
}
