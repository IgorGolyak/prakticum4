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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime d = monthCalendar1.SelectionStart;
            MessageBox.Show(d.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d = dateTimePicker1.Value;
            textBox1.Text = d.ToString();
            DateTime a = monthCalendar1.SelectionStart;
            textBox2.Text = a.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }
    }
}
