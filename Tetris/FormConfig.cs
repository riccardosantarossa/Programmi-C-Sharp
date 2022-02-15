using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            trackBarVolume.Value = (int)(Config.volumeAudio * 10);
            trackBarTetramini.Value = Config.sizeTetramini ;
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            Config.volumeAudio = (float)trackBarVolume.Value / (float)10;
        }

        private void trackBarTetramini_Scroll(object sender, EventArgs e)
        {
            Config.sizeTetramini = trackBarTetramini.Value;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
