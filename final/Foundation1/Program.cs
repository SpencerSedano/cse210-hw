using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating 3 videos objects
        Video videoOne = new Video("How To Learn C#", "Bro Code", 2400);
        Video videoTwo = new Video("Best Places To Travel in The World", "The Traveler", 4000);
        Video videoThree = new Video("Logitech Pebble Mouse 2 Review", "Tech Review", 2000);

        Console.WriteLine(videoOne.DisplayVideoInfo());
        Console.WriteLine(videoTwo.DisplayVideoInfo());
        Console.WriteLine(videoThree.DisplayVideoInfo());

        
    }
}