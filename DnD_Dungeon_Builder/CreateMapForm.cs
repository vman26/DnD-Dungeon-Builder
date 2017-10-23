using System;
using System.Windows.Forms;

namespace DnD_Dungeon_Builder
{
    public partial class CreateMapForm : Form
    {
        public string MapName { get; private set; }
        public int Xtiles { get; private set; }
        public int Ytiles { get; private set; }

        public CreateMapForm()
        {
            InitializeComponent();

            ActiveControl = tbMapName;
        }

        private void btnCreateMap_Click(object sender, EventArgs e)
        {
            if (tbMapName.Text.Trim() != "")
            {
                MapName = tbMapName.Text.Trim();
                Xtiles = (int)nupXtiles.Value;
                Ytiles = (int)nupYtiles.Value;

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please enter a map name.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbMapName_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Enter:
                    btnCreateMap.PerformClick();
                    break;
                case Keys.Up:
                    nupXtiles.Value++;
                    nupYtiles.Value++;
                    break;
                case Keys.Down:
                    nupXtiles.Value--;
                    nupYtiles.Value--;
                    break;
            }
        }
    }
}
