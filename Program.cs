using System;

namespace NumberGuesser
{
    internal class Program
    {
        static void Main()
        {
            while (true) {

            Console.WriteLine("Hello. In this game you need to guess the number between 1 and 10. Please enter your number:");

                int guess = 0;

                var random = new Random();

                int correctNumber = random.Next(1, 10);

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        ChangeConsoleColor(ConsoleColor.Red, "Enter an integer, please");
                    } else
                    {
                        guess = Int32.Parse(input);

                        if (guess != correctNumber)
                        {
                            ChangeConsoleColor(ConsoleColor.Red, "Not correct. Try again");
                        }
                    }

                }

                ChangeConsoleColor(ConsoleColor.Green, "Correct, well done!");

                Console.WriteLine("Do you want to play again (Y/N)?");

                string question = Console.ReadLine().ToUpper();

                if (question == "Y")
                {
                    continue;
                } else
                {
                    return;
                }
            }
        }
        static void ChangeConsoleColor(ConsoleColor col, string message)
        {
            Console.ForegroundColor = col;
            Console.WriteLine(message);
            Console.ResetColor ();
        }
    }
}
