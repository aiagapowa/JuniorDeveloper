using System;

namespace FigureLib {
    public class Triangle : Figure {
        const double eps = 1e-10;
        double a;
        double b;
        double c;
        public Triangle(double a, double b, double c) {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        override public double Square() {
            try {
                double p = 0.5 * (a + b + c);
                if ((a <= 0) | (b <= 0) | (c <= 0)) throw new Exception("unexpectable side(s)");
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            catch (Exception ex) {
                Console.WriteLine($"Exception: {ex.Message}");
                throw;
            }
        }
        public bool IsRectangular() {
            return (Math.Abs(Math.Pow(a, 2) - Math.Pow(b, 2) - Math.Pow(c, 2)) < eps)
                | (Math.Abs(Math.Pow(b, 2) - Math.Pow(c, 2) - Math.Pow(a, 2)) < eps)
                | (Math.Abs(Math.Pow(c, 2) - Math.Pow(a, 2) - Math.Pow(b, 2)) < eps);
        }
    }
}
