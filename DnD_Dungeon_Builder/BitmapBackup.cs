using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Dungeon_Builder
{
    class BitmapBackup
    {
        public PictureBox PictureBox { get; private set; }
        public Bitmap Bitmap { get; private set; }

        public List<PictureBox> PictureBoxes { get; private set; }
        public List<Bitmap> Bitmaps { get; private set; }

        public BitmapBackup(PictureBox pictureBox)
        {
            PictureBox = pictureBox;
            if (pictureBox.Image != null)
                Bitmap = (Bitmap)pictureBox.Image.Clone();
            else
                throw new ArgumentNullException("The picturebox given has no image to backup.");
        }

        public BitmapBackup(PictureBox[] pictureBoxes)
        {
            if (pictureBoxes.Count() > 0)
            {
                PictureBoxes = new List<PictureBox>();
                Bitmaps = new List<Bitmap>();
                PictureBoxes = pictureBoxes.ToList();
                foreach (PictureBox pb in pictureBoxes)
                {
                    if (pb.Image != null)
                        Bitmaps.Add((Bitmap)pb.Image.Clone());
                    else
                        Bitmaps.Add(null);
                }
            }
            else
            {
                throw new ArgumentException("pictureBoxes and bitmaps should contain the same number of elements.");
            }
        }

        public void Restore()
        {
            if (PictureBoxes != null && PictureBoxes.Count > 0)
            {
                for (int i = 0; i < PictureBoxes.Count; i++)
                {
                    PictureBoxes[i].Image = Bitmaps[i];
                }
            }
            else
            {
                PictureBox.Image = Bitmap;
            }
        }
    }
}
