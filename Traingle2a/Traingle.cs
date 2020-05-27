using System;
using System.Collections.Generic;
using System.Text;

namespace Traingle2a
{
    class Traingle
    {
        public double a, b, c; double P;
        public Traingle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public virtual bool ExistTriangle()
        {
            return ((a + b < c) || (b + c > a) || (c + a > b));
        }
        public void ShowInfo()
        {
            Console.WriteLine("1 сторона {0}", a);
            Console.WriteLine("2 сторона {0}", b);
            Console.WriteLine("3 сторона {0}", c);

        }
        public virtual double Perimetr()
        {
            P = a + b + c;
            Console.WriteLine("Периметр: {0}", P);
            return P;
        }
        public virtual double Square()
        {
            double S = Math.Sqrt(P * (P - a) * (P - c) * (P - b));
            Console.WriteLine("Площадь: {0}", S);
            return S;
        }
        public virtual void Degree()
        {
            double A = Math.Acos(Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c);
            double B = Math.Acos(Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c);
            double C = Math.Acos(Math.Pow(b, 2) + Math.Pow(a, 2) - Math.Pow(c, 2)) / (2 * b * a);
            Console.WriteLine("Угол B {0}", B);
            Console.WriteLine("Угол C {0}", C);
            Console.WriteLine("Угол А {0}", A);
        }

    }
}
