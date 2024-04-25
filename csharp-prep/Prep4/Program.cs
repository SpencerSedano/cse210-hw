using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        /* Console.WriteLine("Hello Prep4 World!"); */

        List<int> numbers = new List<int>();

        Console.Write("Enter number: ");
        string userInput = Console.ReadLine();
        int userInputInt = int.Parse(userInput);

        while (userInputInt != 0)
        {
            numbers.Add(userInputInt);

            Console.Write("Enter number: ");
            userInput = Console.ReadLine();
            userInputInt = int.Parse(userInput);
        }

        int sumResult = 0;
        foreach (int number in numbers )
        {
            sumResult += number;
  
        }

        int sizeList = numbers.Count; 

        Console.WriteLine($"The sum is: {sumResult}");
        Console.WriteLine($"The average: {(float)sumResult / sizeList}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");

    }
}