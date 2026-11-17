using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> listNumbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int theNumber = 9999;
        while (theNumber != 0)
        {
            Console.Write("Enter number: ");
            string temproraryTheNumber = Console.ReadLine()?.Trim();
            theNumber = int.Parse(temproraryTheNumber);

            if (theNumber != 0)
            {
                listNumbers.Add(theNumber);
            }
        }

        int total = listNumbers.Sum();
        double average = listNumbers.Average();
        int larger = listNumbers.Max();

        int min = listNumbers.Where(n => n > 0).Min();
        List<int> sortedAscending = listNumbers.OrderBy(n => n).ToList();

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The larger number is: {larger}");
        
        Console.WriteLine($"The smallest positive number is: {min}");

        Console.WriteLine("The sorted list is: ");
        foreach (int number in sortedAscending)
        {
            Console.WriteLine(number);
        }
                
    }
}