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
        int x1, x2, y1, y2; // punctul a(x1,y1),b(x2,y2)
        long tick = 0, tick1 = 0;
        Bitmap map;
        Timer aux; //Timer pentru limitarea randarii 
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;
            MakeLine();
        }

        private void MakeLine()
        {
            map = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            BersenhamLine(x1,y1,x2,y2, trackBar1.Value);
            pictureBox1.Image = map;
        }

        private void BersenhamLine(int x1, int y1, int x2, int y2, int thickness)
        {
            if (Math.Abs(y2 - y1) < Math.Abs(x2 - x1))
            {
                if (x1 > x2)
                        plotLineHigh(x2, y2, x1, y1, thickness);
                else
                        plotLineHigh(x1, y1, x2, y2, thickness);
                    
            }
            else
            {
                if (y1 > y2)
                        plotLineLow(x2, y2, x1, y1, thickness);
                else
                        plotLineLow(x1, y1, x2, y2, thickness);
                    
            }
        }

        private void plotLineLow(int x1, int y1, int x2, int y2, int thickness)
        {
            int dx = x2 - x1;
            int dy = y2 - y1;
            int xi = 1;
            if (dx < 0)
            {
                xi = -1;
                dx = -dx;
            }
            int D = 2 * dx - dy;
            int x = x1;
            for (int y = y1; y < y2; y++)
            {
                for (int i = -(thickness)/2; i <= (thickness) / 2; i++)
                {

                    for (int j = -(thickness) / 2; j <= (thickness) / 2; j++)
                    {
                        map.SetPixel(x + i, y + j, Color.Black);
                    }
                }
                if (D > 0)
                {
                    x += xi;
                    D -= 2 * dy;
                }
                D += 2 * dx;
            }
        }

        private void plotLineHigh(int x1, int y1, int x2, int y2, int thickness)
        {
            int dx = x2 - x1;
            int dy = y2 - y1;
            int yi = 1;
            if (dy < 0)
            {
                yi = -1;
                dy = -dy;
            }
            int D = 2 * dy - dx;
            int y = y1;
            for (int x = x1; x < x2; x++)
            {
                for (int i = -(thickness) / 2; i <= (thickness) / 2; i++)
                {

                    for (int j = -(thickness) / 2; j <= (thickness) / 2; j++)
                    {
                        
                        map.SetPixel(x + i, y + j, Color.Black);
                        
                    }
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
            x1 = e.X;
            y1 = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (tick < tick1) 
                {
                    tick = tick1;
                    x2 = e.X;
                    y2 = e.Y;
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
