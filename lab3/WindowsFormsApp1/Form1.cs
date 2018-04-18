using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private enum Shape
        {
            Line, Rectangle, Ellipse, Bezier, Eraser, LineToPoint, GColor
        }

        private enum fillMode
        {
            Filled, Unfilled, Gradient
        }

        private Shape currentShape = Shape.Line;
        private fillMode currentFillMode = fillMode.Unfilled;
        Graphics graph;
        Bitmap bm, bb;
        int x = -1;
        int y = -1;
        int eraserWidth = 5;
        private bool moving = false, bezier = false, fillColor = false, delete = false, ltp = false, lpt_dr = false;
        Pen pen;
        Point startPos, currentPos, leftPoint, rightPoint, lastPos = new Point(-10, -10);
        private Color gColor;



        Brush brush;
        List<Point> points = new List<Point>();


        public Form1()
        {
            InitializeComponent();
            InitializeLineWidthComboBox();
            InitializeFigureComboBox();
            graph = panel1.CreateGraphics();
            graph.SmoothingMode = SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 5);
            pen.StartCap = pen.EndCap = LineCap.Round;
        }

        private void InitializeLineWidthComboBox()
        {
            txtLineWidth.Items.Add(2);
            txtLineWidth.Items.Add(4);
            txtLineWidth.Items.Add(8);
            txtLineWidth.Items.Add(16);
            txtLineWidth.Items.Add(32);
            txtLineWidth.Items.Add(64);
        }

        private void InitializeFigureComboBox()
        {
            FillColorBox.Items.Add("Unfilled");
            FillColorBox.Items.Add("Filled");
            FillColorBox.Items.Add("Gradient");
        }


        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog clrDlg = new ColorDialog();
            if (clrDlg.ShowDialog() == DialogResult.OK)
            {
                pen.Color = clrDlg.Color;
                btnColor.BackColor = pen.Color;
            }
        }

        private Rectangle getRectangle()
        {
            return new Rectangle(Math.Min(startPos.X, currentPos.X),
                                 Math.Min(startPos.Y, currentPos.Y),
                                 Math.Abs(startPos.X - currentPos.X),
                                 Math.Abs(startPos.Y - currentPos.Y));
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1)
            {
                if (currentShape == Shape.Line)
                {
                    lastPos = new Point(-10, -10);
                    graph.DrawLine(pen, new Point(x, y), e.Location);
                }

                if (currentShape == Shape.Eraser)
                {
                    pen.Color = panel1.BackColor;
                    graph.DrawLine(pen, new Point(x, y), e.Location);
                    btnColor.BackColor = pen.Color;
                    lastPos = new Point(-10, -10);
                }
                x = e.X;
                y = e.Y;
            }
            currentPos = e.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
            panel1.Cursor = Cursors.Default;
            if (currentFillMode == fillMode.Filled)
                brush = new SolidBrush(pen.Color);
            else if (currentFillMode == fillMode.Gradient)
                brush = new LinearGradientBrush(new Point(startPos.X, startPos.Y),
                    new Point(currentPos.X + 1, currentPos.Y + 1), pen.Color, Color.Aquamarine);

            switch (currentShape)
            {
                case Shape.Rectangle:
                    if (currentFillMode == fillMode.Unfilled)
                        graph.DrawRectangle(pen, getRectangle());
                    else if (currentFillMode == fillMode.Filled || currentFillMode == fillMode.Gradient)
                        graph.FillRectangle(brush, getRectangle());
                    lastPos = new Point(-10, -10);
                    break;

                case Shape.Ellipse:
                    if (currentFillMode == fillMode.Unfilled)
                        graph.DrawEllipse(pen, getRectangle());
                    else if (currentFillMode == fillMode.Filled || currentFillMode == fillMode.Gradient)
                        graph.FillEllipse(brush, getRectangle());
                    lastPos = new Point(-10, -10);

                    break;

                case Shape.Bezier:
                    graph.DrawBeziers(pen, points.ToArray());
                    lastPos = new Point(-10, -10);

                    break;
                case Shape.LineToPoint:
                    if (!(lastPos.X == -10 && lastPos.Y == -10))
                        graph.DrawLine(pen, lastPos, e.Location);
                    lastPos = e.Location;

                    break;
                case Shape.GColor:
                    bb = new Bitmap(panel1.Width, panel1.Height);
                    graph = Graphics.FromImage(bb);
                    Rectangle rect = panel1.RectangleToScreen(panel1.ClientRectangle);
                    graph.CopyFromScreen(rect.Location, Point.Empty, panel1.Size);
                    gColor = bb.GetPixel(e.Location.X,e.Location.Y);
                    pen.Color = gColor;
                    btnColor.BackColor = gColor;
                    bb.Dispose();
                    graph = panel1.CreateGraphics();
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    break;
            }
        }

        float zoom = 1;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Oemplus)
                zoom = 2f;

            if (e.KeyCode == Keys.OemMinus)
                zoom = 0.5f;

            panel1.Scale(zoom);
            graph.ScaleTransform(zoom, zoom);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter =
                "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf";
            if (save.ShowDialog() == DialogResult.OK)
            {
                bm = new Bitmap(panel1.Width, panel1.Height);
                graph = Graphics.FromImage(bm);
                Rectangle rect = panel1.RectangleToScreen(panel1.ClientRectangle);
                graph.CopyFromScreen(rect.Location, Point.Empty, panel1.Size);
                bm.Save(save.FileName);

                bm.Dispose();

                graph = panel1.CreateGraphics();
                graph.SmoothingMode = SmoothingMode.AntiAlias;
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentShape = Shape.Line;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentShape = Shape.Rectangle;
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Scale(2);
            graph.ScaleTransform(2, 2);

        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Scale((float)0.5);
            graph.ScaleTransform((float)0.5, (float)0.5);
        }

        private void GetColorBtn_Click(object sender, EventArgs e)
        {
            currentShape = Shape.GColor;
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backgroundBtn_Click(object sender, EventArgs e)
        {
            ColorDialog clrDlg = new ColorDialog();
            if (clrDlg.ShowDialog() == DialogResult.OK)
            {
                pen.Color = clrDlg.Color;
                backgroundBtn.BackColor = pen.Color;
                panel1.BackColor = pen.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentShape = Shape.Ellipse;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentShape = Shape.Bezier;
            bezier = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentShape = Shape.LineToPoint;
        }

        private void EraserBtn_Click(object sender, EventArgs e)
        {
            currentShape = Shape.Eraser;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
            panel1.Cursor = Cursors.Cross;
            startPos = e.Location;
            if (bezier)
            {
                if (points.Count == 4)
                    points.Clear();
                points.Add(e.Location);
            }
        }

        private void FillColorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (FillColorBox.GetItemText(FillColorBox.SelectedItem))
            {
                case "Filled":
                    currentFillMode = fillMode.Filled;
                    break;

                case "Unfilled":
                    currentFillMode = fillMode.Unfilled;
                    break;

                case "Gradient":
                    currentFillMode = fillMode.Gradient;
                    break;
            }

        }
        private void txtLineWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int width = 0;

            Int32.TryParse(txtLineWidth.GetItemText(txtLineWidth.SelectedItem), out width);
            pen.Width = width;
            eraserWidth = width;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
