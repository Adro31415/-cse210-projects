using System;

class Program
{
    static void Main(string[] args)
    {
        
        /*takes the user's input and transforms it into float values */
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        float gradePercentageFloat = float.Parse(gradePercentage);

        string letter = "";
        
        if (gradePercentageFloat >= 90)
        {
            letter = "A";
        }
        else if (gradePercentageFloat >= 80)
        {
            letter = "B";
        }
        else if (gradePercentageFloat >= 70)
        {
            letter = "C";
        }
        else if (gradePercentageFloat >= 60)
        {
            letter = "D";
        }
        else if (gradePercentageFloat < 60)
        {
            letter = "F";
        }
        else
        {
            Console.WriteLine("Try again");
        }
        
        Console.WriteLine($"Your letter grade is: {letter}");

        if (gradePercentageFloat >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("You failed this time, but don't give up, next time you'll succeed");
        }



    }
}