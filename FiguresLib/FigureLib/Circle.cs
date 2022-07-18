using System;

namespace FigureLib {
    public class Circle : Figure {
        double radius;
        public Circle(double radius) {
            this.radius = radius;
        }
        override public double Square() {
            try {
                if (radius <= 0) throw new Exception("unexpectable radius");
                return Math.PI * Math.Pow(radius, 2);
            }
            catch (Exception ex) {
                Console.WriteLine($"Exception: {ex.Message}");
                throw;
            }
        }
    }
}
