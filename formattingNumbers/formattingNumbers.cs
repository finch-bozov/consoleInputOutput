using System;

namespace formattingNumbers
{
    class formattingNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Input number a (Hex and Binary): ");
            int numberA = int.Parse(Console.ReadLine());
            string numberAa = Convert.ToString(numberA, 2);
            Console.Write("Input number b(2 digits after decimal): ");
            float numberB = float.Parse(Console.ReadLine());
            Console.Write("Input number c(3 digits after decimal): ");
            float numberC = float.Parse(Console.ReadLine());
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" ===================================================");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("|    A       |     B      |      C     |      D     |");
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" ===================================================");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("| {0,-10:X} | {1,-10:2} | {2,-10:0.00} | {3,-10:0.000} |", numberA, numberAa, numberB, numberC);
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" ===================================================");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
