using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating 3 videos objects
        Video videoOne = new Video("How To Learn C#", "Bro Code", 2400);
        Video videoTwo = new Video("Best Places To Travel in The World", "The Traveler", 4000);
        Video videoThree = new Video("Logitech Pebble Mouse 2 Review", "Tech Review", 2000);

        videoOne.AddComment("Spencer", "Thank you for the great explanation");
        videoOne.AddComment("Tom", "Now I can understand C#!");
        videoOne.AddComment("Liam", "Thank you for making this content");
        Console.WriteLine(videoOne.DisplayVideoInfo());
        Console.WriteLine($"Comments: ({videoOne.GetNumberOfComments()})");
        Console.WriteLine(videoOne.DisplayComments());

        Console.WriteLine("");


        videoTwo.AddComment("Maria", "I really want to go to that place!!!");
        videoTwo.AddComment("Peter", "I can't wait for the next video, way to go!");
        videoTwo.AddComment("Alex", "Good job");
        Console.WriteLine(videoTwo.DisplayVideoInfo());
        Console.WriteLine($"Comments: ({videoTwo.GetNumberOfComments()})");
        Console.WriteLine(videoTwo.DisplayComments());
        Console.WriteLine("");


        videoThree.AddComment("Eduardo", "Now I am clear that I want to get that mouse");
        videoThree.AddComment("Diego", "I think it's too expensive for not so many features");
        videoThree.AddComment("Lourdes", "I just got it, I recommend it");
        Console.WriteLine(videoThree.DisplayVideoInfo());
        Console.WriteLine($"Comments: ({videoThree.GetNumberOfComments()})");
        Console.WriteLine(videoThree.DisplayComments());


        

        
    }
}