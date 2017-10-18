using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Dungeon_Builder
{
    public partial class ObjectDrawFrom : Form
    {
        Point lastPoint = Point.Empty; // Point.Empty represents null for a Point object
        Point keptPoint = Point.Empty;

        bool isMouseDown = false; // This is used to evaluate whether our mousebutton is down or not
        bool isOffset = false;

        Bitmap drawing;
        Bitmap grid2D;
        Bitmap gridIsometric;

        List<BitmapBackup> bitmapBackup;

        public Bitmap TwoDimensional { get; private set; }
        public Bitmap Isometric { get; private set; }
        public Drawing Drawing { get; private set; }

        public ObjectDrawFrom(Drawing drawing, Position position = Position.NotSet)
            : this(drawing?.TwoDView, drawing?.ThreeDView)
        {
            Text = "Edit: " + position.ToString();
        }

            public ObjectDrawFrom(Bitmap twoDimensional = null, Bitmap isometric = null)
        {
            InitializeComponent();
            bitmapBackup = new List<BitmapBackup>();

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
                clearDrawings();
            }

            rbDraw.Checked = true;
            pbDrawColor.BackColor = Color.Black;
            pbFillColor.BackColor = Color.White;

            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Offset start", new EventHandler(SetOffset_Click));
            cm.MenuItems.Add("Item 2");
            pbDrawing2D.ContextMenu = cm;
            pbDrawingIsometric.ContextMenu = cm;
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
            Draw.DrawGridTiles(ref grid2D);
            Draw.DrawIsometricTiles(ref gridIsometric);
        }

        private void pbDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                backup(sender as PictureBox);

                if (rbDraw.Checked || rbLine.Checked || rbRectangle.Checked || rbCircle.Checked || rbEraser.Checked)
                {
                    if (isOffset)
                    {
                        lastPoint = keptPoint;
                    }
                    else
                    {
                        keptPoint = e.Location;
                        lastPoint = e.Location; // We assign the lastPoint to the current mouse position: e.Location
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
            }
        }

        private void pbDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox drawingBox = null;
            if (sender is PictureBox) drawingBox = sender as PictureBox;

            if (drawingBox != null)
            {
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
                                g.DrawLine(drawingPen, lastPoint, e.Location);
                                g.SmoothingMode = SmoothingMode.AntiAlias;
                                // This is to give the drawing a more smoother, less sharper look
                                lastPoint = e.Location; // Keep assigning the lastPoint to the current mouse position
                                if (rbEraser.Checked)
                                    (drawingBox.Image as Bitmap).MakeTransparent(erase);
                            }
                        }
                        if (rbLine.Checked || rbRectangle.Checked || rbCircle.Checked)
                        {
                            drawing = (Bitmap)bitmapBackup.Last().Bitmap.Clone();
                            drawingBox.Image = drawing;
                            using (Graphics g = Graphics.FromImage(drawing))
                            {
                                if (rbLine.Checked)
                                    g.DrawLine(drawingPen, lastPoint, e.Location);
                                if (rbRectangle.Checked)
                                    g.DrawRectangle(drawingPen, Math.Min(lastPoint.X, e.Location.X), Math.Min(lastPoint.Y, e.Location.Y), Math.Abs(e.Location.X - lastPoint.X), Math.Abs(e.Location.Y - lastPoint.Y));
                                if (rbCircle.Checked)
                                    g.DrawEllipse(drawingPen, lastPoint.X, lastPoint.Y, (e.Location.X - lastPoint.X), (e.Location.Y - lastPoint.Y));
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

        private void clearDrawings(int drawing=0)
        {
            Bitmap bmp = new Bitmap(pbDrawing2D.Width, pbDrawing2D.Height);

            switch(drawing)
            {
                case 0:
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
            Invalidate();
        }



        private void loadDrawings(Bitmap twoDimensional, Bitmap isometric = null)
        {
            Bitmap bmp = new Bitmap(pbDrawing2D.Width, pbDrawing2D.Height);
            pbDrawing2D.Image = (twoDimensional != null) ? twoDimensional : bmp;
            bmp = new Bitmap(pbDrawingIsometric.Width, pbDrawingIsometric.Height);
            pbDrawingIsometric.Image = (isometric != null) ? isometric : bmp;
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
                bitmapBackup.Add(new BitmapBackup(pictureBox));
        }

        private void backup(PictureBox[] pictureBoxes)
        {
            if (pictureBoxes != null)
                bitmapBackup.Add(new BitmapBackup(pictureBoxes));
        }

        private void undo()
        {
            if (bitmapBackup.Count > 0)
            {
                BitmapBackup backup = bitmapBackup.Last();
                backup.Restore();
                bitmapBackup.Remove(backup);
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
            TwoDimensional = (Bitmap)pbDrawing2D.Image.Clone();
            Isometric = (Bitmap)pbDrawingIsometric.Image.Clone();

            Drawing = new Drawing(TwoDimensional, Isometric);

            DialogResult = DialogResult.OK;
        }
    }
}
