using System;

namespace quadraticEquation
{
    class quadraticEquation
    {
        static void Main(string[] args)
        {
            Console.Write("Type int a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Type int b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Type int c: ");
            double c = double.Parse(Console.ReadLine());
            double discriminant = ((b * b) - (4 * a * c));
            Console.WriteLine("Discriminant = {0}", discriminant);
            double xOne = ((-b - Math.Sqrt(discriminant)) / (2 * a));
            double xTwo = ((-b + Math.Sqrt(discriminant)) / (2 * a));
            Console.WriteLine("x1 = {0}; x2 = {1}", xOne, xTwo);
        }
    }
}
