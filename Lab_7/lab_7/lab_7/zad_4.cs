using System;
using System.Text.RegularExpressions;

namespace lab_7
{
    public class zad_4
    {
        public bool Mail(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException("text");
            }
            Regex regex = new Regex(@"^([a-zA-Z0-9]{2,})@([a-z]{2,})\.([a-z]{2,})$");
            return regex.IsMatch(text);
        }
    }
}
