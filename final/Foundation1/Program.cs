using System;

class Program
{
    static void Main(string[] args)
    {
        Video video = new Video("How To Learn C#", "Bro Code", 2400);
        Console.WriteLine(video.DisplayVideoAndComments());
    }
}