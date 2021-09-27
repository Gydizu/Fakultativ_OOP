using System;

namespace Finding_the_Extremum
{
    class FindingMaxByGR
    {
        private const double PHI = 1.6180339887498949;
        private const double E = 0.001;
        static public double Function(double x/*, string function*/) => Math.Pow(x + 1, 3) + (5 * Math.Pow(x, 2));
        static public double CalculatorMax(double a, double b/*, string function*/)
        {

            while (!(Math.Abs(b - a) < E))
                if (Function((b - ((b - a) / PHI))/*, function*/)<=Function((a + ((b - a) / PHI))/*,function*/))
                    a = b - ((b - a) / PHI);
                else
                    b = a + ((b - a) / PHI);
            return (Function((a + b) / 2));
        }
        static public double CalculatorMin(double a, double b/*, string function*/)
        {
            while (!(Math.Abs(b - a) < E))
                if (Function((b - ((b - a) / PHI))) >= Function((a + ((b - a) / PHI))))
                    a = b - ((b - a) / PHI);
                else
                    b = a + ((b - a) / PHI);
            return (Function((a + b) / 2));
        }
    }
}
