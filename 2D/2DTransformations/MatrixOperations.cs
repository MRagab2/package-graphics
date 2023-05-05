using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DTransformations
{
    internal class MatrixOperations
    {

        private static double[,] MatrixArr;
        public static double[,] MatrixRotation(double degreeAngle)
        {
            double radAngle = degreeAngle * Math.PI / 180;
            double sin = Math.Round(Math.Sin(radAngle),2);
            double cos = Math.Round(Math.Cos(radAngle),2);

            MatrixArr = new double[3, 3]{
                {cos, -sin ,0 },
                {sin, cos,0 },
                {0, 0, 1,},};

            return MatrixArr;

        }


        public static double[,] MatrixTranslation(double x, double y)
        {

            MatrixArr = new double[3, 3]
            {
                    {1,0,x},
                    {0,1,y},
                    {0,0,1} };

            return MatrixArr;
        }


        public static double[,] MatrixScaling(double x, double y)
        {

            MatrixArr = new double[3, 3]
            {
                {x,0,0},
                {0,y,0},
                {0,0,1}};
            return MatrixArr;
        }

        public static double[] MultiplyMatrix(double[,] A, double[] B)
        {
    
            double temp = 0;
            double[] result = new double[3];
           
            for (int i = 0; i < 3; i++)
            {
                temp = 0;
                for (int j = 0; j < 3; j++)
                {
                        temp += A[i, j] * B[j];
                }
                    result[i] = temp;
            }
                
            return result;
        }

    }   
}
