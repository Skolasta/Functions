using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int a, b, i, score;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }

        private void midToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 500;
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 250;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            a = r.Next(0, 300);
            b = r.Next(0, 300);
            pictureBox1.Location = new System.Drawing.Point(a, b);
            label2.Text = score.ToString();
            score = score + 1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = 0;
            i = i + 1;
            if (i == 2)
            {
                pictureBox1.Location = new System.Drawing.Point(a,b);
                b = r.Next(0, 300);
                a = r.Next(0, 300);
                i = 0;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }
    }
}
