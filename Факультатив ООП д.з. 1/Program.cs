using System;

namespace Finding_the_Extremum
{
    class MainProgram
    {
        static void Main()
        {
            float a, b;
            //string function;
            //Console.Write("Введите исследуемую фукцию: ");
            //function = Console.ReadLine();
            //Console.Write("Введите исследуемые границы: ");
            //a = Console.Read();
            //b = Console.Read();
            a = -2;
            b = 2;
            Console.WriteLine($"Экстремумы (методом Золотого сечения) для функции f(x)=(x+1)^3+5*x^2:\n{FindingMaxByGR.CalculatorMax(a, b/*, function*/):0.000} - максимум функции на отрезке [{a};{b}]\n{FindingMaxByGR.CalculatorMin(a, b/*, function*/):0.000} - минимум функции на отрезке [{a};{b}]");
            Console.WriteLine();
            Console.WriteLine($"Экстремумы (дихотомическим методом) для функции f(x)=(x+1)^3+5*x^2:\n{Find_ext_by_dih.Calculate_Max(a, b/*, function*/):0.000} - максимум функции на отрезке [{a};{b}]\n{Find_ext_by_dih.Calculate_Min(a, b/*, function*/):0.000} - минимум функции на отрезке [{a};{b}]");
            Console.WriteLine();
            Console.WriteLine();
            a = -8;
            b = 0;
            Console.WriteLine($"Экстремумы (методом Золотого сечения) для функции f(x)=(x+1)^3+5*x^2:\n{FindingMaxByGR.CalculatorMax(a, b/*, function*/):0.000} - максимум функции на отрезке [{a};{b}]\n{FindingMaxByGR.CalculatorMin(a, b/*, function*/):0.000} - минимум функции на отрезке [{a};{b}]");
            Console.WriteLine();
            Console.WriteLine($"Экстремумы (дихотомическим методом) для функции f(x)=(x+1)^3+5*x^2:\n{Find_ext_by_dih.Calculate_Max(a, b/*, function*/):0.000} - максимум функции на отрезке [{a};{b}]\n{Find_ext_by_dih.Calculate_Min(a, b/*, function*/):0.000} - минимум функции на отрезке [{a};{b}]");
        }
    }
}
