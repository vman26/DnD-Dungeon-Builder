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
    public partial class Form2 : Form
    {
        public Form2(Bitmap image)
        {
            InitializeComponent();

            pictureBox1.Size = image.Size;
            pictureBox1.Image = image;
        }
    }
}
