using FigureLib;

namespace FigureLibTests {
    [TestFixture]
    public class CircleTests {
        public static TestCaseData[] CirclesBase = new[] {
            new TestCaseData(1, 3.142).SetName("radius: 1 -> square = 3.142"),
            new TestCaseData(3, 28.274).SetName("radius: 3 -> square = 28.274"),
            new TestCaseData(5, 78.54).SetName("radius: 5 -> square = 78.54"),
        };

        [TestCaseSource(typeof(CircleTests), nameof(CirclesBase))]
        public void CircleSquareTest(double radius, double expected) {
            Circle circle = new Circle(radius);
            Assert.That(Math.Round(circle.Square(), 3), Is.EqualTo(expected));
        }
    }
}