using System;
using System.Text;
using System.Text.RegularExpressions;

namespace lab_7
{
    public class zad_5
    {
        public int Summ(string text)
        {
            int summ = 0;
            text = text.Trim();
            if (string.IsNullOrEmpty(text)) throw new ArgumentNullException("text");
            for (int i = 0; i < text.Length; i++)
            {
                char.IsDigit(text, i);
                if (char.IsDigit(text, i) != true) throw new Exception();
                summ += int.Parse(text[i].ToString());
            }
            return summ;
        }
    }
}
