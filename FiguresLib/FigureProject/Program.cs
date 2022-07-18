using System;
using System.IO;
using System.Linq;
using FigureLib;

// Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять
//[x] площадь круга по радиусу и треугольника по трем сторонам. 
// Дополнительно к работоспособности оценим:
//[x] Юнит-тесты
//[x] Легкость добавления других фигур
//[x] Вычисление площади фигуры без знания типа фигуры в compile-time
//[x] Проверку на то, является ли треугольник прямоугольным

namespace FigureProject
{
    internal class Program {
        static void Main(string[] args) {
            string fileName = "..\\..\\Input.txt";
            Console.WriteLine("Processing file: Input.txt");

            StreamReader sr = new StreamReader(fileName);
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines) {
                double[] dates = line.Split(' ').Select(x => double.Parse(x)).ToArray();
                if (dates.Length == 1) {
                    double radius = Convert.ToDouble(dates[0]);
                    Console.WriteLine($"Radius = {radius}");

                    Figure circle = new Circle(radius);
                    Console.WriteLine($"Circle Square = {Math.Round(circle.Square(), 3)}");
                }
                else
                    if (dates.Length == 3) {
                        double[] sides = line.Split(' ').Select(x => double.Parse(x)).ToArray();
                        Console.WriteLine($"Sides = {sides[0]}, {sides[1]}, {sides[2]}");

                        Figure triangle = new Triangle(sides[0], sides[1], sides[2]);
                        Console.WriteLine($"Triangle Square = {triangle.Square()}, IsRectangular {((Triangle)triangle).IsRectangular()}");
                    }
            }
                Console.ReadLine();
        }
    }
}
