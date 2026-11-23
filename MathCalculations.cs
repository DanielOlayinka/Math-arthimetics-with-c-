using System;

namespace MathCalculations
{
    public static class Calculator
    {
        // 1) Area methods

        public static double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double TriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        public static double SquareArea(double side)
        {
            return side * side;
        }

        public static double RectangleArea(double length, double width)
        {
            return length * width;
        }

        // 2) Quadratic formula: x = (-b ± √(b² - 4ac)) / 2a
        // Returns both roots. Each root is null when there is no real solution.

        public static (double? Root1, double? Root2) QuadraticFormula(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new ArgumentException("Coefficient 'a' cannot be zero in a quadratic equation.");
            }

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                return (null, null); // No real roots
            }

            double sqrtDiscriminant = Math.Sqrt(discriminant);
            double root1 = (-b + sqrtDiscriminant) / (2 * a);
            double root2 = (-b - sqrtDiscriminant) / (2 * a);

            return (root1, root2);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Circle area (r = 5): " + Calculator.CircleArea(5));
            Console.WriteLine("Triangle area (b = 10, h = 4): " + Calculator.TriangleArea(10, 4));
            Console.WriteLine("Square area (s = 3): " + Calculator.SquareArea(3));
            Console.WriteLine("Rectangle area (l = 6, w = 2): " + Calculator.RectangleArea(6, 2));

            var (root1, root2) = Calculator.QuadraticFormula(1, -3, 2); // x² - 3x + 2 = 0
            Console.WriteLine($"Quadratic roots: {root1}, {root2}");
        }
    }
}
