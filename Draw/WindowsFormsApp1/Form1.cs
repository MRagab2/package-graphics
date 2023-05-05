using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private DataTable _pointsTable;

        public Form1()
        {
            InitializeComponent();
            
        }


        private Bitmap DDA(Point p1, Point p2)
        {
            int dx = p2.X - p1.X;
            int dy = p2.Y - p1.Y;
            float xIncrement, yIncrement, x = p1.X, y = p1.Y;
            int k, steps;
            Bitmap pic = new Bitmap(this.Width, this.Height);
            _pointsTable = new DataTable();
            _pointsTable.Columns.Add("X", typeof(int));
            _pointsTable.Columns.Add("Y", typeof(int));

            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);

            xIncrement = (float)dx / (float)steps;
            yIncrement = (float)dy / (float)steps;

            pic.SetPixel((int)Math.Round(x), (int)Math.Round(y), Color.Blue);
            _pointsTable.Rows.Add((int)Math.Round(x) - 265, (int)Math.Round(y) * -1 +160); // Add the starting point

            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                y += yIncrement;
                pic.SetPixel((int)Math.Round(x), (int)Math.Round(y), Color.Blue);
                _pointsTable.Rows.Add((int)Math.Round(x)-265, (int)Math.Round(y)*-1+160); // Add each intermediate point
            }
            dataGridView1.DataSource = _pointsTable;
            return pic;

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(inputLineX1.Text) + 265;
            int y1 = Convert.ToInt32(inputLineY1.Text) * -1 + 160;

            int x2 = Convert.ToInt32(inputLineX2.Text) + 265;
            int y2 = Convert.ToInt32(inputLineY2.Text) * -1 + 160;

            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);

            Bitmap pic =  DDA(p1, p2);
            pictureBox1.Image = pic;

        }


        private void Bresenham(Point p1, Point p2, Bitmap bmp, Color color)
        {
            int x1 = p1.X;
            int y1 = p1.Y;
            int x2 = p2.X;
            int y2 = p2.Y;

            bool steep = Math.Abs(y2 - y1) > Math.Abs(x2 - x1);

            if (steep)
            {
                Swap(ref x1, ref y1);
                Swap(ref x2, ref y2);
            }

            if (x1 > x2)
            {
                Swap(ref x1, ref x2);
                Swap(ref y1, ref y2);
            }

            int dx = x2 - x1;
            int dy = Math.Abs(y2 - y1);
            int error = dx / 2;
            int ystep = (y1 < y2) ? 1 : -1;
            int y = y1;

            for (int x = x1; x <= x2; x++)
            {
                bmp.SetPixel((steep ? y : x), (steep ? x : y), color);
                error -= dy;
                if (error < 0)
                {   
                    
                    y -= ystep;
                    
                    error += dx;
                }
            }
            pictureBox1.Image = bmp;

        }

        private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private void btnBresenham_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(inputLineX1.Text) + 265;
            int y1 = Convert.ToInt32(inputLineY1.Text) + 160;

            int x2 = Convert.ToInt32(inputLineX2.Text) + 265;
            int y2 = Convert.ToInt32(inputLineY2.Text) + 160;

            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);
            Bitmap pic = new Bitmap(this.Width, this.Height);
            Color red = Color.Red;
            Bresenham(p1, p2, pic, red);
        }
        private void Circle(Point center, int radius)
        {
            Bitmap pic = new Bitmap(this.Width, this.Height);
            //for (int theta = 0; theta <= 360; theta++) { 
            //    double x, y;
            //    x = center.X + radius * Math.Cos(theta);
            //    y = center.Y + radius * Math.Sin(theta);

            //    pic.SetPixel((int)(x), (int)(y), Color.Red);
            //}

            int x = 0;
            int y = radius;
            int p = 1 - radius;
            _pointsTable = new DataTable();
            _pointsTable.Columns.Add("X", typeof(int));
            _pointsTable.Columns.Add("Y", typeof(int));

            pic.SetPixel(center.X + x, center.Y + y, Color.Black);
            pic.SetPixel(center.X - x, center.Y + y, Color.Black);
            pic.SetPixel(center.X + x, center.Y - y, Color.Black);
            pic.SetPixel(center.X - x, center.Y - y, Color.Black);
            pic.SetPixel(center.X + y, center.Y + x, Color.Black);
            pic.SetPixel(center.X - y, center.Y + x, Color.Black);
            pic.SetPixel(center.X + y, center.Y - x, Color.Black);
            pic.SetPixel(center.X - y, center.Y - x, Color.Black);

            _pointsTable.Rows.Add((center.X + x) - 265, (center.Y + y) * -1 + 160);
            _pointsTable.Rows.Add((center.X - x) - 265, (center.Y + y) * -1 + 160);
            _pointsTable.Rows.Add((center.X + x) - 265, (center.Y - y) * -1 + 160);
            _pointsTable.Rows.Add((center.X - x) - 265, (center.Y - y) * -1 + 160);
            _pointsTable.Rows.Add((center.X + y) - 265, (center.Y + x) * -1 + 160);
            _pointsTable.Rows.Add((center.X - y) - 265, (center.Y + x) * -1 + 160);
            _pointsTable.Rows.Add((center.X + y) - 265, (center.Y - x) * -1 + 160);
            _pointsTable.Rows.Add((center.X - y) - 265, (center.Y - x) * -1 + 160);

            while (x < y)
            {
                x++;
                if (p < 0)
                    p += 2 * x + 1;
                else
                {
                    y--;
                    p += 2 * x + 1 - 2 * y;
                }
                pic.SetPixel(center.X + x, center.Y + y, Color.Black);
                pic.SetPixel(center.X - x, center.Y + y, Color.Black);
                pic.SetPixel(center.X + x, center.Y - y, Color.Black);
                pic.SetPixel(center.X - x, center.Y - y, Color.Black);
                pic.SetPixel(center.X + y, center.Y + x, Color.Black);
                pic.SetPixel(center.X - y, center.Y + x, Color.Black);
                pic.SetPixel(center.X + y, center.Y - x, Color.Black);
                pic.SetPixel(center.X - y, center.Y - x, Color.Black);

                _pointsTable.Rows.Add((center.X + x) - 265, (center.Y + y) * -1 + 160);
                _pointsTable.Rows.Add((center.X - x) - 265, (center.Y + y) * -1 + 160);
                _pointsTable.Rows.Add((center.X + x) - 265, (center.Y - y) * -1 + 160);
                _pointsTable.Rows.Add((center.X - x) - 265, (center.Y - y) * -1 + 160);
                _pointsTable.Rows.Add((center.X + y) - 265, (center.Y + x) * -1 + 160);
                _pointsTable.Rows.Add((center.X - y) - 265, (center.Y + x) * -1 + 160);
                _pointsTable.Rows.Add((center.X + y) - 265, (center.Y - x) * -1 + 160);
                _pointsTable.Rows.Add((center.X - y) - 265, (center.Y - x) * -1 + 160);
            }
            pictureBox1.Image = pic;
            dataGridView1.DataSource = _pointsTable;
        }
        private void btnCircle_Click(object sender, EventArgs e)
        {
            int xc = Convert.ToInt32(inputCircleX.Text) + 265;
            int yc = Convert.ToInt32(inputCircleY.Text)*-1 + 160;

            int r = Convert.ToInt32(inputCircleR.Text);

            Point center = new Point(xc, yc);
            Circle(center, r);
        }
        private void Ellipse(Point center, int xr, int yr)
        {
            Bitmap pic = new Bitmap(this.Width, this.Height);

            int x = 0;
            int y = yr;
            int radius2y = yr * yr;
            int radius2x = xr * xr;
            _pointsTable = new DataTable();
            _pointsTable.Columns.Add("X", typeof(int));
            _pointsTable.Columns.Add("Y", typeof(int));

            double d1 = radius2y - radius2x * yr + radius2x / 4.0;
            pic.SetPixel(center.X + x, center.Y + y, Color.Red);
            pic.SetPixel(center.X - x, center.Y + y, Color.Red);
            pic.SetPixel(center.X + x, center.Y - y, Color.Red);
            pic.SetPixel(center.X - x, center.Y - y, Color.Red);

            _pointsTable.Rows.Add((center.X + x) - 265, (center.Y + y) * -1 + 160);
            _pointsTable.Rows.Add((center.X - x) - 265, (center.Y + y) * -1 + 160);
            _pointsTable.Rows.Add((center.X + x) - 265, (center.Y - y) * -1 + 160);
            _pointsTable.Rows.Add((center.X - x) - 265, (center.Y - y) * -1 + 160);

            while (radius2x * (y - 0.5) > radius2y * (x + 1))
            {
                if (d1 < 0)
                {
                    d1 += radius2y * (2 * x + 3);
                }
                else
                {   
                    d1 += radius2y * (2 * x + 3) + radius2x * (-2 * y + 2);
                    y--;
                }
                x++;
                pic.SetPixel(center.X + x, center.Y + y, Color.Red);
                pic.SetPixel(center.X - x, center.Y + y, Color.Red);
                pic.SetPixel(center.X + x, center.Y - y, Color.Red);
                pic.SetPixel(center.X - x, center.Y - y, Color.Red);

                _pointsTable.Rows.Add((center.X + x) - 265, (center.Y + y) * -1 + 160);
                _pointsTable.Rows.Add((center.X - x) - 265, (center.Y + y) * -1 + 160);
                _pointsTable.Rows.Add((center.X + x) - 265, (center.Y - y) * -1 + 160);
                _pointsTable.Rows.Add((center.X - x) - 265, (center.Y - y) * -1 + 160);
            }
            double d2 = radius2y * (x + 0.5) * (x + 0.5) + radius2x * (y - 1) * (y - 1) - radius2x * radius2y;
            while (y > 0)
            {
                if (d2 < 0)
                {
                    d2 += radius2y * (2 * x + 2) + radius2x * (-2 * y + 3);
                    x++;
                }
                else
                {
                    d2 += radius2x * (-2 * y + 3);
                }
                y--;
                pic.SetPixel(center.X + x, center.Y + y, Color.Red);
                pic.SetPixel(center.X - x, center.Y + y, Color.Red);
                pic.SetPixel(center.X + x, center.Y - y, Color.Red);
                pic.SetPixel(center.X - x, center.Y - y, Color.Red);

                _pointsTable.Rows.Add((center.X + x) - 265, (center.Y + y) * -1 + 160);
                _pointsTable.Rows.Add((center.X - x) - 265, (center.Y + y) * -1 + 160);
                _pointsTable.Rows.Add((center.X + x) - 265, (center.Y - y) * -1 + 160);
                _pointsTable.Rows.Add((center.X - x) - 265, (center.Y - y) * -1 + 160);
            }
            pictureBox1.Image = pic;
            dataGridView1.DataSource = _pointsTable;

        }
        private void btnEllipse_Click(object sender, EventArgs e)
        {
            int xc = Convert.ToInt32(inputEllipseX.Text) + 265;
            int yc = Convert.ToInt32(inputEllipseY.Text)*-1 + 160;

            int xr = Convert.ToInt32(inputEllipseRX.Text);
            int yr = Convert.ToInt32(inputEllipseRY.Text);

            Point center = new Point(xc, yc);
            Ellipse(center, xr, yr);
        }

        
        private double[,] MultiplyMatrices(double[,] matrix1, double[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);

            if (cols1 != rows2)
            {
                throw new Exception("Cannot multiply matrices. Invalid dimensions.");
            }

            double[,] result = new double[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    result[i, j] = sum;
                }
            }

            return result;
        }
        private double[,] GetPixelMatrix(Bitmap bmp)
        {
            int width = bmp.Width;
            int height = bmp.Height;

            double[,] pixelMatrix = new double[width * height, 3];

            int k = 0;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color color = bmp.GetPixel(x, y);
                    pixelMatrix[k, 0] = color.R;
                    pixelMatrix[k, 1] = color.G;
                    pixelMatrix[k, 2] = color.B;
                    k++;
                }
            }

            return pixelMatrix;
        }

        private void Scale1(Image img, int x, int y)
        {
        //    // Define a scaling factor
        //    double SX = (double)x/100;
        //    double SY = (double)y/100;

        //    // Create a scaling matrix
        //    double[,] scalingMatrix = new double[3, 3] {
        //        {SX, 0, 0},
        //        {0, SY, 0},
        //        {0, 0, 1}
        //    };

        //    // Get the current image from the PictureBox
        //    Bitmap bmp = (Bitmap)pictureBox2.Image;

        //    // Get the matrix of pixel colors
        //    double[,] pixelMatrix = new double[3, 3];
        //    pixelMatrix = GetPixelMatrix(bmp);

        //    // Apply the scaling transformation to the pixel matrix
        //    double[,] transformedMatrix = MultiplyMatrices(scalingMatrix, pixelMatrix);

        //    // Create a new Bitmap to hold the transformed image
        //    Bitmap transformedBmp = new Bitmap(bmp.Width, bmp.Height);

        //    // Set the pixel colors of the transformed image
        //    for (int i = 0; i < transformedBmp.Width; i++)
        //    {
        //        for (int j = 0; j < transformedBmp.Height; j++)
        //        {
        //            transformedBmp.SetPixel(i, j, Color.FromArgb(
        //                (int)transformedMatrix[i, j],
        //                (int)transformedMatrix[i, j],
        //                (int)transformedMatrix[i, j]
        //            ));
        //        }
        //    }
        //    // Set the transformed image as the PictureBox image
        //    pictureBox2.Image = transformedBmp;
        }

        private double[,] Scale(double[,] pixelMatrix, double scaleX, double scaleY)
        {
            int width = pixelMatrix.GetLength(0);
            int height = pixelMatrix.GetLength(1);

            // Create the scaling matrix
            double[,] scalingMatrix = new double[2, 2] {
        { scaleX, 0 },
        { 0, scaleY }
    };

            // Initialize the new pixel matrix
            double[,] newPixelMatrix = new double[width, height];

            // Apply scaling to each pixel's coordinates
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    // Multiply the scaling matrix with the pixel coordinates
                    double newX = x * scalingMatrix[0, 0] + y * scalingMatrix[0, 1];
                    double newY = x * scalingMatrix[1, 0] + y * scalingMatrix[1, 1];

                    // Round the new coordinates to the nearest integer values
                    int roundedX = (int)Math.Round(newX);
                    int roundedY = (int)Math.Round(newY);

                    // Make sure the new coordinates are within the image bounds
                    if (roundedX < 0) roundedX = 0;
                    if (roundedX >= width) roundedX = width - 1;
                    if (roundedY < 0) roundedY = 0;
                    if (roundedY >= height) roundedY = height - 1;

                    // Retrieve the color value from the pixel matrix
                    newPixelMatrix[x, y] = pixelMatrix[roundedX, roundedY];
                }
            }

            return newPixelMatrix;
        }
        private void Scalae(int x, int y)
        {
            // Get the current image from the PictureBox
            Bitmap bmp = (Bitmap)pictureBox2.Image;

            // Define the scaling factors
            double sx = (double)x / 100;
            double sy = (double)y / 100;

            // Calculate the new image dimensions
            int newWidth = (int)Math.Round(bmp.Width * sx);
            int newHeight = (int)Math.Round(bmp.Height * sy);

            // Create a new Bitmap to hold the transformed image
            Bitmap scaledBmp = new Bitmap(newWidth, newHeight);

            // Loop through each pixel in the scaled image
            for (int yScaled = 0; yScaled < newHeight; yScaled++)
            {
                for (int xScaled = 0; xScaled < newWidth; xScaled++)
                {
                    // Calculate the corresponding pixel in the original image
                    int xOriginal = (int)Math.Round(xScaled / sx);
                    int yOriginal = (int)Math.Round(yScaled / sy);

                    // Get the color of the corresponding pixel in the original image
                    Color color = bmp.GetPixel(xOriginal, yOriginal);

                    // Set the color of the corresponding pixel in the scaled image
                    scaledBmp.SetPixel(xScaled, yScaled, color);
                }
            }

            // Set the scaled image as the PictureBox image
            pictureBox2.Image = scaledBmp;
        }


        

        Point pd1 = new Point();
        Point pd2 = new Point();
        Point pd3 = new Point();
        private void btnDraw_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(inputDrawX1.Text);
            int y1 = Convert.ToInt32(inputDrawY1.Text);
            pd1 = new Point(x1 + 268, y1* -1 + 144);

            int x2 = Convert.ToInt32(inputDrawX2.Text);
            int y2 = Convert.ToInt32(inputDrawY2.Text);
            pd2 = new Point(x2 + 268, y2 * -1 + 144);


            int x3 = Convert.ToInt32(inputDrawX3.Text);
            int y3 = Convert.ToInt32(inputDrawY3.Text);
            pd3 = new Point(x3 + 268, y3 * -1 + 144);

            DrawTriangle(pd1, pd2, pd3);
        }
        private void DrawTriangle (Point p1, Point p2, Point p3)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            // Create a Graphics object from the Bitmap
            Graphics g = Graphics.FromImage(bmp);

            // Define the triangle vertices
            Point[] trianglePoints = new Point[]
            {
                p1,
                p2,
                p3
            };

            // Draw the triangle
            g.DrawPolygon(Pens.Blue, trianglePoints);

            // Set the Bitmap as the PictureBox image
            pictureBox2.Image = bmp;

        }


        private void Translate(int x, int y)
        {
            pd1.X += x;
            pd2.X += x;
            pd3.X += x;
            pd1.Y -= y;
            pd2.Y -= y;
            pd3.Y -= y;

            DrawTriangle(pd1, pd2, pd3);
        }
        private void btnTrans_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(inputTransX.Text);
            int y = Convert.ToInt32(inputTransY.Text);

            Translate(x, y);
        }
        private void Scale(double x, double y)
        {
            if(x > 0)
            {
                pd1.X = (int)Math.Round(pd1.X * x);
                pd2.X = (int)Math.Round(pd2.X * x);
                pd3.X = (int)Math.Round(pd3.X * x);
            }
            if (y > 0)
            {
                pd1.Y = (int)Math.Round(pd1.Y * y);
                pd2.Y = (int)Math.Round(pd2.Y * y);
                pd3.Y = (int)Math.Round(pd3.Y * y);
            }
                

            DrawTriangle(pd1, pd2, pd3);
        }

        private void btnScale_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(inputScaleX.Text);
            double y = Convert.ToDouble(inputScaleY.Text);

            x = x / 100;
            y = y / 100;
            Scale(x, y);
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(inputRotate.Text);

            Rotate(x * Math.PI / 180);
        }
        private void Rotate(double d)
        {
            pd1.X = (int)Math.Round( (pd1.X - 268) * Math.Cos(d)) - (int)Math.Round((pd1.Y - 144) * Math.Sin(d)) + 268;
            pd1.Y = (int)Math.Round( (pd1.X - 268) * Math.Sin(d)) + (int)Math.Round((pd1.Y - 144) * Math.Cos(d)) + 144;

            pd2.X = (int)Math.Round( (pd2.X - 268) * Math.Cos(d)) - (int)Math.Round((pd2.Y - 144) * Math.Sin(d)) + 268;
            pd2.Y = (int)Math.Round( (pd2.X - 268) * Math.Sin(d)) + (int)Math.Round((pd2.Y - 144) * Math.Cos(d)) + 144;

            pd3.X = (int)Math.Round( (pd3.X - 268) * Math.Cos(d)) - (int)Math.Round((pd3.Y - 144) * Math.Sin(d)) + 268;
            pd3.Y = (int)Math.Round( (pd3.X - 268) * Math.Sin(d)) + (int)Math.Round((pd3.Y - 144) * Math.Cos(d)) + 144;

            DrawTriangle(pd1, pd2, pd3);
        }
        private int radiusToOrigin(Point p)
        {
            int dx = p.X - 268;
            int dy = p.Y + 144;
            int sqX = dx * dx;
            int sqY = dy * dy;
            int radius = (int)Math.Round(Math.Sqrt(sqX + sqY));

            return radius;
        }
    }
}
