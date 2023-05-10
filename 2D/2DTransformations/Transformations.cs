using System.Drawing.Drawing2D;

namespace _2DTransformations
{
    public partial class Transformations : Form
    {
        static Point centralPoint = new Point(300, 300);
        Point point1 = new Point(centralPoint.X + 50, centralPoint.Y - 50);
        Point point2 = new Point(centralPoint.X + 75, centralPoint.Y - 50);

        public Transformations()
        {
            InitializeComponent();
            label2.Text = "P1.X: " + (point1.X - centralPoint.X) + "       P1.Y: " + (centralPoint.Y - point1.Y);
            label3.Text = "P2.X: " + (point2.X - centralPoint.X) + "       P2.Y: " + (centralPoint.Y - point2.Y);
        }

        private void Transformations_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen blackPen = new Pen(Color.Black, 3);
            Pen redPen = new Pen(Color.Red, 1);
            Pen greenPen = new Pen(Color.Green, 1);
            Pen bluePen = new Pen(Color.Blue, 2);

            Rectangle testShape = new Rectangle(450, 150, 50, 50);

            g.DrawLine(redPen, 0, 300, 600, 300);
            g.DrawLine(greenPen, 300, 0, 300, 600);
            g.DrawLine(bluePen, point1, point2);


            //g.DrawRectangle(bluePen, testShape);
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            double x = Decimal.ToDouble(xUpDown.Value);
            double y = Decimal.ToDouble(yUpDown.Value);
            double angle = Decimal.ToDouble(angleUpDown.Value);
            double[] oldPoint1 = { point1.X - centralPoint.X, -1 * (point1.Y - centralPoint.Y), 1 };
            double[] oldPoint2 = { point2.X - centralPoint.X, -1 * (point2.Y - centralPoint.Y), 1 };
            double[] newPoint1;
            double[] newPoint2;

            if (rotationRd.Checked)
            {
                double[,] angleMatrix = MatrixOperations.MatrixRotation(angle);
                newPoint1 = MatrixOperations.MultiplyMatrix(angleMatrix, oldPoint1);
                newPoint2 = MatrixOperations.MultiplyMatrix(angleMatrix, oldPoint2);

                point1 = new Point(centralPoint.X + (int)Math.Round(newPoint1[0]), centralPoint.Y - (int)Math.Round(newPoint1[1]));
                point2 = new Point(centralPoint.X + (int)Math.Round(newPoint2[0]), centralPoint.Y - (int)Math.Round(newPoint2[1]));
            }
            else if (scaleRd.Checked)
            {
                double[,] scaleMatrix = MatrixOperations.MatrixScaling(x, y);
                newPoint1 = MatrixOperations.MultiplyMatrix(scaleMatrix, oldPoint1);
                newPoint2 = MatrixOperations.MultiplyMatrix(scaleMatrix, oldPoint2);


                point1 = new Point(centralPoint.X + (int)newPoint1[0], centralPoint.Y - (int)newPoint1[1]);
                point2 = new Point(centralPoint.X + (int)newPoint2[0], centralPoint.Y - (int)newPoint2[1]);
            }
            else if (translationRd.Checked)
            {

                double[,] translationMatrix = MatrixOperations.MatrixTranslation(x, y);
                newPoint1 = MatrixOperations.MultiplyMatrix(translationMatrix, oldPoint1);
                newPoint2 = MatrixOperations.MultiplyMatrix(translationMatrix, oldPoint2);

                point1 = new Point(centralPoint.X + (int)newPoint1[0], centralPoint.Y - (int)newPoint1[1]);
                point2 = new Point(centralPoint.X + (int)newPoint2[0], centralPoint.Y - (int)newPoint2[1]);
            }

            label2.Text = "P1.X: " + (point1.X - centralPoint.X) + "       P1.Y: " + (centralPoint.Y - point1.Y);
            label3.Text = "P2.X: " + (point2.X - centralPoint.X) + "       P2.Y: " + (centralPoint.Y - point2.Y);
            panel1.Invalidate();
        }

        private void rotationRd_CheckedChanged(object sender, EventArgs e)
        {
            xUpDown.Enabled = false;
            yUpDown.Enabled = false;
            angleUpDown.Enabled = true;
        }

        private void scaleRd_CheckedChanged(object sender, EventArgs e)
        {
            xUpDown.Enabled = true;
            yUpDown.Enabled = true;
            angleUpDown.Enabled = false;
        }

        private void translationRd_CheckedChanged(object sender, EventArgs e)
        {
            xUpDown.Enabled = true;
            yUpDown.Enabled = true;
            angleUpDown.Enabled = false;
        }
    }
}