using System;

namespace Факультатив_ООП_д.з._1
{
    class Program
    {
        static void Main(string[] args)
        {
            float y1, y2, x1, x2, a = -2f, b = 2f, e = 0.001f, min1, min2, max1, max2, X1, X2, X3, X4;
            while(!(Math.Abs(b-a)<e))
            {
                x1 = b - ((b - a) / 1.618f);
                x2 = a + ((b - a) / 1.618f);
                y1 = MathF.Pow(x1 + 1, 3) + (5 * x1 * x1);
                y2 = MathF.Pow(x2 + 1, 3) + (5 * x2 * x2);
                if (y1 >= y2)
                    a = x1;
                else
                    b = x2;
            }
            X1 = (a + b) / 2;
            min1 = MathF.Pow(X1 + 1, 3) + (5 * MathF.Pow(X1, 2));
            a = -2f; b = 2f;
            while (!(Math.Abs(b - a) < e))
            {
                x1 = b - ((b - a) / 1.618f);
                x2 = a + ((b - a) / 1.618f);
                y1 = MathF.Pow(x1 + 1, 3) + (5 * x1 * x1);
                y2 = MathF.Pow(x2 + 1, 3) + (5 * x2 * x2);
                if (y1 <= y2)
                    a = x1;
                else
                    b = x2;
            }
            X2 = (a + b) / 2;
            max1 = MathF.Pow(X2 + 1, 3) + 5 * MathF.Pow(X2, 2);
            a = -8f;b = 0f;
            while (!(Math.Abs(b - a) < e))
            {
                x1 = b - ((b - a) / 1.618f);
                x2 = a + ((b - a) / 1.618f);
                y1 = MathF.Pow(x1 + 1, 3) + (5 * x1 * x1);
                y2 = MathF.Pow(x2 + 1, 3) + (5 * x2 * x2);
                if (y1 >= y2)
                    a = x1;
                else
                    b = x2;
            }
            X3 = (a + b) / 2;
            min2 = MathF.Pow(X3 + 1, 3) + (5 * MathF.Pow(X3, 2));
            a = -8f; b = 0f;
            while (!(Math.Abs(b - a) < e))
            {
                x1 = b - ((b - a) / 1.618f);
                x2 = a + ((b - a) / 1.618f);
                y1 = MathF.Pow(x1 + 1, 3) + (5 * x1 * x1);
                y2 = MathF.Pow(x2 + 1, 3) + (5 * x2 * x2);
                if (y1 <= y2)
                    a = x1;
                else
                    b = x2;
            }
            X4 = (a + b) / 2;
            max2 = MathF.Pow(X4 + 1, 3) + (5 * MathF.Pow(X4, 2));
            Console.Write($"Экстремумы для функции f(x)=(x+1)^3+5*x^2:\n[-2;2]\n  max: {max1:0.000} при x: {X1:0.000}\n  min: {min1:0.000} при x: {X2:0.000}\n[-8;0]\n  max: {max2:0.000} при x: {X3:0.000}\n  min: {min2:0.000} при x: {X4:0.000}");
        }
    }
}
