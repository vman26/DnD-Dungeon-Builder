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
        PictureBoxManager pbManager2D;
        PictureBoxManager pbManagerIsometric;

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
                if (pbManager2D != null)
                {
                    pbManager2D.Draw(map.Columns, map.Rows, tileSize);
                }

                Draw.DrawIsometricTiles(map.Columns, map.Rows, tileSize, ref IsometricDrawArea, isoBackgroundColor, selectedTileX, selectedTileY);
                CenterPictureBox(isometricPb, IsometricDrawArea);
                if (pbManagerIsometric != null)
                {
                    pbManagerIsometric.Draw(map.Columns, map.Rows, tileSize);
                }
            }
        }

        private void btnNewMap_Click(object sender, EventArgs e)
        {
            using (CreateMapForm form = new CreateMapForm())
            {
                form.Parent = Parent;
                form.StartPosition = FormStartPosition.CenterParent;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    map = new Map<ComponentVariant>(form.Xtiles, form.Ytiles, form.MapName);
                    pbManager2D = new PictureBoxManager(form.Xtiles, form.Ytiles, GridType.TwoDimensional, this, gridPb);
                    pbManagerIsometric = new PictureBoxManager(form.Xtiles, form.Ytiles, GridType.Isometric, this, isometricPb);
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
            
            if (map != null)
            {
                for (int x = 0; x < map.Columns; x++)
                {
                    for (int y = 0; y < map.Rows; y++)
                    {
                        Drawing drawing = map.GetObject(x, y)?.GetDrawing(Position.North);
                        pbManager2D.AddObject(x, y, drawing?.TwoDView);
                        pbManagerIsometric.AddObject(x, y, drawing?.ThreeDView);
                        Invalidate();
                    }
                }
                gridPb.Image = Draw.CombineImages(gridPb.Size, pbManager2D.CombineImages(gridPb.Size), GridDrawArea);
                isometricPb.Image = Draw.CombineImages(isometricPb.Size, pbManagerIsometric.CombineImages(isometricPb.Size), IsometricDrawArea);
            }

            changeInfo();
        }

        private void changeInfo()
        {
            cbComponents.Enabled = (selectedTile != nullPoint);
            cbVariants.Enabled = (selectedTile != nullPoint);
            btnNoneComponent.Enabled = (selectedTile != nullPoint);
            if (selectedTile != nullPoint)
            {
                ComponentVariant selectedTileVariant = map.GetObject(selectedTile.X, selectedTile.Y);
                if (selectedTileVariant == null)
                {
                    lblComponentSelected.Text = "None";
                    lblComponentSelected.Text = "None";
                    int componentCount = cbComponents.Items.Count;
                    componentCount = (componentCount > 0) ? 1 : 0;
                    cbComponents.SelectedIndex = componentCount - 1;
                    cbComponents_SelectedIndexChanged(cbComponents, new EventArgs());
                }
                else
                {
                    lblComponentSelected.Text = selectedTileVariant.Parent?.Name;
                    lblVariantSelected.Text = selectedTileVariant.Name;
                    cbComponents.SelectedItem = selectedTileVariant.Parent;
                    cbVariants.SelectedItem = selectedTileVariant;
                }
            }
        }

        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            if (map != null)
            {
                map.AddColumn();
                pbManager2D?.AddColumn();
                pbManagerIsometric?.AddColumn();
                refreshScreen();
            }
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            if (map != null)
            {
                map.AddRow();
                pbManager2D?.AddRow();
                pbManagerIsometric?.AddRow();
                refreshScreen();
            }
        }

        private void btnAddColumnAndRow_Click(object sender, EventArgs e)
        {
            if (map != null)
            {
                map.AddColumn();
                map.AddRow();
                pbManager2D?.AddColumn();
                pbManager2D?.AddRow();
                pbManagerIsometric?.AddColumn();
                pbManagerIsometric?.AddRow();
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
                if (cbVariants.SelectedItem is ComponentVariant)
                {
                    ComponentVariant component = cbVariants.SelectedItem as ComponentVariant;
                    map.AddObject(selectedTile.X, selectedTile.Y, component);
                    refreshScreen(false);
                }
            }
        }

        private void btnNoneComponent_Click(object sender, EventArgs e)
        {
            if (selectedTile != nullPoint)
            {
                map.RemoveObject(selectedTile.X, selectedTile.Y);
                refreshScreen(false);
            }
        }

        private void gridPb_MouseDown(object sender, MouseEventArgs e)
        {
            selectedTile = Mouse.Calculate2DGridPosition(gridPb.Size, new Size(map.Columns, map.Rows), e.Location);

            if (Enumerable.Range(0, map.Columns).Contains(selectedTile.X) && Enumerable.Range(0, map.Rows).Contains(selectedTile.Y))
            {
                redrawTiles(selectedTile.X, selectedTile.Y);
                refreshScreen(false);
            }
            else
            {
                selectedTile = nullPoint;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(pbManagerIsometric.CombineImages(isometricPb.Size));
            form.Show();
        }
    }
}
