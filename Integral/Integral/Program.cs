using System;

namespace Integral
{
    class Program
    {
        static void Main(string[] args)
        {
            double from = 0;
            double to = 3;
            var integral = Integral(from, to);
            Console.WriteLine(integral);
            Console.ReadKey();
        }

        static double Integral(double from, double to)
        {
            double h = Math.Pow(10, -6);
            int d = (int)((to - from) / h);
            h = (to - from) / d;
            double s = 0;
            for (double x = from; x < to; x += h)
            {
                s += h * f(x);
            }
            return s;
        }

        static double f(double x)
        {
            return x*x;
        }
    }
}
