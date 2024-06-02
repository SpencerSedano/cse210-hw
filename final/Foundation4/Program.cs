using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(100, "28/03/2023", 90);
        Console.WriteLine(running.GetActivitySummary());

        Console.WriteLine("");

        Swimming swimming = new Swimming(50, "5/6/2024", 90);
        Console.WriteLine(swimming.GetActivitySummary());

        Console.WriteLine("");

        Biking biking = new Biking(150, "30/01/2024", 60);
        Console.WriteLine(biking.GetActivitySummary());
    }
}