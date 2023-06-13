// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        Console.Write("Hello " + name + "! " + "Do you want to do the COIN FLIP CHALLENGE? (Yes/No) ");
        string challenge = Console.ReadLine();

        if (challenge.ToLower() == "no")
        {
            Console.WriteLine("You are a coward " + name + ".");
        }
        else if (challenge.ToLower() == "yes")
        {
            Console.WriteLine("Welcome " + name + ". " + "Let's begin the COIN FLIP CHALLENGE!");

            int score = 0;
            Random coinFlip = new Random();

            for (int i = 0; i < 5; i++)
            {
                int result = coinFlip.Next(0, 2);

                Console.Write("Heads or Tails? ");
                string userGuess = (Console.ReadLine()).ToLower();

                if (userGuess == "heads" || userGuess == "tails")
                {
                    if ((result == 0 && userGuess == "heads") || (result == 1 && userGuess == "tails"))
                    {
                        score++;
                        Console.WriteLine("Correct!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong!");
                    }
                }
                else
                {
                    i--;
                    Console.WriteLine("Invalid input. Please enter either 'Heads' or 'Tails'.");
                }
            }

            Console.WriteLine("Thank you " + name + ". " + "You got a score of " + score + "!");
        }
        else { Console.WriteLine("Please enter Yes or No"); }
    }
}
