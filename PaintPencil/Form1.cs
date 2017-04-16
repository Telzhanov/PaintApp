using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintPencil
{
    public partial class Form1 : Form
    {
       
        Color originColor;
        Color fillColor;
        Color prevColor = Color.Red;
        Point prevPoint;
        Point currentPoint;
        Shapes currentShape = Shapes.Free;
        GraphicsPath gp = new GraphicsPath();
        Graphics g;
        Bitmap bmp;
        float W, H;
        int size=1;
        Queue<Point> q = new Queue<Point>();
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(pictureBox1.Image);
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            prevPoint = e.Location;
            switch (currentShape)
            {
                case Shapes.Free:
                    
                    break;
                case Shapes.Line:
                    
                    break;
                case Shapes.Ellipse:
                   
                    break;
                case Shapes.Rectangle:
                  
                    break;
                case Shapes.Triangle:
                   
                    break;
                case Shapes.FloodFill:
                    Pen p = new Pen(prevColor);
                    originColor = bmp.GetPixel(e.X, e.Y);
                    fillColor = p.Color;
                    F1(e.Location);
                    break;
                default:
                    break;
            }
        }

        private void F1(Point point)
        {
            q.Enqueue(point);
            GoFloodFill();
        }

        private void GoFloodFill()
        {
            while (q.Count > 0)
            {
                Point cur = q.Dequeue();

                Step(new Point(cur.X, cur.Y + 1));
                Step(new Point(cur.X + 1, cur.Y));
                Step(new Point(cur.X - 1, cur.Y));
                Step(new Point(cur.X, cur.Y - 1));
            }
            pictureBox1.Refresh();
        }

        private void Step(Point p)
        {
            if (p.X < 0) return;
            if (p.Y < 0) return;
            if (p.X >= pictureBox1.Width) return;
            if (p.Y >= pictureBox1.Height) return;
            if (bmp.GetPixel(p.X, p.Y) != originColor) return;
            bmp.SetPixel(p.X, p.Y, fillColor);
            q.Enqueue(p);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                switch (currentShape)
                {
                    case Shapes.Free:
                        currentPoint = e.Location;
                        g.DrawLine(new Pen(prevColor,size), prevPoint, currentPoint);
                        prevPoint = currentPoint;
                        break;
                    case Shapes.Line:
                        currentPoint = e.Location;
                        gp.Reset();
                        gp.AddLine(prevPoint, currentPoint);
                        break;
                    case Shapes.Ellipse:
                        currentPoint = e.Location;
                        W = Math.Abs(currentPoint.X - prevPoint.X);
                        H = Math.Abs(currentPoint.Y - prevPoint.Y);
                        gp.Reset();
                        gp.AddEllipse(Math.Min(currentPoint.X, prevPoint.X), Math.Min(currentPoint.Y, prevPoint.Y), W, H);
                        break;
                    case Shapes.Rectangle:
                        currentPoint = e.Location;
                        W = Math.Abs(currentPoint.X - prevPoint.X);
                        H = Math.Abs(currentPoint.Y - prevPoint.Y);
                        RectangleF rc = new RectangleF(Math.Min(currentPoint.X, prevPoint.X), Math.Min(currentPoint.Y, prevPoint.Y),W,H);
                        gp.Reset();
                        gp.AddRectangle(rc);
                        break;
                    case Shapes.Triangle:
                        currentPoint = e.Location;
                        W = Math.Abs(currentPoint.X - prevPoint.X);
                        H = Math.Abs(currentPoint.Y - prevPoint.Y);
                        RectangleF rc1 = new RectangleF(Math.Min(currentPoint.X, prevPoint.X), Math.Min(currentPoint.Y, prevPoint.Y), W, H);
                        PointF a = new PointF(rc1.X + rc1.Width / 2, rc1.Y);
                        PointF b = new PointF(rc1.X, rc1.Y + rc1.Height);
                        PointF c = new PointF(rc1.X + rc1.Width, rc1.Y + rc1.Height);
                        gp.Reset();
                        gp.AddPolygon(new PointF[] { a, b, c });
                        break;
                    case Shapes.FloodFill:
                        break;
                    default:
                        break;
                }
            }
            mouseLocationLabel.Text = string.Format("X = {0}; Y = {1}", e.X, e.Y);
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            g.DrawPath(new Pen(prevColor,size), gp);
        }


        private void colorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                prevColor = c.Color;
            }
        }

        private void lineBtn_Click(object sender, EventArgs e)
        {
            currentShape = Shapes.Line;
        }

        private void freeBtn_Click(object sender, EventArgs e)
        {
            currentShape = Shapes.Free;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawPath(new Pen(prevColor,size), gp);
        }

        private void rectanglebtn_Click(object sender, EventArgs e)
        {
            currentShape = Shapes.Rectangle;        
        }

        private void ellipsebtn_Click(object sender, EventArgs e)
        {
            currentShape = Shapes.Ellipse;
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sizetext_ValueChanged(object sender, EventArgs e)
        {
            size = Convert.ToInt32(sizetext.Value);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(sfd.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Images|*.png;*.bmp;*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    //paper.Image = new Bitmap(dlg.FileName);
                    //paper.SizeMode = PictureBoxSizeMode.StretchImage;

                    g.DrawImage(new Bitmap(dlg.FileName), 0, 0);

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentShape = Shapes.FloodFill;
        }
        private void FloodFill(Bitmap bmp, Point pt, Color targetColor, Color replacementColor)
        {
            Stack<Point> pixels = new Stack<Point>();
            targetColor = bmp.GetPixel(pt.X, pt.Y);
            pixels.Push(pt);

            while (pixels.Count > 0)
            {
                Point a = pixels.Pop();
                if (a.X < bmp.Width && a.X > 0 &&
                        a.Y < bmp.Height && a.Y > 0)//make sure we stay within bounds
                {

                    if (bmp.GetPixel(a.X, a.Y) == targetColor)
                    {
                        bmp.SetPixel(a.X, a.Y, replacementColor);
                        pixels.Push(new Point(a.X - 1, a.Y));
                        pixels.Push(new Point(a.X + 1, a.Y));
                        pixels.Push(new Point(a.X, a.Y - 1));
                        pixels.Push(new Point(a.X, a.Y + 1));
                    }
                }
            }
            pictureBox1.Refresh(); //refresh our main picture box
            return;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentShape = Shapes.FloodFill;
        }

        private void trianglebtn_Click(object sender, EventArgs e)
        {
            currentShape = Shapes.Triangle;
        }
    }


    public enum Shapes
    {
        Free,
        Line,
        Ellipse,
        Rectangle,
        Triangle,
        FloodFill
    }
}
