﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace DnD_Dungeon_Builder
{
    public partial class ComponentManagerForm : Form
    {
        ComponentManager componentManager;
        Component selectedComponent = null;
        ComponentVariant selectedVariant = null;

        Position copyPosition = Position.NotSet;

        public ComponentManagerForm(ComponentManager componentManager)
        {
            InitializeComponent();

            DoubleBuffered = true;

            this.componentManager = componentManager;
            KeyPreview = true;
            
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

            lbComponents.SelectedIndex = lbComponents.Items.Count - 1;
            lbComponents_SelectedIndexChanged(lbComponents, new EventArgs());

        }

        private ContextMenu createContextMenu(Position position)
        {
            ContextMenu cm = new ContextMenu();

            MenuItem item = new MenuItem("Copy to All", new EventHandler(CopyToAll_Click))
            {
                Name = position.ToString()
            };
            cm.MenuItems.Add(item);

            if (position != Position.North)
            {
                item = new MenuItem("Copy to North", new EventHandler(CopyToNorth_Click))
                {
                    Name = position.ToString()
                };
                cm.MenuItems.Add(item);
            }
            if (position != Position.East)
            {
                item = new MenuItem("Copy to East", new EventHandler(CopyToEast_Click))
                {
                    Name = position.ToString()
                };
                cm.MenuItems.Add(item);
            }
            if (position != Position.South)
            {
                item = new MenuItem("Copy to South", new EventHandler(CopyToSouth_Click))
                {
                    Name = position.ToString()
                };
                cm.MenuItems.Add(item);
            }
            if (position != Position.West)
            {
                item = new MenuItem("Copy to West", new EventHandler(CopyToWest_Click))
                {
                    Name = position.ToString()
                };
                cm.MenuItems.Add(item);
            }

            return cm;
        }

        private ContextMenu createContextMenuIsometric(Position position)
        {
            ContextMenu cm = new ContextMenu();

            MenuItem item = new MenuItem("Copy", new EventHandler(Copy_Click))
            {
                Name = position.ToString()
            };
            cm.MenuItems.Add(item);
            item = new MenuItem("Paste", new EventHandler(Paste_Click))
            {
                Name = position.ToString()
            };
            cm.MenuItems.Add(item);

            return cm;
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            if (sender is MenuItem)
            {
                MenuItem menuItem = sender as MenuItem;
                Position position = Position.NotSet;
                if (Enum.TryParse(menuItem.Name, out position))
                {
                    if (copyPosition != Position.NotSet)
                    {
                        CopyBitmap(copyPosition, position);
                    }
                }
            }
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            if (sender is MenuItem)
            {
                MenuItem menuItem = sender as MenuItem;
                Position position = Position.NotSet;
                if (Enum.TryParse(menuItem.Name, out position))
                {
                    copyPosition = position;
                }
            }
        }

        private void CopyToAll_Click(object sender, EventArgs e)
        {
            if (sender is MenuItem)
            {
                MenuItem menuItem = sender as MenuItem;
                Position position = Position.NotSet;
                if (Enum.TryParse(menuItem.Name, out position))
                {
                    rotateBitmap(position, Position.North);
                    rotateBitmap(position, Position.East);
                    rotateBitmap(position, Position.South);
                    rotateBitmap(position, Position.West);
                }
            }
        }

        private void CopyToWest_Click(object sender, EventArgs e)
        {
            if (sender is MenuItem)
            {
                MenuItem menuItem = sender as MenuItem;
                Position position = Position.NotSet;
                if (Enum.TryParse(menuItem.Name, out position))
                {
                    rotateBitmap(position, Position.West);
                }
            }
        }

        private void CopyToSouth_Click(object sender, EventArgs e)
        {
            if (sender is MenuItem)
            {
                MenuItem menuItem = sender as MenuItem;
                Position position = Position.NotSet;
                if (Enum.TryParse(menuItem.Name, out position))
                {
                    rotateBitmap(position, Position.South);
                }
            }
        }

        private void CopyToEast_Click(object sender, EventArgs e)
        {
            if (sender is MenuItem)
            {
                MenuItem menuItem = sender as MenuItem;
                Position position = Position.NotSet;
                if (Enum.TryParse(menuItem.Name, out position))
                {
                    rotateBitmap(position, Position.East);
                }
            }
        }

        private void CopyToNorth_Click(object sender, EventArgs e)
        {
            if (sender is MenuItem)
            {
                MenuItem menuItem = sender as MenuItem;
                Position position = Position.NotSet;
                if (Enum.TryParse(menuItem.Name, out position))
                {
                    rotateBitmap(position, Position.North);
                }
            }
        }

        private void btnAddComponent_Click(object sender, EventArgs e)
        {
            using (StringInputForm form = new StringInputForm())
            {
                form.Parent = Parent;
                form.StartPosition = FormStartPosition.CenterParent;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if(!componentManager.AddNewComponent(form.InputText))
                    {
                        MessageBox.Show("The given component name is already existing in the collection.");
                    }
                    else
                    {
                        lbComponents.SelectedIndex = lbComponents.Items.Count - 1;
                        lbComponents_SelectedIndexChanged(lbComponents, new EventArgs());
                        updateInfo(selectedComponent, selectedVariant);
                    }
                }
            }
        }

        private void btnRemoveComponent_Click(object sender, EventArgs e)
        {
            if (lbComponents.SelectedItem is Component)
            {
                componentManager.RemoveComponent(lbComponents.SelectedItem as Component);
                selectedVariant = null;
                selectedComponent = null;
                lbComponentVariants.DataSource = null;
                lbComponentVariants.Items.Clear();
                updateInfo(selectedComponent, selectedVariant);
            }
        }

        private void btnAddVariant_Click(object sender, EventArgs e)
        {
            if (selectedComponent != null)
            {
                using (StringInputForm form = new StringInputForm())
                {
                    form.Parent = Parent;
                    form.StartPosition = FormStartPosition.CenterParent;
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (!selectedComponent.AddComponent(form.InputText))
                        {
                            MessageBox.Show("The given component name is already existing in the collection.");
                        }
                        else
                        {
                            lbComponentVariants.SelectedIndex = lbComponentVariants.Items.Count - 1;
                            lbComponentVariants_SelectedIndexChanged(lbComponentVariants, new EventArgs());
                            updateInfo(selectedComponent, selectedVariant);
                        }
                    }
                }
            }
        }

        private void btnRemoveVariant_Click(object sender, EventArgs e)
        {
            if (lbComponentVariants.SelectedItem is ComponentVariant)
            {
                selectedComponent.RemoveComponent(lbComponentVariants.SelectedItem as ComponentVariant);
                updateInfo(selectedComponent, selectedVariant);
            }
        }

        private void btnCloneVariant_Click(object sender, EventArgs e)
        {
            if (lbComponentVariants.SelectedItem is ComponentVariant)
            {
                if (selectedComponent != null)
                {
                    using (StringInputForm form = new StringInputForm())
                    {
                        form.Parent = Parent;
                        form.StartPosition = FormStartPosition.CenterParent;
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            if (!selectedComponent.AddComponent(form.InputText, selectedVariant.Drawings))
                            {
                                MessageBox.Show("The given component name is already existing in the collection.");
                            }
                            else
                            {
                                lbComponentVariants.SelectedIndex = lbComponentVariants.Items.Count - 1;
                                lbComponentVariants_SelectedIndexChanged(lbComponentVariants, new EventArgs());
                            }
                        }
                    }
                }
            }
        }

        private void lbComponents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbComponents.SelectedItem is Component)
            {
                selectedComponent = lbComponents.SelectedItem as Component;
                lbComponentVariants.DataSource = selectedComponent.Components;
                lbComponentVariants.DisplayMember = "Name";
                int variantCount = lbComponentVariants.Items.Count;
                variantCount = (variantCount > 0) ? 1 : 0;
                lbComponentVariants.SelectedIndex = variantCount - 1;
                lbComponentVariants_SelectedIndexChanged(lbComponentVariants, new EventArgs());

                if (selectedComponent.Name == "None")
                {
                    selectedComponent = null;
                    updateInfo();
                }
            }
            else
            {
                selectedComponent = null;
                updateInfo();
            }
        }

        private void lbComponentVariants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbComponentVariants.SelectedItem is ComponentVariant)
            {
                selectedVariant = lbComponentVariants.SelectedItem as ComponentVariant;

                if (selectedVariant.Name == "None")
                {
                    selectedVariant = null;
                    updateInfo();
                    return;
                }

                updateInfo(selectedComponent, selectedVariant);
            }
            else
            {
                selectedVariant = null;
                updateInfo();
            }
        }

        private void updateInfo(Component component = null, ComponentVariant componentVariant = null)
        {
            btnAddVariant.Enabled = selectedComponent != null;
            btnRemoveVariant.Enabled = selectedVariant != null;
            btnRemoveComponent.Enabled = selectedComponent != null;
            btnCloneVariant.Enabled = selectedVariant != null;


            btnNorthEdit.Enabled = selectedVariant != null;
            btnEastEdit.Enabled = selectedVariant != null;
            btnSouthEdit.Enabled = selectedVariant != null;
            btnWestEdit.Enabled = selectedVariant != null;

            btnNorthToWest.Enabled = selectedVariant != null;
            btnWestToNorth.Enabled = selectedVariant != null;
            btnEastToSouth.Enabled = selectedVariant != null;
            btnSouthToEast.Enabled = selectedVariant != null;

            if (componentVariant == null)
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

                pbNorth2D.ContextMenu = null;
                pbEast2D.ContextMenu = null;
                pbSouth2D.ContextMenu = null;
                pbWest2D.ContextMenu = null;

                pbNorthIsometric.ContextMenu = null;
                pbEastIsometric.ContextMenu = null;
                pbSouthIsometric.ContextMenu = null;
                pbWestIsometric.ContextMenu = null;

                return;
            }

            lblComponentName.Text = component.Name + ": " + componentVariant.Name;
            
            pbNorth2D.Image = componentVariant.GetDrawing(Position.North)?.TwoDView;
            pbNorthIsometric.Image = componentVariant.GetDrawing(Position.North)?.ThreeDView;
            pbEast2D.Image = componentVariant.GetDrawing(Position.East)?.TwoDView;
            pbEastIsometric.Image = componentVariant.GetDrawing(Position.East)?.ThreeDView;
            pbSouth2D.Image = componentVariant.GetDrawing(Position.South)?.TwoDView;
            pbSouthIsometric.Image = componentVariant.GetDrawing(Position.South)?.ThreeDView;
            pbWest2D.Image = componentVariant.GetDrawing(Position.West)?.TwoDView;
            pbWestIsometric.Image = componentVariant.GetDrawing(Position.West)?.ThreeDView;

            pbNorth2D.ContextMenu = createContextMenu(Position.North);
            pbEast2D.ContextMenu = createContextMenu(Position.East);
            pbSouth2D.ContextMenu = createContextMenu(Position.South);
            pbWest2D.ContextMenu = createContextMenu(Position.West);

            pbNorthIsometric.ContextMenu = createContextMenuIsometric(Position.North);
            pbEastIsometric.ContextMenu = createContextMenuIsometric(Position.East);
            pbSouthIsometric.ContextMenu = createContextMenuIsometric(Position.South);
            pbWestIsometric.ContextMenu = createContextMenuIsometric(Position.West);
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
            Drawing drawing = selectedVariant.GetDrawing(position);
            drawing = drawing ?? new Drawing(position: position);

            using (ObjectDrawFrom form = new ObjectDrawFrom(drawing, position))
            {
                form.Parent = Parent;
                form.StartPosition = FormStartPosition.CenterParent;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    drawing = form.Drawing;
                    drawing.SetPosition(position);
                }
            }

            if (drawing != null)
            {
                selectedVariant.AddDrawing(drawing);
                updateInfo(selectedComponent, selectedVariant);
            }
        }

        private void btnNorthToWest_Click(object sender, EventArgs e)
        {
            rotateAndMirrorViews(Position.North, Position.West);
        }

        private void btnWestToNorth_Click(object sender, EventArgs e)
        {
            rotateAndMirrorViews(Position.West, Position.North);
        }

        private void btnSouthToEast_Click(object sender, EventArgs e)
        {
            rotateAndMirrorViews(Position.South, Position.East);
        }

        private void btnEastToSouth_Click(object sender, EventArgs e)
        {
            rotateAndMirrorViews(Position.East, Position.South);
        }

        private void rotateAndMirrorViews(Position basePosition, Position targetPosition)
        {
            Drawing drawingToCopy = selectedVariant.GetDrawing(basePosition);
            Bitmap twoD = (Bitmap)drawingToCopy.TwoDView.Clone();
            Bitmap isometric = (drawingToCopy.ThreeDView != null) ? (Bitmap)drawingToCopy.ThreeDView.Clone() : null;

            twoD.RotateFlip(calculateRotateFlip(basePosition, targetPosition));
            isometric.RotateFlip(RotateFlipType.RotateNoneFlipX);

            selectedVariant.AddDrawing(new Drawing(twoD, isometric, targetPosition));
            updateInfo(selectedComponent, selectedVariant);
        }

        private void rotateBitmap(Position basePosition, Position targetPosition)
        {
            RotateFlipType rotateFlipType = calculateRotateFlip(basePosition, targetPosition);

            Drawing drawingToCopy = selectedVariant.GetDrawing(basePosition);
            Drawing targetOriginal = selectedVariant.GetDrawing(targetPosition);
            Bitmap twoD = (Bitmap)drawingToCopy.TwoDView.Clone();
            Bitmap isometric = (targetOriginal != null) ? targetOriginal.ThreeDView : null;

            twoD.RotateFlip(rotateFlipType);

            selectedVariant.AddDrawing(new Drawing(twoD, isometric, targetPosition));
            updateInfo(selectedComponent, selectedVariant);
        }

        private void CopyBitmap(Position basePosition, Position targetPosition)
        {
            Drawing drawingToCopy = selectedVariant.GetDrawing(basePosition);
            Drawing targetOriginal = selectedVariant.GetDrawing(targetPosition);
            Bitmap isometric = (Bitmap)drawingToCopy.ThreeDView.Clone();
            Bitmap twoD = (targetOriginal != null) ? targetOriginal.TwoDView : null;
            
            selectedVariant.AddDrawing(new Drawing(twoD, isometric, targetPosition));
            updateInfo(selectedComponent, selectedVariant);
        }

        private RotateFlipType calculateRotateFlip(Position basePosition, Position targetPosition)
        {
            int baseRotation = (int)basePosition;
            int targetRotation = (int)targetPosition;

            int rotation = targetRotation - baseRotation;
            rotation = (rotation < 0) ? 360 + rotation : rotation;

            RotateFlipType rotateFlipType = RotateFlipType.RotateNoneFlipNone;

            switch (rotation)
            {
                case 0:
                    rotateFlipType = RotateFlipType.RotateNoneFlipNone;
                    break;
                case 90:
                    rotateFlipType = RotateFlipType.Rotate90FlipNone;
                    break;
                case 180:
                    rotateFlipType = RotateFlipType.Rotate180FlipNone;
                    break;
                case 270:
                    rotateFlipType = RotateFlipType.Rotate270FlipNone;
                    break;
                default:
                    break;
            }

            return rotateFlipType;
        }

        private void ComponentManagerForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Shift)
            {
                switch (e.KeyCode)
                {
                    case Keys.Insert:
                        btnAddVariant.PerformClick();
                        break;
                    case Keys.Delete:
                        btnRemoveVariant.PerformClick();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.Insert:
                        btnAddComponent.PerformClick();
                        break;
                    case Keys.Delete:
                        btnRemoveComponent.PerformClick();
                        break;
                    case Keys.N:
                        editDrawing(Position.North);
                        break;
                    case Keys.W:
                        editDrawing(Position.West);
                        break;
                    case Keys.S:
                        editDrawing(Position.South);
                        break;
                    case Keys.E:
                        editDrawing(Position.East);
                        break;
                    default:
                        break;
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedComponent != null)
            {
                try
                {
                    componentManager.SaveComponentToFile(selectedComponent);
                }
                catch (IOException)
                {
                    MessageBox.Show("The given filename already exists.");
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            componentManager.LoadComponentsFromFile();
            lbComponents.SelectedIndex = lbComponents.Items.Count - 1;
            lbComponents_SelectedIndexChanged(lbComponents, new EventArgs());
        }
    }
}
