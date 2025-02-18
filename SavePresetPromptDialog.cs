using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Task_Dialog_Generator
{
    public partial class SavePresetPromptDialog : Form
    {
        public SavePresetPromptDialog()
        {
            InitializeComponent();
        }

        public SavePresetPromptDialog(Point initialLocation)
        {
            InitializeComponent();

            StartPosition = FormStartPosition.Manual;
            Location = initialLocation;
        }

        public void ValidateAndClose()
        {
            if (PresetName() == "")
            {
                MessageBox.Show("Please enter a name for the preset.", "You missed something", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            ValidateAndClose();
        }

        public string PresetName()
        {
            return tbPresetName.Text;
        }

        private void tbPresetName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                ValidateAndClose();
            } else if (e.KeyChar == (char)Keys.Escape) {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }
    }
}
