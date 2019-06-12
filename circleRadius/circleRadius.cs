using System;

namespace circleRadius
{
    class circleRadius
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the Radius of your circle: ");
            double circleRadius = double.Parse(Console.ReadLine());
            double perimeterOfCircle = (2 * (3.141592 * circleRadius));
            double areaOfCircle = (3.141592 * (circleRadius * circleRadius));
            Console.WriteLine("The perimeter of the circle is {0,0:0.00}", perimeterOfCircle);
            Console.WriteLine("The area of the circle is {0,0:0.00}", areaOfCircle);
        }
    }
}
