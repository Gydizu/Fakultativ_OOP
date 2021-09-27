using System;

namespace Finding_the_Extremum
{
    class Find_ext_by_dih
    {
        private const double E = 0.001;
        static public double Function(double x/*, string function*/) => Math.Pow(x + 1, 3) + (5 * Math.Pow(x, 2));
        static public double Calculate_Min(double a, double b/*, string function*/)
        {
            while(!(Math.Abs(b-a)<E))
                if (Function(((a + b) / 2) - E) < Function(((a + b) / 2) + E))
                    b = (a + b) / 2;
                else
                    a = (a + b) / 2;
            return (Function((a + b) / 2));
        }
        static public double Calculate_Max(double a, double b/*, string function*/)
        {
            while (!(Math.Abs(b - a) < E))
                if (Function(((a + b) / 2) - E) > Function(((a + b) / 2) + E))
                    b = (a + b) / 2;
                else
                    a = (a + b) / 2;
            return (Function((a + b) / 2));
        }
    }
}
