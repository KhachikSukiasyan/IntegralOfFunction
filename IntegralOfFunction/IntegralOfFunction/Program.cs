using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegralOfFunction
{
    class Program
    {
        public delegate double Function(double x);
        static void Main(string[] args)
        {

            double s = Integrate(Math.Sin, 0, Math.PI / 2);
            Console.WriteLine(s);

            int a = 5;
            int b = 4;
            int c = 10;

            Function polinom = delegate (double x) { return a * x * x + b * x + c; };
            double p = Integrate(polinom,0,20);
            Console.WriteLine(p);
            Console.ReadKey();
        }

        static double Integrate(Function f, double a, double b)
        {
            double min = Math.Min(a,b);
            double max = Math.Max(a, b);
            double step = 0.1;
            double result = 0;

            for (double i = min; i < max; i += step)
            {
                result += f(min + i) * step;
            }

            return result;
        }
    }
}
