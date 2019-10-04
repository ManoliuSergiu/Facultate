﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        int[,] mat;
        Timer aux;
        int n;
        int a = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = int.Parse(textBox1.Text);
            Init();
        }

        private void Init()
        {
            mat = new int[n + 2, n + 2];
            mat[(n + 2) / 2, (n + 2) / 2] = 1;
            mat[(n + 2) / 2 + 1, (n + 2) / 2 + 1] = 1;
            mat[(n + 2) / 2 - 1, (n + 2) / 2 - 1] = 1;
            mat[(n + 2) / 2 - 1, (n + 2) / 2 + 1] = 1;
            mat[(n + 2) / 2 + 1, (n + 2) / 2 - 1] = 1;
            pictureBox1.Image = Draw();
        }

        private Bitmap Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gpx = Graphics.FromImage(bmp);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    gpx.FillRectangle(((mat[i + 1, j + 1] == 0) ? Brushes.White : Brushes.Black), j * pictureBox1.Width / n + 0.5f, i * pictureBox1.Height / n + 0.5f, pictureBox1.Width / n, pictureBox1.Height / n);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    gpx.DrawLine(Pens.Black, 0, j * pictureBox1.Width / n, pictureBox1.Height, j * pictureBox1.Width / n);
                }
                gpx.DrawLine(Pens.Black, i * pictureBox1.Height / n, 0, i * pictureBox1.Height / n, pictureBox1.Width);
            }
            gpx.DrawLine(Pens.Black, 0, pictureBox1.Width - 1, pictureBox1.Height, pictureBox1.Width - 1);
            gpx.DrawLine(Pens.Black, pictureBox1.Height - 1, 0, pictureBox1.Height - 1, pictureBox1.Width);

            return bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aux = new Timer();
            aux.Interval = 100;
            aux.Tick += Aux_Tick;
            aux.Start();
            a = 0;
        }

        private void Aux_Tick(object sender, EventArgs e)
        {
            MakeSteps();
            a++;
            if (a == int.Parse(textBox2.Text))
            {
                aux.Stop();
            }
        }

        private void MakeSteps()
        {
            int[,] tmp = new int[n + 2, n + 2];
            for (int i = 0; i < n + 2; i++)
            {
                for (int j = 0; j < n + 2; j++)
                {
                    tmp[i, j] = mat[i, j];
                    if (i > 0 && i < n + 1 && j > 0 && j < n + 1)
                    {
                        int aux = mat[i - 1, j] + mat[i + 1, j] + mat[i, j - 1] + mat[i, j + 1];
                        tmp[i, j] = (aux % 2 == 0) ? 0 : 1;
                    }
                }
            }
            mat = tmp;
            pictureBox1.Image = Draw();
                
            
        }
    }
}