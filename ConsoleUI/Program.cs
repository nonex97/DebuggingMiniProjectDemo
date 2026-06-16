using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            double i = W(0);
            Console.WriteLine(i);
            Console.ReadLine();
        }

        private static double W(double e)
        {
            double n = 1;

            n = J(e) + 4;

            return n;
        }

        private static double P(double v)
        {
            double o = 0;

            o = F(v) + 2;

            return o;
        }

        private static double F(double x)
        {
            double y = 0;

            y = x / 5;

            return y;
        }

        private static double J(double a)
        {
            double c = 0;

            a = a - 1;

            c = R(a);

            c = P(c) / 3;

            return c;
        }

        private static double R(double v)
        {
            double z = 5;

            z = 3 / v;

            return z;
        }
    }
}
