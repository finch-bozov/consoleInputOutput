using System;

namespace sumOfFiveNumbers
{
    class sumOfFiveNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Type in your first number    = ");
            double numbers1 = double.Parse(Console.ReadLine());
            Console.Write("Type in your second number   = ");
            double numbers2 = double.Parse(Console.ReadLine());
            Console.Write("Type in your third number    = ");
            double numbers3 = double.Parse(Console.ReadLine());
            Console.Write("Type in your fourth number   = ");
            double numbers4 = double.Parse(Console.ReadLine());
            Console.Write("Type in your fifth number    = ");
            double numbers5 = double.Parse(Console.ReadLine());
            Console.WriteLine("The sum of the five numbers you specified is = {0}", numbers1 + numbers2 + numbers3 + numbers4 + numbers5);
        }
    }
}
