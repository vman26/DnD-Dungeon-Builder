using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace DnD_Dungeon_Builder
{
    public partial class ObjectDrawFrom : Form
    {
        bool isChanged = false;
        bool isSaved = true;
        Point lastPoint = Point.Empty; // Point.Empty represents null for a Point object
        Point keptPoint = Point.Empty;
        Point rightClick = Point.Empty;

        bool isMouseDown = false; // This is used to evaluate whether our mousebutton is down or not
        bool isOffset = false;

        Bitmap drawing;
        Bitmap grid2D;
        Bitmap gridIsometric;

        List<BitmapBackup> undoBitmapBackup;
        List<BitmapBackup> redoBitmapBackup;

        public Bitmap TwoDimensional { get; private set; }
        public Bitmap Isometric { get; private set; }
        public Drawing Drawing { get; private set; }

        Position Position = Position.NotSet;

        public ObjectDrawFrom(Drawing drawing, Position position = Position.NotSet)
            : this(drawing?.TwoDView, drawing?.ThreeDView)
        {
            Text = "Edit: " + position.ToString();
            Position = position;
        }

            public ObjectDrawFrom(Bitmap twoDimensional = null, Bitmap isometric = null)
        {
            InitializeComponent();

            btnUndo.Enabled = false;
            btnRedo.Enabled = false;

            undoBitmapBackup = new List<BitmapBackup>();
            redoBitmapBackup = new List<BitmapBackup>();

            grid2D = new Bitmap(pbGrid2D.Width, pbGrid2D.Height);
            pbGrid2D.Image = grid2D;

            gridIsometric = new Bitmap(pbGridIsometric.Width, pbGridIsometric.Height);
            pbGridIsometric.Image = gridIsometric;

            // Transparent background...  
            pbDrawing2D.BackColor = Color.Transparent;
            pbDrawingIsometric.BackColor = Color.Transparent;

            // Change parent for overlay PictureBox...
            pbDrawing2D.Parent = pbGrid2D;
            pbDrawingIsometric.Parent = pbGridIsometric;

            // Change size to parentsize and location to parent location
            pbDrawing2D.Size = pbDrawing2D.Parent.Size;
            pbDrawing2D.Location = new Point(0, 0);
            pbDrawingIsometric.Size = pbDrawingIsometric.Parent.Size;
            pbDrawingIsometric.Location = new Point(0, 0);

            if (twoDimensional != null)
            {
                loadDrawings(twoDimensional, isometric);
            }
            else
            {
                // Set default clean image
                clearDrawings(createBackup:false);
            }

            rbDraw.Checked = true;
            pbDrawColor.BackColor = Color.Black;
            pbFillColor.BackColor = Color.White;

            
            pbDrawing2D.ContextMenu = createContextMenu(pbDrawing2D.Name);
            pbDrawingIsometric.ContextMenu = createContextMenu(pbDrawingIsometric.Name);
        }

        private ContextMenu createContextMenu(string pictureboxName)
        {
            ContextMenu cm = new ContextMenu();
            MenuItem item = new MenuItem("Offset start", new EventHandler(SetOffset_Click))
            {
                Name = pictureboxName
            };
            cm.MenuItems.Add(item);
            item = new MenuItem("Pipette", new EventHandler(Pipette_Click))
            {
                Name = pictureboxName
            };
            cm.MenuItems.Add(item);
            
            return cm;
        }

        private void Pipette_Click(object sender, EventArgs e)
        {
            Bitmap bmp = null;
            if ((sender as MenuItem).Name == pbDrawing2D.Name)
            {
                bmp = (Bitmap)pbDrawing2D.Image;
            }
            if ((sender as MenuItem).Name == pbDrawingIsometric.Name)
            {
                bmp = (Bitmap)pbDrawingIsometric.Image;
            }
            Color targetColor = bmp.GetPixel(rightClick.X, rightClick.Y);

            if (rbDraw.Checked || rbLine.Checked || rbRectangle.Checked || rbCircle.Checked)
            {
                pbDrawColor.BackColor = targetColor;
            }

            if (rbFill.Checked)
            {
                pbFillColor.BackColor = targetColor;
            }
        }

        private void SetOffset_Click(object sender, EventArgs e)
        {
            using (OffsetForm form = new OffsetForm())
            {
                form.Parent = Parent;
                form.StartPosition = FormStartPosition.CenterParent;
                if(form.ShowDialog() == DialogResult.OK)
                {
                    keptPoint.Offset(form.XOffset, form.YOffset);
                    isOffset = true;
                }
            }
        }

        private void ObjectDrawFrom_Load(object sender, EventArgs e)
        {
            drawTiles(cbSnapToGrid.Enabled);
        }

        private void drawTiles(bool redrawGrid = false)
        {
            Draw.ClearDrawing(ref grid2D);
            Draw.ClearDrawing(ref gridIsometric);

            if (cbSnapToGrid.Checked && redrawGrid)
            {
                Draw.DrawGridTilesFilled(ref grid2D, (int)nupGridSize.Value);
            }

            Draw.DrawGridTiles(ref grid2D, Position);
            Draw.DrawIsometricTiles(ref gridIsometric, Position);

            pbGrid2D.Image = grid2D;
        }

        private void contentChanged()
        {
            isSaved = false;
            if (!Text.Contains("*"))
                Text += "*";
            isChanged = true;
        }

        private void pbDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                redoBitmapBackup = new List<BitmapBackup>();
                btnRedo.Enabled = false;

                backup(sender as PictureBox);

                if (rbDraw.Checked || rbLine.Checked || rbRectangle.Checked || rbCircle.Checked || rbEraser.Checked)
                {

                    Point mouseLocation = new Point(e.Location.X, e.Location.Y);

                    if (cbSnapToGrid.Checked && (sender as PictureBox).Name == pbDrawing2D.Name)
                    {
                        int gridSize = (int)nupGridSize.Value;
                        mouseLocation.X = (mouseLocation.X / gridSize) * gridSize;
                        mouseLocation.Y = (mouseLocation.Y / gridSize) * gridSize;
                    }

                    if (isOffset)
                    {
                        lastPoint = keptPoint;
                    }
                    else
                    {
                        keptPoint = mouseLocation;
                        lastPoint = mouseLocation; // We assign the lastPoint to the current mouse position: e.Location
                    }
                    isMouseDown = true; // We set to true because our mouse button is down (clicked)
                }

                if (rbFill.Checked)
                {
                    if (sender is PictureBox)
                    {
                        PictureBox pbSelected = sender as PictureBox;

                        if (pbSelected != null)
                        {
                            FloodFill((Bitmap)pbSelected.Image, new Point(e.X, e.Y), (pbSelected.Image as Bitmap).GetPixel(e.X, e.Y), pbFillColor.BackColor);
                            pbSelected.Invalidate();
                        }
                    }
                }
                contentChanged();
            }
            else if(e.Button == MouseButtons.Right)
            {
                rightClick = e.Location;
            }
        }

        private void pbDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox drawingBox = null;
            if (sender is PictureBox) drawingBox = sender as PictureBox;

            if (drawingBox != null)
            {
                Point mouseLocation = new Point(e.Location.X, e.Location.Y);

                if (cbSnapToGrid.Checked && (sender as PictureBox).Name == pbDrawing2D.Name)
                {
                    int gridSize = (int)nupGridSize.Value;
                    mouseLocation.X = (mouseLocation.X / gridSize) * gridSize;
                    mouseLocation.Y = (mouseLocation.Y / gridSize) * gridSize;
                }

                if (isMouseDown == true)
                {
                    if (lastPoint != null)
                    {
                        if (drawingBox.Image == null) // If no available bitmap exists on the picturebox to draw on
                        {
                            // Create a new bitmap
                            Bitmap bmp = new Bitmap(drawingBox.Width, drawingBox.Height);
                            drawingBox.Image = bmp; // Assign the picturebox.Image property to the bitmap created
                        }
                        Pen drawingPen = new Pen(pbDrawColor.BackColor, (int)nupBrushWidth.Value);
                        if (rbDraw.Checked || rbEraser.Checked)
                        {
                            using (Graphics g = Graphics.FromImage(drawingBox.Image))
                            {
                                Color erase = Color.FromArgb(1, 1, 1);
                                drawingPen = (rbEraser.Checked) ? new Pen(erase, (int)nupEraserWidth.Value) : drawingPen;
                                g.DrawLine(drawingPen, lastPoint, mouseLocation);
                                g.SmoothingMode = SmoothingMode.AntiAlias;
                                // This is to give the drawing a more smoother, less sharper look
                                lastPoint = mouseLocation; // Keep assigning the lastPoint to the current mouse position
                                if (rbEraser.Checked)
                                    (drawingBox.Image as Bitmap).MakeTransparent(erase);
                            }
                        }
                        if (rbLine.Checked || rbRectangle.Checked || rbCircle.Checked)
                        {
                            drawing = (Bitmap)undoBitmapBackup.Last().Bitmap.Clone();
                            drawingBox.Image = drawing;
                            using (Graphics g = Graphics.FromImage(drawing))
                            {
                                if (rbLine.Checked)
                                    g.DrawLine(drawingPen, lastPoint, mouseLocation);
                                if (rbRectangle.Checked)
                                    g.DrawRectangle(drawingPen, Math.Min(lastPoint.X, mouseLocation.X), Math.Min(lastPoint.Y, mouseLocation.Y), Math.Abs(mouseLocation.X - lastPoint.X), Math.Abs(mouseLocation.Y - lastPoint.Y));
                                if (rbCircle.Checked)
                                    g.DrawEllipse(drawingPen, lastPoint.X, lastPoint.Y, (mouseLocation.X - lastPoint.X), (mouseLocation.Y - lastPoint.Y));
                                g.SmoothingMode = SmoothingMode.AntiAlias;
                            }
                        }
                        drawingBox.Invalidate(); // Refreshes the picturebox
                    }
                }
            }
        }

        private void pbDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            isOffset = false;
            lastPoint = Point.Empty;
            // Set the previous point back to null if the user lets go of the mouse button
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearDrawings(1);
        }

        private void clearDrawings(int drawing = 0, bool createBackup = true)
        {
            Bitmap bmp = new Bitmap(pbDrawing2D.Width, pbDrawing2D.Height);

            switch(drawing)
            {
                case 0:
                    if(createBackup)
                        backup(new PictureBox[]{ pbDrawing2D, pbDrawingIsometric });
                    break;
                case 1:
                    backup(pbDrawing2D);
                    break;
                case 2:
                    backup(pbDrawingIsometric);
                    break;
            }

            if (drawing == 0 || drawing == 1)
            {
                pbDrawing2D.Image = bmp;
            }
            if (drawing == 0 || drawing == 2)
            {
                bmp = new Bitmap(pbDrawingIsometric.Width, pbDrawingIsometric.Height);
                pbDrawingIsometric.Image = bmp;
            }
            contentChanged();
            Invalidate();
        }



        private void loadDrawings(Bitmap twoDimensional, Bitmap isometric = null)
        {
            Bitmap bmp = new Bitmap(pbDrawing2D.Width, pbDrawing2D.Height);
            pbDrawing2D.Image = (twoDimensional != null) ? (Bitmap)twoDimensional.Clone() : bmp;
            bmp = new Bitmap(pbDrawingIsometric.Width, pbDrawingIsometric.Height);
            pbDrawingIsometric.Image = (isometric != null) ? (Bitmap)isometric.Clone() : bmp;
            Invalidate();
        }

        private void FloodFill(Bitmap bmp, Point pt, Color targetColor, Color replacementColor)
        {
            Stack<Point> pixels = new Stack<Point>();
            targetColor = bmp.GetPixel(pt.X, pt.Y);
            pixels.Push(pt);

            while (pixels.Count > 0)
            {
                Point a = pixels.Pop();
                if (a.X < bmp.Width && a.X > 0 &&
                        a.Y < bmp.Height && a.Y > 0) // Make sure we stay within bounds
                {

                    if (bmp.GetPixel(a.X, a.Y) == targetColor)
                    {
                        bmp.SetPixel(a.X, a.Y, replacementColor);
                        pixels.Push(new Point(a.X - 1, a.Y));
                        pixels.Push(new Point(a.X + 1, a.Y));
                        pixels.Push(new Point(a.X, a.Y - 1));
                        pixels.Push(new Point(a.X, a.Y + 1));
                    }
                }
            }
            return;
        }
        
        private void pbColor_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                PictureBox pbSelected = sender as PictureBox;
                if (cdFillColor.ShowDialog() == DialogResult.OK)
                {
                    pbSelected.BackColor = cdFillColor.Color;
                }
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            undo();
        }

        private void backup(PictureBox pictureBox)
        {
            if (pictureBox.Image != null)
            {
                undoBitmapBackup.Add(new BitmapBackup(pictureBox));
                btnUndo.Enabled = true;
            }
        }

        private void backup(PictureBox[] pictureBoxes)
        {
            if (pictureBoxes != null)
            {
                undoBitmapBackup.Add(new BitmapBackup(pictureBoxes));
                btnUndo.Enabled = true;
            }
        }

        private void undo()
        {
            if (undoBitmapBackup.Count > 0)
            {
                contentChanged();
                BitmapBackup backup = undoBitmapBackup.Last();
                if (backup.PictureBoxes != null)
                {
                    redoBitmapBackup.Add(new BitmapBackup(backup.PictureBoxes.ToArray()));
                }
                else
                {
                    redoBitmapBackup.Add(new BitmapBackup(backup.PictureBox));
                }
                btnRedo.Enabled = true;
                backup.Restore();
                undoBitmapBackup.Remove(backup);
                if (undoBitmapBackup.Count <= 0)
                {
                    btnUndo.Enabled = false;
                }
                Invalidate();
            }
        }

        private void redo()
        {
            if (redoBitmapBackup.Count > 0)
            {
                contentChanged();
                BitmapBackup backup = redoBitmapBackup.Last();
                if (backup.PictureBoxes != null)
                {
                    undoBitmapBackup.Add(new BitmapBackup(backup.PictureBoxes.ToArray()));
                }
                else
                {
                    undoBitmapBackup.Add(new BitmapBackup(backup.PictureBox));
                }
                btnUndo.Enabled = true;
                backup.Restore();
                redoBitmapBackup.Remove(backup);
                if (redoBitmapBackup.Count <= 0)
                {
                    btnRedo.Enabled = false;
                }
                Invalidate();
            }
        }

        private void btnClearIso_Click(object sender, EventArgs e)
        {
            clearDrawings(2);
        }

        private void btnClearBoth_Click(object sender, EventArgs e)
        {
            clearDrawings();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save();
        }

        private void save()
        {
            isSaved = true;
            Text = Text.Substring(0, Text.IndexOf("*"));
            TwoDimensional = (Bitmap)pbDrawing2D.Image.Clone();
            TwoDimensional.MakeTransparent();
            Isometric = (Bitmap)pbDrawingIsometric.Image.Clone();
            Isometric.MakeTransparent();

            Drawing = new Drawing(TwoDimensional, Isometric);
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            redo();
        }

        private void ObjectDrawFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isChanged)
            {
                DialogResult = DialogResult.Cancel;
                return;
            }
            if (isSaved)
            {
                DialogResult = DialogResult.OK;
                return;
            }
            else
            {
                if (MessageBox.Show("Do you want to save all changes before exiting?","Save?",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    save();
                    DialogResult = DialogResult.OK;
                    return;
                }
            }
        }

        private void nupGridSize_ValueChanged(object sender, EventArgs e)
        {
            drawTiles(true);
        }

        private void cbSnapToGrid_CheckedChanged(object sender, EventArgs e)
        {
            drawTiles(true);
        }
    }
}
