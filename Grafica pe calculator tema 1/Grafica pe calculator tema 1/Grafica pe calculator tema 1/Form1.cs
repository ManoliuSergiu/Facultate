using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafica_pe_calculator_tema_1
{
    public partial class Form1 : Form
    {
        int x0, x1, y0, y1; // punctul a(x0,y0),b(x1,y1)
        long tick = 0, tick1 = 0;
        Bitmap map;
        Timer aux; //Timer pentru limitarea randarii 
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
            MakeLine();
        }

        private void MakeLine()
        {
            map = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            BersenhamLine(x0, y0, x1, y1, trackBar1.Value);
            pictureBox1.Image = map;
        }

        private void BersenhamLine(int x0, int y0, int x1, int y1, int thickness)
        {
            if (Math.Abs(y1 - y0) < Math.Abs(x1 - x0))
            {
                if (x0 > x1)
                    plotLineHigh(x1, y1, x0, y0, thickness);
                else
                    plotLineHigh(x0, y0, x1, y1, thickness);

            }
            else
            {
                if (y0 > y1)
                    plotLineLow(x1, y1, x0, y0, thickness);
                else
                    plotLineLow(x0, y0, x1, y1, thickness);

            }
        }

        private void plotLineLow(int x0, int y0, int x1, int y1, int thickness)
        {
            int dx = x1 - x0;
            int dy = y1 - y0;
            int xi = 1;
            if (dx < 0)
            {
                xi = -1;
                dx = -dx;
            }
            int D = 2 * dx - dy;
            int x = x0;
            for (int y = y0; y < y1; y++)
            {
                for (int i = -(thickness) / 2; i <= (thickness) / 2; i++)
                {
                    map.SetPixel(x + i, y, Color.Black);
                }
                if (D > 0)
                {
                    x += xi;
                    D -= 2 * dy;
                }
                D += 2 * dx;
            }
        }

        private void plotLineHigh(int x0, int y0, int x1, int y1, int thickness)
        {
            int dx = x1 - x0;
            int dy = y1 - y0;
            int yi = 1;
            if (dy < 0)
            {
                yi = -1;
                dy = -dy;
            }
            int D = 2 * dy - dx;
            int y = y0;
            for (int x = x0; x < x1; x++)
            {
                for (int i = -(thickness) / 2; i <= (thickness) / 2; i++)
                {

                    map.SetPixel(x, y+i, Color.Black);
                    
                }
                if (D > 0)
                {
                    y += yi;
                    D -= 2 * dx;
                }
                D += 2 * dy;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            aux.Start();
            x0 = e.X;
            y0 = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (tick < tick1)
                {
                    tick = tick1;

                    if (e.X > trackBar1.Value && e.X < pictureBox1.Width)
                        x1 = e.X;
                    else if (e.X >= pictureBox1.Width)
                        x1 = pictureBox1.Width - 1 - trackBar1.Value;
                    else
                        x1 = 1+ trackBar1.Value;
                    if (e.Y > trackBar1.Value && e.Y < pictureBox1.Height)
                        y1 = e.Y;
                    else if (e.Y >= pictureBox1.Height)
                        y1 = pictureBox1.Height - 1 - trackBar1.Value;
                    else
                        y1 = 1+ trackBar1.Value;

                    MakeLine();
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            map = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            aux = new Timer();
            aux.Interval = 16;
            aux.Tick += Aux_Tick;
        }

        private void Aux_Tick(object sender, EventArgs e)
        {
            tick1++;
        }
    }
}
