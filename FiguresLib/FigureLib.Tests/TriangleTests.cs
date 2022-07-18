using FigureLib;

namespace FigureLibTests {
    [TestFixture]
    public class TriangleTests {

        public static TestCaseData[] TrianglesBase = new[] {
            new TestCaseData(2, 3, 4, 2.905).SetName("sides: 2, 3, 4 -> square = 2.905"),
            new TestCaseData(3, 4, 5, 6).SetName("sides: 3, 4, 5 -> square = 6"),
            new TestCaseData(5, 6, 7, 14.697).SetName("sides: 5, 6, 7 -> square = 14.697"),
        };

        [TestCaseSource(typeof(TriangleTests), nameof(TrianglesBase))]
        public void TriangleSquareTest(double a, double b, double c, double expected) {
            Triangle triangle = new Triangle(a, b, c);
            Assert.That(Math.Round(triangle.Square(), 3), Is.EqualTo(expected));
        }

        public static TestCaseData[] TrianglesIsRectangularBase = new[] {
            new TestCaseData(2, 3, 4, false).SetName("sides: 2, 3, 4 -> Is Not Rectangular"),
            new TestCaseData(3, 4, 5, true).SetName("sides: 3, 4, 5 -> Is Rectangular"),
        };

        [TestCaseSource(typeof(TriangleTests), nameof(TrianglesIsRectangularBase))]
        public void TriangleIsRectangularTest(double a, double b, double c, bool expected) {
            Triangle triangle = new Triangle(a, b, c);
            Assert.That(triangle.IsRectangular(), Is.EqualTo(expected));
        }

        public static TestCaseData[] TrianglesExBase = new[] {
            new TestCaseData(0, 3, 4, "unexpectable side(s)").SetName("sides: 0, 3, 4 -> unexpectable side(s)")
        };

        [TestCaseSource(typeof(TriangleTests), nameof(TrianglesExBase))]
        public void TriangleExTest(double a, double b, double c, string expected) {
            try {
                (new Triangle(a, b, c)).Square();
            }
            catch (Exception ex) {
                Assert.That(ex.Message, Is.EqualTo(expected));
            }
        }
    }
}