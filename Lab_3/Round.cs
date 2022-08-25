using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graf
{
    class Round : Brush
    {
        public Round(Color brashColor, int size)
          : base(brashColor, size)
        {
        }
        public override void Draw(Bitmap image, int x, int y)
        {
            for (int i=0; i<=360; i++)
            {
                int x0 = (int)(Size * Math.Cos(i)+x);
                int y0 = (int)(Size * Math.Sin(i)+y);
                image.SetPixel(x0, y0, BrushColor);
            }
        }
    }
}
