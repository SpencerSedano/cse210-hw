using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        /* Console.WriteLine("Hello Prep2 World!"); */

        Console.Write("What is your grade percentage? ");
        string userGrade = Console.ReadLine();
        int userGradeInt = int.Parse(userGrade);

        string letter;

        if (userGradeInt >= 90)
        {
            letter = "A";
        }
        else if (userGradeInt >= 80)
        {
            letter = "B";
        }
        else if (userGradeInt >= 70) 
        {
            letter = "C";
        }
        else if (userGradeInt >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (userGradeInt >= 70)
        {
            Console.WriteLine("You PASSED!");
        }
        else
        {
            Console.WriteLine("You almost had it, try harder next time!");
        }
    }
}