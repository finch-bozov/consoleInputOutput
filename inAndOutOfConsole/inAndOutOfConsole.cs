using System;
using System.Text; //za wtf simvoli
using System.Threading; //
using System.Globalization; //

namespace inAndOutOfConsole
{
    class inAndOutOfConsole
    {
        static void Main(string[] args)
        {
            /*Console.Read();     // reads a single char
            Console.ReadKey();  // reads a key or combination of keys
            Console.Write("Gosho"); // writes on single line
            Console.WriteLine(); // new line without anything written on it*/

            double a = 5;
            int b = 10;
            Console.WriteLine("{0, -10} {1, 109}", a, b);

            string drinkNameOne = "Vodka";
            string drinkNameTwo = "Whiskey";

            double drinkPriceOne = 10.45512;
            double drinkPriceTwo = 19.5553;

            string formattedText = "{0,-7} = лв.{1,3:C}"; // instead of writing it a thousand times like a retard ":" formats text in different ways (C(currency), P (percent), X(hex), F3(replacement of 0.000)
            Console.WriteLine(formattedText, drinkNameOne, drinkPriceOne);
            Console.WriteLine(formattedText, drinkNameTwo, drinkPriceTwo);

            Console.WriteLine("Finch".PadLeft(32, '0'));

            //int symbol = Console.Read();5
            //Console.WriteLine("Symbol: " + (char)symbol);
            //char ch = (char)symbol; // casts int i to char

            Console.Write("Press any key: \n");
            ConsoleKeyInfo thiIsMyKey = Console.ReadKey();
            Console.WriteLine("Key was: " + thiIsMyKey.Key);
            Console.WriteLine("Modifiers: " + thiIsMyKey.Modifiers);

            /*if (thiIsMyKey.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("Evala!");
            }*/
            // int inputNumber = int.Parse(Console.ReadLine()); //goes straight to parse
            Console.Write("Input your number a: ");
            int inputA = int.Parse(Console.ReadLine());
            Console.Write("Input number b: ");
            int inputB = int.Parse(Console.ReadLine());
            Console.WriteLine("Result is {0}", inputA + inputB);

            Console.Write("Type text/number for Try Parse: ");
            string tryingMyText = Console.ReadLine();
            int tryingToParse;
            bool isParsed = int.TryParse(tryingMyText, out tryingToParse);
            string resultOfParse = isParsed ? "Valid" : "Invalid";
            Console.WriteLine(resultOfParse);

            Console.Write("This is the if/else: ");
            string numberOrText = Console.ReadLine();
            int numberForLoop;

            bool parsingBoolForLoop = int.TryParse(numberOrText, out numberForLoop);
            if(parsingBoolForLoop)
            {
                Console.WriteLine("Number is: {0}", numberForLoop);
            }
            else
            {
                Console.WriteLine("Invalid Number!");
            }

            Console.OutputEncoding = Encoding.UTF8; //za wtf simvoli
            Console.WriteLine("Гошо");

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; // global decimal points "."
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("                     ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("                     ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("                     ");
            Console.BackgroundColor = ConsoleColor.Black;
            /*Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Red Shit Bro");*/
        }
    }
}