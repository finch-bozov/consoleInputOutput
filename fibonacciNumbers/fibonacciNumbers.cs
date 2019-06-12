using System;

namespace fibonacciNumbers
{
    class fibonacciNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("How many fibonacci shit? ");
            long howManyNumbers = int.Parse(Console.ReadLine());
            long n1 = 1;
            long n2 = 0;
            for (long i = 0; i < howManyNumbers + 1; i ++)
            {
                long n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                Console.Write("{0}, ", n3);
            }
        }
    }
}
