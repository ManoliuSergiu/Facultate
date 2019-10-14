using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafica_pe_calculator
{
    
    public enum Shape
    {
        Line,
        Triangle,
        Square,
        Rectangle,
        Circle,
        Elipse
    }
    static class GraphicsEngine
    {
        static Shape currentShape;
        static float angle=0f;
        static float scale=1f;
        static PointF p1, p2;
        static PointF[] triPoints;
        internal static void Draw(Shape selectedShape, PointF point1, PointF point2)
        {
            currentShape = selectedShape;
            Bitmap image = new Bitmap(600, 600);
            Graphics gfx = Graphics.FromImage(image);
            p1 = point1;
            p2 = point2;
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            AuxiliarryDraw(selectedShape, point1, point2, gfx);
            Form1.canvas.BackgroundImage = image;
        }

        private static void AuxiliarryDraw(Shape selectedShape, PointF point1, PointF point2, Graphics gfx)
        {
            float dx = (point1.X + point2.X) / 2f;
            float dy = (point1.Y + point2.Y) / 2f;
            gfx.TranslateTransform(dx, dy);
            gfx.RotateTransform(angle);
            gfx.ScaleTransform(scale, scale);
            gfx.TranslateTransform(-dx, -dy);
            switch (selectedShape)
            {
                case Shape.Line:
                    gfx.DrawLine(new Pen(Color.Black, 1), point1, point2);
                    break;
                case Shape.Triangle:
                    break;
                case Shape.Square:
                    float lengths = Math.Min(Math.Abs(point2.X - point1.X), Math.Abs(point2.Y - point1.Y));
                    float xs = (point1.X < point2.X) ? point1.X : point1.X - lengths;
                    float ys = (point1.Y < point2.Y) ? point1.Y : point1.Y - lengths;
                    gfx.DrawRectangle(new Pen(Color.Black, 1), xs, ys, lengths, lengths);
                    break;
                case Shape.Rectangle:
                    gfx.DrawRectangle(new Pen(Color.Black, 1), Math.Min(point1.X, point2.X), Math.Min(point1.Y, point2.Y), Math.Abs(point2.X - point1.X), Math.Abs(point2.Y - point1.Y));
                    break;
                case Shape.Circle:
                    float lengthc = Math.Min(Math.Abs(point2.X - point1.X), Math.Abs(point2.Y - point1.Y));
                    float xc = (point1.X < point2.X) ? point1.X : point1.X - lengthc;
                    float yc = (point1.Y < point2.Y) ? point1.Y : point1.Y - lengthc;
                    gfx.DrawEllipse(new Pen(Color.Black, 1), xc, yc, lengthc, lengthc);
                    break;
                case Shape.Elipse:
                    gfx.DrawEllipse(new Pen(Color.Black, 1), Math.Min(point1.X, point2.X), Math.Min(point1.Y, point2.Y), Math.Abs(point2.X - point1.X), Math.Abs(point2.Y - point1.Y));
                    break;
                default:
                    break;
            }
            

        }

        internal static void Scale(float v)
        {
            scale = v;
            if (currentShape!= Shape.Triangle)
            {
                Draw(currentShape, p1, p2);
            }
            else
            {
                DrawTriangle(triPoints);
            }
        }

        public static void Rotate(float v)
        {

            angle = v;
            if (currentShape != Shape.Triangle)
            {
                Draw(currentShape, p1, p2);
            }
            else
            {
                DrawTriangle(triPoints);
            }

        }

        internal static void DrawTriangle(PointF[] pointS)
        {
            currentShape = Shape.Triangle;
            triPoints = pointS;
            Bitmap image = new Bitmap(600, 600);
            Graphics gfx = Graphics.FromImage(image);
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            if (pointS.Length > 1)
            {
                float dx, dy;
                if (pointS.Length==3)
                {
                    dx = (pointS[0].X + pointS[1].X + pointS[2].X) / 3f;
                    dy = (pointS[0].Y + pointS[1].Y + pointS[2].Y) / 3f;
                    gfx.TranslateTransform(dx, dy);
                    gfx.RotateTransform(angle);
                    gfx.ScaleTransform(scale, scale);
                    gfx.TranslateTransform(-dx, -dy);
                }
                
                gfx.DrawPolygon(Pens.Black, pointS);
            }
            Form1.canvas.BackgroundImage = image;

        }
    }
}
