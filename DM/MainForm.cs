using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DM
{
    public partial class MainForm : Form
    {
        private List<Point> Points;
        private readonly int WIDTH;
        private readonly int HEIGHT;

        public MainForm()
        {
            InitializeComponent();
            Points = new List<Point>();
            WIDTH = this.drawingPanel.Width;
            HEIGHT = this.drawingPanel.Height;
        }

        private void DrawIt()
        {
            System.Drawing.Graphics graphics = this.drawingPanel.CreateGraphics();
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(
                50, 100, 150, 150);
            graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle);
            graphics.DrawRectangle(System.Drawing.Pens.Red, rectangle);
        }

        private void generateRandom_Click(object sender, EventArgs e)
        {
            try {
                int inputs = int.Parse(this.countInput.Text);
                int kernelsCount = int.Parse(this.kernelsInput.Text);
                int distance = int.Parse(this.distanceInput.Text);

                Random rnd = new Random();
                Point[] kernels = new Point[kernelsCount];

                for (int i = 0 ; i < kernelsCount; i++) {
                    kernels[i].X = rnd.Next(WIDTH);
                    kernels[i].Y = rnd.Next(HEIGHT);
                }

                for (int i = 0; i < inputs; i++)
                {
                    
                    int kernelIdx = rnd.Next(kernelsCount);
                    Point p = new Point();
                    p.X = rnd.Next(-1 * distance, distance) + kernels[kernelIdx].X + rnd.Next(-30, 30);
                    p.Y = rnd.Next(-1 * distance, distance) + kernels[kernelIdx].Y + rnd.Next(-30, 30);
                    Points.Add(p);
                }
                
                drawPoints();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while parsing text");
                return;
            }
        }

        private void drawPoints()
        {
            this.drawingPanel.Refresh();
        }

        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < Points.Count; i++)
            {
                Point p = Points[i];
                g.DrawEllipse(System.Drawing.Pens.Black, p.X, p.Y, 1, 1);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Points.Clear();
            this.drawingPanel.Refresh();
        }
    }
}
