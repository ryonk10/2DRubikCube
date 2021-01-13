using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RubikCube
{
    public partial class SetupForm : Form
    {
        internal string _rubikSize;
        internal int _level;
        public SetupForm()
        {
            InitializeComponent();
        }

        private void SetupForm_Load(object sender, EventArgs e)
        {
            if (_rubikSize != null)
            {
                label1.Text = "サイズ、レベルを指定してください。";
            }
        }

        private void setupStartbutton_Click(object sender, EventArgs e)
        {
            if (setupSizetextBox.Text == "" || setupLevelcomboBox.SelectedItem == null)
            {
                MessageBox.Show("サイズ、レベルを指定してください。", "しっかりしろ！！",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _rubikSize = setupSizetextBox.Text;
            _level = setupLevelcomboBox.SelectedIndex + 1;
            this.Visible=false;
        }
    }
}
