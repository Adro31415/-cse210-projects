using System;
using System.Diagnostics.Contracts;
using System.Runtime.Versioning;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        int guess = 999;

        int numberOfTrys = 0;
        string playAgain = "yes";

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);                                
    
        while (playAgain == "yes")
        {
            
            Console.Write("What is your guess? ");
            string guessString = Console.ReadLine();
            guess = int.Parse(guessString);

            numberOfTrys += 1;


            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"You took {numberOfTrys} times to guess it right!");
                Console.WriteLine("Do you want to play again? Yes/No");
                playAgain = Console.ReadLine()?.Trim().ToLower();

                if (playAgain == "yes")
                {
                    Random newRandomGenerator = new Random();
                    number = newRandomGenerator.Next(1, 100);

                    numberOfTrys = 0;                               
                }

                if (playAgain == "no")
                {
                    Console.WriteLine("Thank you for playing!");
                }
            }
        }
    }
}