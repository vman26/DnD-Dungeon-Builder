using System;
using System.Windows.Forms;

namespace DnD_Dungeon_Builder
{
    public partial class OffsetForm : Form
    {
        public int XOffset { get; private set; }
        public int YOffset { get; private set; }

        public OffsetForm()
        {
            InitializeComponent();
        }

        private void btnSetOffset_Click(object sender, EventArgs e)
        {
            XOffset = (int)nupOffsetX.Value;
            YOffset = (int)nupOffsetY.Value;

            DialogResult = DialogResult.OK;
        }
    }
}
