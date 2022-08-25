using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    public class quadraticEquation : Equation
    {
        public double a;
        public double b;
        public double c;

        public quadraticEquation (double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override double GetValue(double x)
        {
            return a * x * x + b * x + c;
        }
    }
}
