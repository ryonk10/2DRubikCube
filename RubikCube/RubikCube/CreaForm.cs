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
    public partial class CreaForm : Form
    {
        private int clickCount;
        public CreaForm(int _clickCount)
        {
            clickCount = _clickCount;
            InitializeComponent();
        }

        private void CreaForm_Load(object sender, EventArgs e)
        {
            labelClear.Text ="計"+ clickCount + "回でクリアしました。";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
