using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DM
{
    public partial class MainForm : Form
    {
        private List<Point> Points;
        private List<Point> panelClickPoints;
        private readonly int WIDTH;
        private readonly int HEIGHT;
        private Random rnd = new Random();

        public MainForm()
        {
            InitializeComponent();
            Points = new List<Point>();
            panelClickPoints = new List<Point>();
            WIDTH = this.drawingPanel.Width;
            HEIGHT = this.drawingPanel.Height;
        }

        private void generateRandom_Click(object sender, EventArgs e)
        {
            if (this.drawCurve.Checked) {
                generateArroundLine();
            }
            else
            {
                generateClusters();
            }
        }

        private void generateArroundLine()
        {
            try
            {
                int inputs = int.Parse(this.countInput.Text);
                int distance = int.Parse(this.distanceInput.Text);

                for (int i = 0; i < inputs; i++ )
                {
                    int randomLine = rnd.Next(0, panelClickPoints.Count-1);
                    Point startPoint = panelClickPoints[randomLine];
                    Point endPoint = panelClickPoints[randomLine + 1];
                    Point temp;

                    if (startPoint.X > endPoint.X) {
                        temp = startPoint;
                        startPoint = endPoint;
                        endPoint = temp;
                    }

                    double slope = (1.0*(startPoint.Y - endPoint.Y))/(1.0*(startPoint.X - endPoint.X));
                    double offset = startPoint.Y - slope * startPoint.X;

                    Point p = new Point();
                    p.X = rnd.Next(startPoint.X, endPoint.X);
                    p.Y = (int)(slope * p.X + offset);

                    int distortX = rnd.Next(-1 * distance, distance);
                    int distortY = rnd.Next(-1 * distance, distance);
                    p.X += distortX;
                    p.Y += distortY;

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

        private void generateClusters()
        {
            try
            {
                int inputs = int.Parse(this.countInput.Text);
                int kernelsCount = int.Parse(this.kernelsInput.Text);
                int distance = int.Parse(this.distanceInput.Text);

                Point[] kernels = new Point[kernelsCount];

                for (int i = 0; i < kernelsCount; i++)
                {
                    kernels[i].X = rnd.Next(distance, WIDTH - distance);
                    kernels[i].Y = rnd.Next(distance, HEIGHT - distance);
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

        private void addNoise()
        {
            if (this.addNoiseCheckbox.Checked)
            {
                int inputs = int.Parse(this.countInput.Text);
                double noiseFactorVal = double.Parse(this.noiseFactor.Text);
                for (int i = 0; i < inputs * noiseFactorVal; i++)
                {
                    int x = rnd.Next(0, WIDTH);
                    int y = rnd.Next(0, HEIGHT);
                    Points.Add(new Point(x, y));
                }
            }
        }

        private void drawPoints()
        {
            this.addNoise();
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
            panelClickPoints.Clear();
            this.drawingPanel.Refresh();
        }

        private int findClassForPoint(Point p, Point[] kernels)
        {
            double minDistanceFound = double.MaxValue;
            int ptClass = -1;
            for (int i = 0; i < kernels.Length; i++)
            {
                Point kernel = kernels[i];
                double distance = Math.Sqrt(Math.Pow(p.X - kernel.X, 2) + Math.Pow(p.Y - kernel.Y, 2));
                if (distance < minDistanceFound)
                {
                    minDistanceFound = distance;
                    ptClass = i;
                }
            }

            return ptClass;
        }

        private void drawingPanel_click(object sender, EventArgs e)
        {
            if (this.drawCurve.Checked) {
                Point point = this.drawingPanel.PointToClient(Cursor.Position);
                panelClickPoints.Add(point);
            }
            
        }

        private void drawLine_Click(object sender, EventArgs e)
        {
            Graphics g = this.drawingPanel.CreateGraphics();
            Pen p = new Pen(Color.Black);
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 12);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            p.Width = 2;
            for (int i = 0; i < panelClickPoints.Count - 1; i++)
            {
                Point p1 = panelClickPoints[i];
                Point p2 = panelClickPoints[i + 1];
                g.DrawLine(p, p1, p2);
                g.DrawString("(" + i + "," + p1.X + "," + p1.Y + ")", drawFont, drawBrush, p1);
            }
        }

        private void updateMetrics(string algName, int totalTime, int clustersCount)
        {
            this.algoNameLabel.Text = algName;
            this.clustersFoundLabel.Text = clustersCount.ToString();
            this.totalTimeLabel.Text = totalTime.ToString() + "Milliseconds";
        }

        private void applyAlgorithm_Click(object sender, EventArgs e)
        {
            if (this.kMeansRadio.Checked)
            {
                applyKMeans();
            }

            if (this.netClusteringRadio.Checked)
            {
                applyNetBasedClustering();
            }

            if (this.dbScanRadio.Checked)
            {
                applyDBSCAN();
            }
        }

        private void applyKMeans()
        {
            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                int inputs = int.Parse(this.countInput.Text);
                int kernelsCount = int.Parse(kMeansKernelInput.Text);
                int iterations = int.Parse(this.kMeansInterationsInput.Text);
                Graphics g = this.drawingPanel.CreateGraphics();
                Point[] kernels = new Point[kernelsCount];
                List<List<Point>> kernelClasses = new List<List<Point>>();


                for (int i = 0; i < kernels.Length; i++)
                {
                    kernels[i].X = rnd.Next(WIDTH);
                    kernels[i].Y = rnd.Next(HEIGHT);
                    kernelClasses.Add(new List<Point>());
                }


                g.Clear(Color.White);

                for (int i = 0; i < iterations; i++)
                {
                    /* Разпределяме всяка точка към най-близкият и kernel */
                    for (int j = 0; j < Points.Count; j++)
                    {
                        Point p = Points[j];
                        int cls = findClassForPoint(p, kernels);
                        kernelClasses[cls].Add(p);
                    }

                    /* Преизчисления на центровете на класовете */
                    for (int j = 0; j < kernels.Length; j++)
                    {
                        long sumX = 0;
                        long sumY = 0;
                        for (int k = 0; k < kernelClasses[j].Count; k++)
                        {
                            sumX += kernelClasses[j][k].X;
                            sumY += kernelClasses[j][k].Y;
                        }

                        if (kernelClasses[j].Count == 0)
                        {
                            continue;
                        }

                        sumX = sumX / kernelClasses[j].Count;
                        sumY = sumY / kernelClasses[j].Count;
                        kernels[j].X = (int)sumX;
                        kernels[j].Y = (int)sumY;

                        if (i != iterations - 1)
                        {
                            kernelClasses[j].Clear();
                        }
                    }
                }

                stopWatch.Stop();
                updateMetrics("KMeans", (int)stopWatch.ElapsedMilliseconds, kernelsCount);

                /* Рисуване на шитнята */
                for (int i = 0; i < kernelClasses.Count; i++)
                {
                    Pen pen = new Pen(Color.FromArgb(rnd.Next(40, 200), rnd.Next(0, 200), rnd.Next(0, 255)));
                    pen.Width = 2;
                    List<Point> kernelClass = kernelClasses[i];
                    for (int j = 0; j < kernelClass.Count; j++)
                    {
                        Point p = kernelClass[j];
                        g.DrawEllipse(pen, p.X, p.Y, 2, 2);
                    }

                    Pen centroidPen = new Pen(Color.Red);
                    centroidPen.Width = 6;
                    g.DrawRectangle(centroidPen, kernels[i].X, kernels[i].Y, 3, 3);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Invalid input in text fields, wrong parsing.");
            }
        }

        private void applyNetBasedClustering()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            int cellThreshold = int.Parse(this.cellThresholdInput.Text);
            int cellCount = int.Parse(this.cellCountInput.Text);
            double cellSizeX = WIDTH / cellCount;
            double cellSizeY = HEIGHT / cellCount;

            bool[,] binaryMatrix = new bool[cellCount, cellCount];

            for (int i = 0; i < cellCount; i++)
            {
                for (int j = 0; j < cellCount; j++)
                {
                    double fromX, toX,
                        fromY, toY;

                    int pointsInCell = 0;

                    fromX = i * cellSizeX;
                    toX = (i + 1) * cellSizeX;
                    fromY = j * cellSizeY;
                    toY = (j + 1) * cellSizeY;

                    /* Намира броя на точки в клетката */
                    for (int k = 0; k < Points.Count; k++)
                    {
                        Point p = Points[k];
                        if (p.X > fromX && p.X < toX && p.Y > fromY && p.Y < toY)
                        {
                            pointsInCell++;
                        }
                    }

                    if (pointsInCell >= cellThreshold)
                    {
                        binaryMatrix[i, j] = true;
                    }
                }
            }

            stopWatch.Stop();
            updateMetrics("Net Based", (int)stopWatch.ElapsedMilliseconds, 1);

            Graphics g = drawingPanel.CreateGraphics();
            g.Clear(Color.White);

            /* Рисуване */
            for (int i = 0; i < binaryMatrix.GetLength(0); i++ )
            {
                for (int j = 0; j < binaryMatrix.GetLength(1); j++)
                {
                    double fromX, fromY;
                    fromX = i * cellSizeX;
                    fromY = j * cellSizeY;

                    SolidBrush b = new SolidBrush(Color.Teal);
              
                    if (binaryMatrix[i,j]) {
                        g.FillRectangle(b, (int)fromX, (int)fromY, (int)cellSizeX, (int)cellSizeY);
                    }
                }
            }

            for (int i = 0; i < Points.Count; i++)
            {
                Point p = Points[i];
                g.DrawEllipse(System.Drawing.Pens.Black, p.X, p.Y, 1, 1);
            }

        }

        private void applyDBSCAN()
        {
            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                List<List<Point>> clusters = new List<List<Point>>();
                int dist = int.Parse(this.dbScanMinDist.Text);
                int minPts = int.Parse(this.dbScanMinPts.Text);

                bool[] visited = new bool[Points.Count];
                bool[] noise = new bool[Points.Count];

                for (int i = 0; i < Points.Count; i++)
                {
                    if (visited[i])
                    {
                        continue;
                    }
                    visited[i] = true;
                    List<Point> neighbours = getNeighbours(Points[i], dist);
                    if (neighbours.Count < minPts)
                    {
                        noise[i] = true;
                    }
                    else
                    {
                        List<Point> cluster = new List<Point>();
                        clusters.Add(cluster);
                        expandCluster(clusters, cluster, Points[i], neighbours, dist, minPts, visited, noise);
                    }
                }

                stopWatch.Stop();
                updateMetrics("DBSCAN", (int)stopWatch.ElapsedMilliseconds, clusters.Count);

                /* Рисуване */
                Graphics g = drawingPanel.CreateGraphics();
                g.Clear(Color.White);
                for (int i = 0; i < clusters.Count; i++)
                {
                    Pen pen = new Pen(Color.FromArgb(rnd.Next(40, 200), rnd.Next(0, 200), rnd.Next(0, 255)));
                    pen.Width = 2;
                    List<Point> cluster = clusters[i];
                    for (int j = 0; j < cluster.Count; j++)
                    {
                        g.DrawEllipse(pen, cluster[j].X, cluster[j].Y, dist, dist);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error in parsing arguments");
            }
        }

        private void expandCluster(List<List<Point>> clusters, List<Point> cluster, Point p, 
            List<Point> neighbours,int dist, int minPts,
            bool[] visited, bool[] noise)
        {
            cluster.Add(p);
            for (int i = 0; i < neighbours.Count; i++ )
            {
                int index = Points.FindIndex(x => x == neighbours[i]);
                if (!visited[index])
                {
                    visited[index] = true;
                    List<Point> innerNeighbours = getNeighbours(neighbours[i], dist);
                    if (innerNeighbours.Count >= minPts) {
                        neighbours.AddRange(innerNeighbours);
                    }
                }
                if (!isInCluster(neighbours[i], clusters)) {
                    cluster.Add(neighbours[i]);
                }
            }
        }

        private bool isInCluster(Point p, List<List<Point>> clusters)
        {
            for (int i = 0; i < clusters.Count; i++ )
            {
                List<Point> cluster = clusters[i];
                for (int j = 0; j < cluster.Count; j++ )
                {
                    if (cluster.Contains(p))
                        return true;
                }
            }
            return false;
        }

        private List<Point> getNeighbours(Point p1, int thresh)
        {
            List<Point> pts = new List<Point>();
            for (int i = 0; i < Points.Count; i++ )
            {
                Point p2 = Points[i];
                double dist = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y,2));
                if (dist < thresh) {
                    pts.Add(p2);
                }
            }
            return pts;
        }

    }
}
