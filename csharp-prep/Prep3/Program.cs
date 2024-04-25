using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        /* Console.Write("What is the magic number? ");
        string magicNumber = Console.ReadLine(); */

        Console.Write("What is your guess? ");
        string guessNumber = Console.ReadLine();

        Random randomGenerator = new Random();
        int magicNumberInt = randomGenerator.Next(1, 100);
        int guessNumberInt = int.Parse(guessNumber);

    while (guessNumberInt != magicNumberInt)
    {
        if (guessNumberInt >= magicNumberInt)
        {
            Console.WriteLine("Lower");
        }
        else if (guessNumberInt <= magicNumberInt)
        {
            Console.WriteLine("Higher");
        }

        Console.Write("What is your guess? ");
        guessNumber = Console.ReadLine();
        guessNumberInt = int.Parse(guessNumber);
    }
        Console.WriteLine("You guessed it!!! Congratulations");   
    
    }

}