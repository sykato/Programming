using System;
using System.Text;

namespace lab_7
{
    public class zad_1
    {
        public string Print(int N)
        {
            if (N < 1 && N > 26) throw new ArgumentException();
            StringBuilder summ = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                summ.Append((char)('A' + i));
            }
            return summ.ToString();
        }
    }
}
