using System;
using System.Windows.Forms;

namespace DnD_Dungeon_Builder
{
    public partial class StringInputForm : Form
    {
        public string InputText { get; private set; }

        public StringInputForm()
        {
            InitializeComponent();

            ActiveControl = tbInput;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (tbInput.Text.Trim() != "")
            {
                InputText = tbInput.Text.Trim();

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please enter something in the inputbox.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK.PerformClick();
            }
        }
    }
}
