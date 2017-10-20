using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DnD_Dungeon_Builder
{
    public partial class Form1 : Form
    {
        int tileSize = 40;

        Map<ComponentVariant> map;

        Bitmap GridDrawArea;
        Bitmap IsometricDrawArea;

        Color isoBackgroundColor;

        ComponentManager componentManager;
        Point nullPoint = new Point(-9999, -9999);
        Point selectedTile;

        public Form1()
        {
            InitializeComponent();

            selectedTile = nullPoint;

            componentManager = new ComponentManager();

            //bindingSource1.DataSource = countries;

            cbComponents.DataSource = componentManager.Components;
            cbComponents.DisplayMember = "Name";

            GridDrawArea = new Bitmap(gridPb.Size.Width, gridPb.Size.Height);
            gridPb.Image = GridDrawArea;

            IsometricDrawArea = new Bitmap(isometricPb.Size.Width, isometricPb.Size.Height);
            isometricPb.Image = IsometricDrawArea;

            gridPb.SizeMode = PictureBoxSizeMode.AutoSize;
            gridPb.Anchor = AnchorStyles.None;
            isometricPb.SizeMode = PictureBoxSizeMode.AutoSize;
            isometricPb.Anchor = AnchorStyles.None;

            gridPanel.BackColor = Color.White;
            isometricPanel.BackColor = Color.White;

            isometricPb.BackColor = Color.Transparent;
            gridPb.BackColor = Color.Transparent;

            isoBackgroundColor = Color.Transparent;

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

                Draw.DrawIsometricTiles(map.Columns, map.Rows, tileSize, ref IsometricDrawArea, isoBackgroundColor, selectedTileX, selectedTileY);
                CenterPictureBox(isometricPb, IsometricDrawArea);
            }
        }

        private void btnNewMap_Click(object sender, EventArgs e)
        {
            using (CreateMapForm form = new CreateMapForm())
            {
                form.Parent = this.Parent;
                form.StartPosition = FormStartPosition.CenterParent;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    map = new Map<ComponentVariant>(form.Xtiles, form.Ytiles, form.MapName);
                    refreshScreen();
                }
            }
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

        private void refreshScreen(bool redraw = true)
        {
            if (redraw)
            {
                resizePanels();
                redrawTiles();
                selectedTile = nullPoint;
            }
            cbComponents.Enabled = (selectedTile != nullPoint);
            cbVariants.Enabled = (selectedTile != nullPoint);
            btnNoneComponent.Enabled = (selectedTile != nullPoint);
        }

        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            if (map != null)
            {
                map.AddColumn();
                refreshScreen();
            }
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            if (map != null)
            {
                map.AddRow();
                refreshScreen();
            }
        }

        private void btnAddColumnAndRow_Click(object sender, EventArgs e)
        {
            if (map != null)
            {
                map.AddColumn();
                map.AddRow();
                refreshScreen();
            }
        }

        private void btnBackgroundColor_Click(object sender, EventArgs e)
        {
            if (cdBackgroud.ShowDialog() == DialogResult.OK)
            {
                isoBackgroundColor = cdBackgroud.Color;
                refreshScreen();
            }
        }

        private void btnComponentManager_Click(object sender, EventArgs e)
        {
            using (ComponentManagerForm form = new ComponentManagerForm(componentManager))
            {
                form.Parent = Parent;
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }
        }

        private void cbComponents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedTile != nullPoint)
            {
                if (cbComponents.SelectedItem is Component)
                {
                    Component component = cbComponents.SelectedItem as Component;
                    cbVariants.DataSource = component.Components;
                    cbVariants.DisplayMember = "Name";
                    int variantCount = cbVariants.Items.Count;
                    variantCount = (variantCount > 0) ? 1 : 0;
                    cbVariants.SelectedIndex = variantCount - 1;
                    cbVariants_SelectedIndexChanged(cbVariants, new EventArgs());
                }
                else
                {
                    cbVariants.DataSource = null;
                }
            }
        }

        private void cbVariants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedTile != nullPoint)
            {
                if (cbVariants.SelectedItem is Component)
                {
                    ComponentVariant component = cbVariants.SelectedItem as ComponentVariant;
                }
            }
        }

        private void btnNoneComponent_Click(object sender, EventArgs e)
        {
            if (selectedTile != nullPoint)
            {
                map.RemoveObject(selectedTile.X, selectedTile.Y);
            }
        }

        private void gridPb_MouseDown(object sender, MouseEventArgs e)
        {
            selectedTile = Mouse.Calculate2DGridPosition(gridPb.Size, new Size(map.Columns, map.Rows), e.Location);

            if (Enumerable.Range(0, map.Columns).Contains(selectedTile.X) && Enumerable.Range(0, map.Rows).Contains(selectedTile.Y))
            {
                redrawTiles(selectedTile.X, selectedTile.Y);
                refreshScreen(false);
                int componentCount = cbComponents.Items.Count;
                componentCount = (componentCount > 0) ? 1 : 0;
                cbComponents.SelectedIndex = componentCount - 1;
                cbComponents_SelectedIndexChanged(cbComponents, new EventArgs());
            }
            else
            {
                selectedTile = nullPoint;
            }
        }
    }
}
