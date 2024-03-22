using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Malovani
{
    internal class PaintCanvas
    {
        private PictureBox paintBox;
        private Graphics graphics;
        private Pen pen;
        private Brush brush;
        private DrawMode drawMode = DrawMode.Freehand;
        private Point firstPoint;
        private Point lastPoint;
        private Rectangle rectangle;
        public bool isDrawing;
        
        public PaintCanvas(PictureBox paintBox)
        {
            this.paintBox = paintBox;
            this.graphics = paintBox.CreateGraphics();
            this.pen = new Pen(Color.Black, 2);
            this.brush = new SolidBrush(Color.Black);
            this.firstPoint = Point.Empty;
            this.lastPoint = Point.Empty;
            this.rectangle = Rectangle.Empty;
            this.isDrawing = false;
        }

        public void paintBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            firstPoint = e.Location;
            lastPoint = e.Location; 
        }

        public void paintBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                switch (drawMode)
                {
                    case DrawMode.Freehand:
                        graphics.DrawLine(pen, lastPoint, e.Location);
                        DrawFilledEllipse(e.Location, pen.Width);
                        lastPoint = e.Location;
                        break;
                    case DrawMode.Rectangle:
                        rectangle = new Rectangle(firstPoint.X, firstPoint.Y, e.X - firstPoint.X, e.Y - firstPoint.Y);
                        paintBox.Refresh();
                        break;
                    case DrawMode.Ellipse:
                        rectangle = new Rectangle(firstPoint.X, firstPoint.Y, e.X - firstPoint.X, e.Y - firstPoint.Y);
                        paintBox.Refresh();
                        break;
                    case DrawMode.Eraser:
                        pen.Color = paintBox.BackColor;
                        lastPoint = e.Location;
                        break;
                }
            }
        }

        public void paintBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isDrawing = false;
                if (drawMode == DrawMode.Rectangle || drawMode == DrawMode.Ellipse)
                {
                    using (Graphics g = Graphics.FromImage(paintBox.Image))
                    {
                        if (drawMode == DrawMode.Rectangle)
                            g.DrawRectangle(pen, rectangle);
                        else if (drawMode == DrawMode.Ellipse)
                            g.DrawEllipse(pen, rectangle);
                    }
                    paintBox.Refresh();
                }
            }
        }

        private void DrawFilledEllipse(Point location, float size)
        {
            float halfSize = size / 2f;
            RectangleF rect = new RectangleF(location.X - halfSize, location.Y - halfSize, size, size);
            graphics.FillEllipse(new SolidBrush(pen.Color), rect);
        }

        public void SetColor(Color color)
        {
            pen.Color = color;
        }

        public void SetThickness(int thickness)
        {
            pen.Width = thickness;
        }

        public void SetDrawMode(DrawMode mode)
        {
            drawMode = mode;
        }

        public void Clear()
        {
            graphics.Clear(paintBox.BackColor);
            paintBox.Image = new Bitmap(paintBox.Width, paintBox.Height);
        }
    }
}

