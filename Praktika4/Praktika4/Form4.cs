using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           PictureBox1.Load("1.jpg");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PictureBox1.Load("9.jpg");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            PictureBox1.Load("2.jpg");
        }

        private void картинктToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
