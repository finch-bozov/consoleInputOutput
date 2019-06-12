using System;

namespace sumOfNumbers
{
    class sumOfNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many digits do you want to add: ");
            int numOfNums = int.Parse(Console.ReadLine());
            double sumOfNumbers = 0;
                for (int i = 1; i < numOfNums + 1; i++)
                {
                    double num = double.Parse(Console.ReadLine());
                    sumOfNumbers += num;
                }
            Console.WriteLine(sumOfNumbers);
        }
    }
}
