using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graf
{
    class Spray : Brush
    {
        public Spray(Color brashColor, int size)
            : base(brashColor, size)
        {
        }
        public override void Draw(Bitmap image, int x, int y)
        {
            Random r = new Random();
            for (int y0 = y - Size; y0 < y + Size; ++y0)
            {
                for (int x0 = x - Size; x0 < x + Size; ++x0)
                {
                    if(r.NextDouble() <= 0.2)
                    {
                        image.SetPixel(x0, y0, BrushColor);
                    }
                    
                }
            }
        }
    }
}
