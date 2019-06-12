using System;

namespace sumOfThreeNumbers
{
    class sumOfThreeNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in your first integer: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Type in your first integer: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Type in your first integer: ");
            double thirdNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("The sum of the three numbers is {0}", (firstNumber + secondNumber + thirdNumber));
        }
    }
}
