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
    public partial class ComponentManagerForm : Form
    {
        ComponentManager componentManager;
        Component selectedComponent = null;

        public ComponentManagerForm(ComponentManager componentManager)
        {
            InitializeComponent();

            this.componentManager = componentManager;
            
            lbComponents.DataSource = componentManager.Components;
            lbComponents.DisplayMember = "Name";

            pbNorth2D.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNorthIsometric.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEast2D.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEastIsometric.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSouth2D.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSouthIsometric.SizeMode = PictureBoxSizeMode.StretchImage;
            pbWest2D.SizeMode = PictureBoxSizeMode.StretchImage;
            pbWestIsometric.SizeMode = PictureBoxSizeMode.StretchImage;

            updateInfo();
        }

        private void btnAddComponent_Click(object sender, EventArgs e)
        {
            using (StringInputForm form = new StringInputForm())
            {
                form.Parent = this.Parent;
                form.StartPosition = FormStartPosition.CenterParent;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if(!componentManager.AddNewComponent(form.InputText))
                    {
                        MessageBox.Show("The given component name is already existing in the collection.");
                    }
                }
            }
        }

        private void btnRemoveComponent_Click(object sender, EventArgs e)
        {
            if (lbComponents.SelectedItem is Component)
            {
                componentManager.RemoveComponent(lbComponents.SelectedItem as Component);
            }
        }

        private void lbComponents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbComponents.SelectedItem is Component)
            {
                selectedComponent = lbComponents.SelectedItem as Component;

                updateInfo(selectedComponent);
            }
            else
            {
                updateInfo();
            }
        }

        private void updateInfo(Component component = null)
        {
            if(component == null)
            {
                lblComponentName.Text = "No component selected";

                pbNorth2D.Image = null;
                pbNorthIsometric.Image = null;
                pbEast2D.Image = null;
                pbEastIsometric.Image = null;
                pbSouth2D.Image = null;
                pbSouthIsometric.Image = null;
                pbWest2D.Image = null;
                pbWestIsometric.Image = null;

                btnRemoveComponent.Enabled = false;
                btnNorthEdit.Enabled = false;
                btnEastEdit.Enabled = false;
                btnSouthEdit.Enabled = false;
                btnWestEdit.Enabled = false;

                return;
            }

            lblComponentName.Text = component.Name;

            pbNorth2D.Image = component.GetDrawing(Position.North)?.TwoDView;
            pbNorthIsometric.Image = component.GetDrawing(Position.North)?.ThreeDView;
            pbEast2D.Image = component.GetDrawing(Position.East)?.TwoDView;
            pbEastIsometric.Image = component.GetDrawing(Position.East)?.ThreeDView;
            pbSouth2D.Image = component.GetDrawing(Position.South)?.TwoDView;
            pbSouthIsometric.Image = component.GetDrawing(Position.South)?.ThreeDView;
            pbWest2D.Image = component.GetDrawing(Position.West)?.TwoDView;
            pbWestIsometric.Image = component.GetDrawing(Position.West)?.ThreeDView;

            btnRemoveComponent.Enabled = true;
            btnNorthEdit.Enabled = true;
            btnEastEdit.Enabled = true;
            btnSouthEdit.Enabled = true;
            btnWestEdit.Enabled = true;
        }

        private void btnNorthEdit_Click(object sender, EventArgs e)
        {
            editDrawing(Position.North);
        }

        private void btnEastEdit_Click(object sender, EventArgs e)
        {
            editDrawing(Position.East);
        }

        private void btnSouthEdit_Click(object sender, EventArgs e)
        {
            editDrawing(Position.South);
        }

        private void btnWestEdit_Click(object sender, EventArgs e)
        {
            editDrawing(Position.West);
        }

        private void editDrawing(Position position)
        {
            Drawing drawing = selectedComponent.GetDrawing(position);
            drawing = drawing ?? new Drawing(position: position);

            using (ObjectDrawFrom form = new ObjectDrawFrom(drawing))
            {
                form.Parent = Parent;
                form.StartPosition = FormStartPosition.CenterParent;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    drawing = form.Drawing;
                    drawing.SetPosition(position);
                }
                else
                {
                    drawing = null;
                }
            }

            if (drawing != null)
            {
                selectedComponent.AddDrawing(drawing);
                updateInfo(selectedComponent);
            }
        }

        private void btnNorthToWest_Click(object sender, EventArgs e)
        {
            Drawing drawingToCopy = selectedComponent.GetDrawing(Position.North);
            Bitmap twoD = (Bitmap)drawingToCopy.TwoDView.Clone();
            Bitmap isometric = (Bitmap)drawingToCopy.ThreeDView.Clone();

            twoD.RotateFlip(RotateFlipType.Rotate270FlipNone);
            isometric.RotateFlip(RotateFlipType.RotateNoneFlipX);

            selectedComponent.AddDrawing(new Drawing(twoD, isometric, Position.West));
            updateInfo(selectedComponent);
        }

        private void btnWestToNorth_Click(object sender, EventArgs e)
        {
            Drawing drawingToCopy = selectedComponent.GetDrawing(Position.West);
            Bitmap twoD = (Bitmap)drawingToCopy.TwoDView.Clone();
            Bitmap isometric = (Bitmap)drawingToCopy.ThreeDView.Clone();

            twoD.RotateFlip(RotateFlipType.Rotate90FlipNone);
            isometric.RotateFlip(RotateFlipType.RotateNoneFlipX);

            selectedComponent.AddDrawing(new Drawing(twoD, isometric, Position.North));
            updateInfo(selectedComponent);
        }

        private void btnSouthToEast_Click(object sender, EventArgs e)
        {
            Drawing drawingToCopy = selectedComponent.GetDrawing(Position.South);
            Bitmap twoD = (Bitmap)drawingToCopy.TwoDView.Clone();
            Bitmap isometric = (Bitmap)drawingToCopy.ThreeDView.Clone();

            twoD.RotateFlip(RotateFlipType.Rotate270FlipNone);
            isometric.RotateFlip(RotateFlipType.RotateNoneFlipX);

            selectedComponent.AddDrawing(new Drawing(twoD, isometric, Position.East));
            updateInfo(selectedComponent);
        }

        private void btnEastToSouth_Click(object sender, EventArgs e)
        {
            Drawing drawingToCopy = selectedComponent.GetDrawing(Position.East);
            Bitmap twoD = (Bitmap)drawingToCopy.TwoDView.Clone();
            Bitmap isometric = (Bitmap)drawingToCopy.ThreeDView.Clone();

            twoD.RotateFlip(RotateFlipType.Rotate90FlipNone);
            isometric.RotateFlip(RotateFlipType.RotateNoneFlipX);

            selectedComponent.AddDrawing(new Drawing(twoD, isometric, Position.South));
            updateInfo(selectedComponent);
        }
    }
}
