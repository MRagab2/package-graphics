using System;
using System.Collections.Generic;
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

        private void DDA(Point p1, Point p2)
        {
            var brush = Brushes.Black;
            Graphics g = pictureBox1.CreateGraphics();
            int w = pictureBox1.ClientSize.Width;
            int h = pictureBox1.ClientSize.Height;
            List<int> xToPrint = new List<int>();
            List<int> yToPrint = new List<int>();

            int dx = p2.X - p1.X;
            int dy = p2.Y - p1.Y;
            float xIncrement, yIncrement, x = p1.X, y = p1.Y;
            int k, steps;

            _pointsTable = new DataTable();
            _pointsTable.Columns.Add("X", typeof(int));
            _pointsTable.Columns.Add("Y", typeof(int));

            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);

            xIncrement = (float)dx / (float)steps;
            yIncrement = (float)dy / (float)steps;

            g.FillRectangle(brush, x + w / 2, -y + h / 2, 1, 1);
            _pointsTable.Rows.Add((int)Math.Round(x), (int)Math.Round(y)); // Add the starting point

            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                y += yIncrement;

                xToPrint.Add((int)Math.Round(x));
                yToPrint.Add((int)Math.Round(y));

                g.FillRectangle(brush, x + w / 2, -y + h / 2, 1, 1);
                _pointsTable.Rows.Add((int)Math.Round(x), (int)Math.Round(y)); // Add each intermediate point
            }
            dataGridView1.DataSource = _pointsTable;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(inputLineX1.Text);
            int y1 = Convert.ToInt32(inputLineY1.Text);

            int x2 = Convert.ToInt32(inputLineX2.Text);
            int y2 = Convert.ToInt32(inputLineY2.Text);

            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);

            DrawAxes();
            DDA(p1, p2);
        }

        private void Bresenham(Point p1, Point p2)
        {
        
            var brush = Brushes.Black;
            Graphics g = pictureBox1.CreateGraphics();
            int w = pictureBox1.ClientSize.Width;
            int h = pictureBox1.ClientSize.Height;

            _pointsTable = new DataTable();
            _pointsTable.Columns.Add("X", typeof(int));
            _pointsTable.Columns.Add("Y", typeof(int));

            List<int> xToPrint = new List<int>();
            List<int> yToPrint = new List<int>();

            List<int> pk = new List<int>();
            int x0 = (p1.X);
            int y0 = (p1.Y);
            int xe = (p2.X);
            int ye = (p2.Y);
            int temp;
            int dx, dy;
            int p;
            int twoDy, twoDyMinusDx;
            double m = (double)(ye - y0) / (xe - x0);

            if (m >= 0 && m <= 1 && x0 < xe)
            {
                dx = xe - x0;
                dy = ye - y0;
                p = 2 * dy - dx;
                twoDy = 2 * dy;
                twoDyMinusDx = 2 * (dy - dx);
                pk.Add(p);
                xToPrint.Add(x0);
                yToPrint.Add(y0);
                _pointsTable.Rows.Add(x0, y0);

                while (x0 < xe)
                {
                    x0++;
                    if (p < 0)
                        p += twoDy;
                    else
                    {
                        y0++;
                        p += twoDyMinusDx;
                    }
                    pk.Add(p);
                    xToPrint.Add(x0);
                    yToPrint.Add(y0);
                    g.FillRectangle(brush, x0 + w / 2, -y0 + h / 2, 1, 1);
                    _pointsTable.Rows.Add(x0, y0);
                }
            }
            else if (m > 1 && y0 < ye)
            {

                temp = x0;
                x0 = y0;
                y0 = temp;
                temp = xe;
                xe = ye;
                ye = temp;
                dx = xe - x0;
                dy = ye - y0;
                p = 2 * dy - dx;
                twoDy = 2 * dy;
                twoDyMinusDx = 2 * (dy - dx);
                pk.Add(p);
                xToPrint.Add(y0);
                yToPrint.Add(x0);

                _pointsTable.Rows.Add(x0, y0);
                while (x0 < xe)
                {
                    x0++;
                    if (p < 0)
                        p += twoDy;
                    else
                    {
                        y0++;
                        p += twoDyMinusDx;
                    }
                    pk.Add(p);
                    xToPrint.Add(y0);
                    yToPrint.Add(x0);
                    g.FillRectangle(brush, y0 + w / 2, -x0 + h / 2, 1, 1);
                _pointsTable.Rows.Add(x0, y0);
                }
            }
            else if (m < -1 && y0 < ye)
            {

                temp = x0;
                x0 = y0;
                y0 = temp;
                temp = xe;
                xe = ye;
                ye = temp;
                dx = xe - x0;
                dy = -(ye - y0);
                p = 2 * dy - dx;
                twoDy = 2 * dy;
                twoDyMinusDx = 2 * (dy - dx);
                pk.Add(p);
                xToPrint.Add(y0);
                yToPrint.Add(x0);


                _pointsTable.Rows.Add(x0, y0);
                while (x0 < xe)
                {
                    x0++;
                    if (p < 0)
                        p += twoDy;
                    else
                    {
                        y0--;
                        p += twoDyMinusDx;
                    }
                    pk.Add(p);
                    xToPrint.Add(y0);
                    yToPrint.Add(x0);
                    g.FillRectangle(brush, y0 + w / 2, -x0 + h / 2, 2, 2);
                _pointsTable.Rows.Add(x0, y0);
                }
            }
            else if (m <= 0 && m >= -1 && xe < x0)
            {
                dx = -(xe - x0);
                dy = ye - y0;
                p = 2 * dy - dx;
                twoDy = 2 * dy;
                twoDyMinusDx = 2 * (dy - dx);
                pk.Add(p);
                xToPrint.Add(x0);
                yToPrint.Add(y0);


                _pointsTable.Rows.Add(x0, y0);
                while (x0 > xe)
                {
                    x0--;
                    if (p < 0)
                        p += twoDy;
                    else
                    {
                        y0++;
                        p += twoDyMinusDx;
                    }
                    pk.Add(p);
                    xToPrint.Add(x0);
                    yToPrint.Add(y0);
                    g.FillRectangle(brush, x0 + w / 2, -y0 + h / 2, 1, 1);
                _pointsTable.Rows.Add(x0, y0);
                }
            }
            else if (m > 0 && m <= 1 && xe < x0)
            {
                dx = -(xe - x0);
                dy = -(ye - y0);
                p = 2 * dy - dx;
                twoDy = 2 * dy;
                twoDyMinusDx = 2 * (dy - dx);
                pk.Add(p);
                xToPrint.Add(x0);
                yToPrint.Add(y0);


                _pointsTable.Rows.Add(x0, y0);
                while (x0 > xe)
                {
                    x0--;
                    if (p < 0)
                        p += twoDy;
                    else
                    {
                        y0--;
                        p += twoDyMinusDx;
                    }
                    pk.Add(p);
                    xToPrint.Add(x0);
                    yToPrint.Add(y0);
                    g.FillRectangle(brush, x0 + w / 2, -y0 + h / 2, 1, 1);
                _pointsTable.Rows.Add(x0, y0);
                }
            }
            else if (m > 1 && ye < y0)
            {

                temp = x0;
                x0 = y0;
                y0 = temp;
                temp = xe;
                xe = ye;
                ye = temp;
                dx = -(xe - x0);
                dy = -(ye - y0);
                p = 2 * dy - dx;
                twoDy = 2 * dy;
                twoDyMinusDx = 2 * (dy - dx);
                pk.Add(p);
                xToPrint.Add(y0);
                yToPrint.Add(x0);


                _pointsTable.Rows.Add(x0, y0);
                while (x0 > xe)
                {
                    x0--;
                    if (p < 0)
                        p += twoDy;
                    else
                    {
                        y0--;
                        p += twoDyMinusDx;
                    }
                    pk.Add(p);
                    xToPrint.Add(y0);
                    yToPrint.Add(x0);
                    g.FillRectangle(brush, y0 + w / 2, -x0 + h / 2, 2, 2);
                _pointsTable.Rows.Add(x0, y0);
                }
            }
            else if (m < -1 && ye < y0)
            {

                temp = x0;
                x0 = y0;
                y0 = temp;
                temp = xe;
                xe = ye;
                ye = temp;
                dx = -(xe - x0);
                dy = ye - y0;
                p = 2 * dy - dx;
                twoDy = 2 * dy;
                twoDyMinusDx = 2 * (dy - dx);

                pk.Add(p);
                xToPrint.Add(y0);
                yToPrint.Add(x0);

                _pointsTable.Rows.Add(x0, y0);

                while (x0 > xe)
                {
                    x0--;
                    if (p < 0)
                        p += twoDy;
                    else
                    {
                        y0++;
                        p += twoDyMinusDx;
                    }
                    pk.Add(p);
                    xToPrint.Add(y0);
                    yToPrint.Add(x0);
                    g.FillRectangle(brush, y0 + w / 2, -x0 + h / 2, 1, 1);
                _pointsTable.Rows.Add(x0, y0);
                }
            }
            else if (m <= 0 && m >= -1 && x0 < xe)
            {
                dx = xe - x0;
                dy = -(ye - y0);
                p = 2 * dy - dx;
                twoDy = 2 * dy;
                twoDyMinusDx = 2 * (dy - dx);
                pk.Add(p);
                xToPrint.Add(x0);
                yToPrint.Add(y0);

                _pointsTable.Rows.Add(x0, y0);

                while (x0 < xe)
                {
                    x0++;
                    if (p < 0)
                        p += twoDy;
                    else
                    {
                        y0--;
                        p += twoDyMinusDx;
                    }
                    pk.Add(p);
                    xToPrint.Add(x0);
                    yToPrint.Add(y0);
                    g.FillRectangle(brush, x0 + w / 2, -y0 + h / 2, 1, 1);
                _pointsTable.Rows.Add(x0, y0);
                }
            }
            dataGridView1.DataSource = _pointsTable;

        }

        private void btnBresenham_Click(object sender, EventArgs e)
         {
             int x1 = Convert.ToInt32(inputLineX1.Text);
             int y1 = Convert.ToInt32(inputLineY1.Text);

             int x2 = Convert.ToInt32(inputLineX2.Text);
             int y2 = Convert.ToInt32(inputLineY2.Text);

             Point p1 = new Point(x1, y1);
             Point p2 = new Point(x2, y2); 
            
             DrawAxes();
             Bresenham(p1, p2);
         }

        private void Circle(Point center, int radius)
        {
            var brush = Brushes.Black;
            Graphics g = pictureBox1.CreateGraphics();
            int w = pictureBox1.ClientSize.Width;
            int h = pictureBox1.ClientSize.Height;
            List<int> xToPrint = new List<int>();
            List<int> yToPrint = new List<int>();

            int x = 0;
            int y = radius;
            int p = 1 - radius;
            _pointsTable = new DataTable();
            _pointsTable.Columns.Add("X", typeof(int));
            _pointsTable.Columns.Add("Y", typeof(int));


            g.FillRectangle(brush, (center.X + x) + w / 2, -(center.Y + y) + h / 2, 1, 1);
            g.FillRectangle(brush, (center.X - x) + w / 2, -(center.Y + y) + h / 2, 1, 1);
            g.FillRectangle(brush, (center.X + x) + w / 2, -(center.Y - y) + h / 2, 1, 1);
            g.FillRectangle(brush, (center.X - x) + w / 2, -(center.Y - y) + h / 2, 1, 1);
            g.FillRectangle(brush, (center.X + y) + w / 2, -(center.Y + x) + h / 2, 1, 1);
            g.FillRectangle(brush, (center.X - y) + w / 2, -(center.Y + x) + h / 2, 1, 1);
            g.FillRectangle(brush, (center.X + y) + w / 2, -(center.Y - x) + h / 2, 1, 1);
            g.FillRectangle(brush, (center.X - y) + w / 2, -(center.Y - x) + h / 2, 1, 1);

            _pointsTable.Rows.Add((center.X + x), (center.Y + y) );
            _pointsTable.Rows.Add((center.X - x), (center.Y + y) );
            _pointsTable.Rows.Add((center.X + x), (center.Y - y) );
            _pointsTable.Rows.Add((center.X - x), (center.Y - y) );
            _pointsTable.Rows.Add((center.X + y), (center.Y + x) );
            _pointsTable.Rows.Add((center.X - y), (center.Y + x) );
            _pointsTable.Rows.Add((center.X + y), (center.Y - x) );
            _pointsTable.Rows.Add((center.X - y), (center.Y - x) );

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
                xToPrint.Add(x);
                yToPrint.Add(y);

                g.FillRectangle(brush, (center.X + x) + w / 2, -(center.Y + y) + h / 2, 1, 1);
                g.FillRectangle(brush, (center.X - x) + w / 2, -(center.Y + y) + h / 2, 1, 1);
                g.FillRectangle(brush, (center.X + x) + w / 2, -(center.Y - y) + h / 2, 1, 1);
                g.FillRectangle(brush, (center.X - x) + w / 2, -(center.Y - y) + h / 2, 1, 1);
                g.FillRectangle(brush, (center.X + y) + w / 2, -(center.Y + x) + h / 2, 1, 1);
                g.FillRectangle(brush, (center.X - y) + w / 2, -(center.Y + x) + h / 2, 1, 1);
                g.FillRectangle(brush, (center.X + y) + w / 2, -(center.Y - x) + h / 2, 1, 1);
                g.FillRectangle(brush, (center.X - y) + w / 2, -(center.Y - x) + h / 2, 1, 1);

                _pointsTable.Rows.Add((center.X + x), (center.Y + y));
                _pointsTable.Rows.Add((center.X - x), (center.Y + y));
                _pointsTable.Rows.Add((center.X + x), (center.Y - y));
                _pointsTable.Rows.Add((center.X - x), (center.Y - y));
                _pointsTable.Rows.Add((center.X + y), (center.Y + x));
                _pointsTable.Rows.Add((center.X - y), (center.Y + x));
                _pointsTable.Rows.Add((center.X + y), (center.Y - x));
                _pointsTable.Rows.Add((center.X - y), (center.Y - x));
            }
            dataGridView1.DataSource = _pointsTable;
        }
        private void btnCircle_Click(object sender, EventArgs e)
        {
            int xc = Convert.ToInt32(inputCircleX.Text);
            int yc = Convert.ToInt32(inputCircleY.Text);

            int r = Convert.ToInt32(inputCircleR.Text);

            Point center = new Point(xc, yc);
            DrawAxes();
            Circle(center, r);
        }
        private void Ellipse(Point center, int xr, int yr)
        {
            var brush = Brushes.Black;
            Graphics g = pictureBox1.CreateGraphics();
            int w = pictureBox1.ClientSize.Width;
            int h = pictureBox1.ClientSize.Height;
            List<int> xToPrint = new List<int>();
            List<int> yToPrint = new List<int>();

            int x = 0;
            int y = yr;
            int radius2y = yr * yr;
            int radius2x = xr * xr;
            _pointsTable = new DataTable();
            _pointsTable.Columns.Add("X", typeof(int));
            _pointsTable.Columns.Add("Y", typeof(int));

            double d1 = radius2y - radius2x * yr + radius2x / 4.0;

            g.FillRectangle(brush, (center.X + x) + w / 2, -(center.Y + y) + h / 2, 1, 1);
            g.FillRectangle(brush, (center.X - x) + w / 2, -(center.Y + y) + h / 2, 1, 1);
            g.FillRectangle(brush, (center.X + x) + w / 2, -(center.Y - y) + h / 2, 1, 1);
            g.FillRectangle(brush, (center.X - x) + w / 2, -(center.Y - y) + h / 2, 1, 1);

            _pointsTable.Rows.Add((center.X + x), (center.Y + y) );
            _pointsTable.Rows.Add((center.X - x), (center.Y + y) );
            _pointsTable.Rows.Add((center.X + x), (center.Y - y) );
            _pointsTable.Rows.Add((center.X - x), (center.Y - y) );

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

                xToPrint.Add(x);
                yToPrint.Add(y);
                g.FillRectangle(brush, (center.X + x) + w / 2, -(center.Y + y) + h / 2, 1, 1);
                g.FillRectangle(brush, (center.X - x) + w / 2, -(center.Y + y) + h / 2, 1, 1);
                g.FillRectangle(brush, (center.X + x) + w / 2, -(center.Y - y) + h / 2, 1, 1);
                g.FillRectangle(brush, (center.X - x) + w / 2, -(center.Y - y) + h / 2, 1, 1);

                _pointsTable.Rows.Add((center.X + x), (center.Y + y) );
                _pointsTable.Rows.Add((center.X - x), (center.Y + y) );
                _pointsTable.Rows.Add((center.X + x), (center.Y - y) );
                _pointsTable.Rows.Add((center.X - x), (center.Y - y) );
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

                xToPrint.Add(x);
                yToPrint.Add(y);
                g.FillRectangle(brush, (center.X + x) + w / 2, -(center.Y + y) + h / 2, 1, 1);
                g.FillRectangle(brush, (center.X - x) + w / 2, -(center.Y + y) + h / 2, 1, 1);
                g.FillRectangle(brush, (center.X + x) + w / 2, -(center.Y - y) + h / 2, 1, 1);
                g.FillRectangle(brush, (center.X - x) + w / 2, -(center.Y - y) + h / 2, 1, 1);

                _pointsTable.Rows.Add((center.X + x), (center.Y + y));
                _pointsTable.Rows.Add((center.X - x), (center.Y + y));
                _pointsTable.Rows.Add((center.X + x), (center.Y - y));
                _pointsTable.Rows.Add((center.X - x), (center.Y - y));
            }
            dataGridView1.DataSource = _pointsTable;

        }
        private void btnEllipse_Click(object sender, EventArgs e)
        {
            int xc = Convert.ToInt32(inputEllipseX.Text);
            int yc = Convert.ToInt32(inputEllipseY.Text);

            int xr = Convert.ToInt32(inputEllipseRX.Text);
            int yr = Convert.ToInt32(inputEllipseRY.Text);

            Point center = new Point(xc, yc);
            DrawAxes();
            Ellipse(center, xr, yr);
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            DrawAxes();
            _pointsTable = new DataTable();
            _pointsTable.Columns.Add("X", typeof(int));
            _pointsTable.Columns.Add("Y", typeof(int));
            dataGridView1.DataSource = _pointsTable;
        }
        private void DrawAxes()
        {
            // Get the graphics object for the picture box
            Graphics g = pictureBox1.CreateGraphics();

            // Set the pen color and thickness for the axes
            Pen pen = new Pen(Color.Black, 1);

            // Calculate the center point of the picture box
            int centerX = pictureBox1.Width / 2;
            int centerY = pictureBox1.Height / 2;

            // Draw the x-axis
            g.DrawLine(pen, 0, centerY, pictureBox1.Width, centerY);

            // Draw the y-axis
            g.DrawLine(pen, centerX, 0, centerX, pictureBox1.Height);
        }
    }
}
