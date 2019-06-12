using System;

namespace numberComparer
{
    class numberComparer
    {
        static void Main(string[] args)
        {
            Console.Write("Type your first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Type your second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            double resultOne = firstNumber > secondNumber ? firstNumber : secondNumber;
            Console.WriteLine(resultOne);
        }
    }
}
