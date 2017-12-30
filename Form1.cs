using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen p=new Pen(Color.Black, 1);
        Point sp = new Point(0, 0);
        Point ep = new Point(0, 0);
        int k = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void red_Click(object sender, EventArgs e)
        {
            p.Color = red.BackColor;
            default1.BackColor = red.BackColor;
        }

        private void green_Click(object sender, EventArgs e)
        {
            p.Color = green.BackColor;
            default1.BackColor = green.BackColor;
        }

        private void blue_Click(object sender, EventArgs e)
        {
            p.Color = blue.BackColor;
            default1.BackColor = blue.BackColor;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            sp = e.Location;
            if (e.Button == MouseButtons.Left)
                k = 1;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            k = 0;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (k==1)
            {
                ep = e.Location;
                g = this.CreateGraphics();
                g.DrawLine(p, sp, ep);
            }
            sp = ep;
        }
    }
}
