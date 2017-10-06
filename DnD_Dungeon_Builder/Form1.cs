﻿using System;
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

            //gridPanel.AutoScroll = true;
            //isometricPanel.AutoScroll = true;

            this.Name = "D&D dungeon builder";
            this.Text = "D&D dungeon builder";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshScreen();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            refreshScreen();
        }

        void resizePanels()
        {
            int controlPanelHeigth = 75;
            Size frameSize = ClientRectangle.Size; // Get size of frame without borders
            
            controlPanel.Location = new Point(0, 0);
            controlPanel.Size = new Size(frameSize.Width, controlPanelHeigth);

            gridPanel.Location = new Point(0, controlPanelHeigth);
            gridPanel.Size = new Size(frameSize.Width / 2, frameSize.Height - controlPanelHeigth);
            
            isometricPanel.Location = new Point(frameSize.Width / 2, controlPanelHeigth);
            isometricPanel.Size = new Size(frameSize.Width / 2, frameSize.Height - controlPanelHeigth);
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
            if (map != null)
            {
                Draw.DrawGridTiles(map.Columns, map.Rows, tileSize, ref GridDrawArea, selectedTileX, selectedTileY);
                CenterPictureBox(gridPb, GridDrawArea);

                Draw.DrawIsometricTiles(map.Columns, map.Rows, tileSize, ref IsometricDrawArea, selectedTileX, selectedTileY);
                CenterPictureBox(isometricPb, IsometricDrawArea);
            }
        }

        private void gridPb_MouseDown(object sender, MouseEventArgs e)
        {
            Point selectedTile = Mouse.Calculate2DGridPosition(gridPb.Size, new Size(map.Columns, map.Rows), e.Location);
            redrawTiles(selectedTile.X, selectedTile.Y);
        }

        private void isometricPb_MouseDown(object sender, MouseEventArgs e)
        {
            var IsoW = tileSize; // cell width
            var IsoH = tileSize / 2; // cell height
            var IsoX = IsometricDrawArea.Width / 2;
            var IsoY = 0;

            Point selectedTile = new Point(Coordinate.ScreenToIsoX(e.X, e.Y, IsoX, IsoW, IsoY, IsoH), Coordinate.ScreenToIsoY(e.X, e.Y, IsoX, IsoW, IsoY, IsoH));
            redrawTiles(selectedTile.X, selectedTile.Y);
        }

        private void btnNewMap_Click(object sender, EventArgs e)
        {
            map = new Map<int>((int)nupXtiles.Value, (int)nupYtiles.Value, "Test map");
            refreshScreen();
        }

        private void nupTileSize_ValueChanged(object sender, EventArgs e)
        {
            tileSize = (int)nupTileSize.Value;
            refreshScreen();
        }

        private void btnClearMap_Click(object sender, EventArgs e)
        {
            map?.ClearMap();
            refreshScreen();
        }

        private void refreshScreen()
        {
            resizePanels();
            redrawTiles();
        }

        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            map?.AddColumn();
            refreshScreen();
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            map?.AddRow();
            refreshScreen();
        }
    }
}
