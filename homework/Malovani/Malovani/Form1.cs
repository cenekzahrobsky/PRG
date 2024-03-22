using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Malovani
{
    public partial class Form1 : Form
    {
        private PaintCanvas paintCanvas;
        
        public Form1()
        {
            InitializeComponent();
            InitializePaint();
        }
        private void InitializePaint()
        {
            paintCanvas = new PaintCanvas(paintBox);
            paintCanvas.Clear();
        }

        private void paintBox_MouseDown(object sender, MouseEventArgs e)
        {
            paintCanvas.paintBox_MouseDown(sender, e);
        }

        private void paintBox_MouseMove(object sender, MouseEventArgs e)
        {
            paintCanvas.paintBox_MouseMove(sender, e);
        }

        private void paintBox_MouseUp(object sender, MouseEventArgs e)
        {
            paintCanvas.paintBox_MouseUp(sender, e);
        }

        private void buttonColor_Click_1(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                paintCanvas.SetColor(colorDialog.Color);
            }
        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            paintCanvas.Clear();
        }

        private void buttonFreehand_Click_1(object sender, EventArgs e)
        {
            paintCanvas.SetDrawMode(DrawMode.Freehand);
        }

        private void buttonRectangle_Click_1(object sender, EventArgs e)
        {
            paintCanvas.SetDrawMode(DrawMode.Rectangle);
        }

        private void buttonEllipse_Click_1(object sender, EventArgs e)
        {
            paintCanvas.SetDrawMode(DrawMode.Ellipse);
        }

        private void buttonEraser_Click_1(object sender, EventArgs e)
        {
            paintCanvas.SetDrawMode(DrawMode.Eraser);
        }

        private void trackBarThickness_Scroll_1(object sender, EventArgs e)
        {
            paintCanvas.SetThickness(trackBarThickness.Value*5);
        }
    }

    enum DrawMode
    {
        Freehand,
        Rectangle,
        Ellipse,
        Eraser,
    }
}
