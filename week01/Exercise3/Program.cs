using System;
using System.Diagnostics.Contracts;
using System.Runtime.Versioning;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        int guess = 999;

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        while (guess != number)
        {
            Console.Write("What is your guess? ");
            string guessString = Console.ReadLine();
            guess = int.Parse(guessString);

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
            }
        }
    }
}