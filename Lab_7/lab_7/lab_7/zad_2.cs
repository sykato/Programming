using System;

namespace lab_7
{
    public class zad_2
    {
        public double[] Equation(double a, double b, double c)
        {
            if (a == 0) throw new ArgumentException();
            double d = b * b - 4 * a * c;
            if (d > 0)
            {
                double[] arr = new double[2];
                arr[0] = (-b + Math.Sqrt(d)) / (2 * a);
                arr[1] = (-b - Math.Sqrt(d)) / (2 * a);
                return arr;
            }
            if (d == 0)
            {
                double[] arr = new double[1];
                arr[0] = -b / (2 * a);
                return arr;
            }
            if (d < 0) throw new ArgumentException();
            return Array.Empty<Double>();
        }
    }
}
