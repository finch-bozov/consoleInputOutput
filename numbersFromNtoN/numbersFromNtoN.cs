using System;

namespace numbersFromNtoN
{
    class numbersFromNtoN
    {
        static void Main(string[] args)
        {
            Console.Write("Type in your desired N number: ");
            int userNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i < userNumber + 1; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
