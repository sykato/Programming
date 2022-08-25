using System;

namespace lab_7
{
    public class zad_3
    {
        public static int Year(int year)
        {
            if (year <= 0) throw new ArgumentOutOfRangeException();
            bool visokos = (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
            if (visokos == true) return 366;
            else return 365;
        }
    }
}
