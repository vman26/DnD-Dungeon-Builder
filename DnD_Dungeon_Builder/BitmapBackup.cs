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

        public BitmapBackup(PictureBox pictureBox, Bitmap bitmap)
        {
            PictureBox = pictureBox;
            Bitmap = bitmap;
        }

        public void Restore()
        {
            PictureBox.Image = Bitmap;
        }
    }
}
