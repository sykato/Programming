using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    public class sinusoidalEquation : Equation
    {
        public double a;
        public sinusoidalEquation(double a)
        {
            this.a = a;
        }
        public override double GetValue(double x)
        {
            return a * x * Math.Abs(Math.Sin(x));
        }
    }
}
