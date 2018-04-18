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
        private Graphics graphics;
//        private int x = 150;
//        private int y = 100;
//        private int dx = 3;
//        private int dy = 2;
        private List<Ball> balls = new List<Ball>();
        private List<Image> catImages = new List<Image>();
        private int k = 0;



        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(PaintBall);
            this.MouseWheel += new MouseEventHandler(Form1_MouseWheel);
            this.DoubleBuffered = true;
            this.SetStyle(
                ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer,
                true);
            
            catImages.Add(Properties.Resources.frame_0);
            catImages.Add(Properties.Resources.frame_1);
            catImages.Add(Properties.Resources.frame_2);
            catImages.Add(Properties.Resources.frame_3);
            catImages.Add(Properties.Resources.frame_4);
            catImages.Add(Properties.Resources.frame_5);
            catImages.Add(Properties.Resources.frame_6);
            catImages.Add(Properties.Resources.frame_7);
            catBox.Enabled = false;
            catBox.Hide();
        }
        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (timer1.Interval + (e.Delta / 40) > 0)
                timer1.Interval += e.Delta / 40;
        }

        private void PaintBall(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            foreach (Ball ball in balls)
            {
                SolidBrush BallBrush = new SolidBrush(ball.color);
                graphics.FillEllipse(BallBrush, ball.X, ball.Y, ball.Width, ball.Height);
                BallBrush.Dispose();
            }

        }

        private void MoveBall()
        {
            foreach (Ball ball in balls)
            {

                if (ball.X < -5 || ball.X > this.ClientSize.Width - ball.Width)
                {
                    ball.Dx = -ball.Dx;
                    ball.ChangeColor();
                }

                if (ball.Y < 0 || ball.Y > this.ClientSize.Height - ball.Height)
                {
                    ball.Dy = -ball.Dy;
                    ball.ChangeColor();
                }

                ball.X += ball.Dx;
                ball.Y += ball.Dy;
            }

            if (catBox.Enabled == true)
            {
                if (k == 7) k = 0;
                catBox.Image = catImages[k];
                k++;
                catBox.Location = new Point(catBox.Location.X + 1, catBox.Location.Y);
                if (catBox.Location.X > this.ClientSize.Width)
                    catBox.Location = new Point(0, catBox.Location.Y);
                if (catBox.Location.Y > this.ClientSize.Height)
                    catBox.Location = new Point(catBox.Location.X, 0);

            }
            Invalidate();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveBall();

        }

        private void Form1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Random rand = new Random();
            int ran = rand.Next(50, 150);
            balls.Add(new Ball(e.Location.X, e.Location.Y, ran, ran));
        }

        private void catBox_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                catBox.Enabled = true;
                catBox.Show();
            }

            if (e.KeyCode == Keys.Up)
            {
                catBox.Location = new Point(catBox.Location.X, catBox.Location.Y + 5);
            }
            if (e.KeyCode == Keys.Down)
            {
                catBox.Location = new Point(catBox.Location.X, catBox.Location.Y - 5);
            }
        }
    }
}
