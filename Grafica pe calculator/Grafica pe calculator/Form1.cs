using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafica_pe_calculator
{
    public partial class Form1 : Form
    {

        public PointF Point1, Point2, Point3;
        int Tricount = 0;
        long a = 0, b = 0;
        static public PictureBox canvas;
        public Form1()
        {
            InitializeComponent();
        }
        public static Timer aux = new Timer();
        private void Form1_Load(object sender, EventArgs e)
        {

            aux.Interval = 17;
            aux.Tick += Aux_Tick;
            canvas = pictureBox1;
            comboBox1.Items.AddRange(Enum.GetNames(typeof(Shape)));
            comboBox1.SelectedIndex = 0;

        }

        private void Aux_Tick(object sender, EventArgs e)
        {
            a++;
        }

        private void borderColorButton_Click(object sender, EventArgs e)
        {

        }


        private void rotationTrackBar_ValueChanged(object sender, EventArgs e)
        {
            GraphicsEngine.Rotate(((rotationTrackBar.Value / (float)rotationTrackBar.Maximum) * 360f));

        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            GraphicsEngine.Scale((float)Math.Pow(trackBar2.Value /(double)((trackBar2.Minimum+trackBar2.Maximum)/2), 2));

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((Shape)comboBox1.SelectedIndex != Shape.Triangle)
            {
                if (e.Button == MouseButtons.Left && a > b)
                {
                    b = a;

                    Point2 = new Point(e.X, e.Y);
                    GraphicsEngine.Draw((Shape)comboBox1.SelectedIndex, Point1, Point2);
                }
            }


        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            aux.Start();
            rotationTrackBar.Value = 0;
            trackBar2.Value = (trackBar2.Minimum + trackBar2.Maximum) / 2;
            if ((Shape)comboBox1.SelectedIndex != Shape.Triangle)
            {
                Point1 = new PointF(e.X, e.Y);
            }
            else
            {
                Tricount++;
                switch (Tricount)
                {
                    case 1:
                        Point1 = new PointF(e.X, e.Y);
                        PointF[] aux = { Point1 };
                        GraphicsEngine.DrawTriangle(aux);
                        break;
                    case 2:
                        Point2 = new PointF(e.X, e.Y);
                        PointF[] aux1 = { Point1, Point2 };
                        GraphicsEngine.DrawTriangle(aux1);
                        break;
                    case 3:
                        Point3 = new PointF(e.X, e.Y);
                        PointF[] aux2 = { Point1, Point2, Point3 };
                        GraphicsEngine.DrawTriangle(aux2);
                        Tricount = 0;
                        break;
                    default:
                        break;
                }
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            aux.Stop();
            if ((Shape)comboBox1.SelectedIndex != Shape.Triangle)
            {
                Point2 = new Point(e.X, e.Y);
                GraphicsEngine.Draw((Shape)comboBox1.SelectedIndex, Point1, Point2);
                Point1 = new PointF();
            }
        }
    }
}
