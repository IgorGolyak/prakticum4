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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
             double a = Convert.ToDouble(textBox1.Text);
             double b = Convert.ToDouble(textBox4.Text);
             double c = a + b;
             textBox3.Text = c.ToString();
            }

            else
            {
                if (radioButton2.Checked)
                {
                 double a = Convert.ToDouble(textBox1.Text);
                 double b = Convert.ToDouble(textBox4.Text);
                 double c = a - b;
                 textBox3.Text = c.ToString();
                }

                else
                {
                    if (radioButton3.Checked)
                    {
                     double a = Convert.ToDouble(textBox1.Text);
                     double b = Convert.ToDouble(textBox4.Text);
                     double c = a * b;
                     textBox3.Text = c.ToString();
                    }

                    else
                    {
                      if (radioButton4.Checked)
                      {
                       double a = Convert.ToDouble(textBox1.Text);
                       double b = Convert.ToDouble(textBox4.Text);
                       double c = a / b;
                       textBox3.Text = c.ToString();
                      }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
