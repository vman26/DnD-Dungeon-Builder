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
        int XTiles = 10;
        int YTiles = 10;

        int tileSize = 32;

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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resizeGridPanels();

            ClearDrawing(GridDrawArea);
            ClearDrawing(IsometricDrawArea);

            DrawGridTiles(XTiles, YTiles);
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

            CenterPictureBox(gridPb, GridDrawArea);

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
