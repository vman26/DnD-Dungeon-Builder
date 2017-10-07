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
    public partial class CreateMapForm : Form
    {
        public string MapName { get; private set; }
        public int Xtiles { get; private set; }
        public int Ytiles { get; private set; }

        public CreateMapForm()
        {
            InitializeComponent();
        }

        private void btnCreateMap_Click(object sender, EventArgs e)
        {
            if (tbMapName.Text.Trim() != "")
            {
                MapName = tbMapName.Text.Trim();
                Xtiles = (int)nupXtiles.Value;
                Ytiles = (int)nupYtiles.Value;

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please enter a map name.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
