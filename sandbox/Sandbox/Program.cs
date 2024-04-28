using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        Blind kitchen = new Blind();

        kitchen._width = 60;
        kitchen._height = 80;
        kitchen._color = "White";

        double materialAmount = kitchen.GetArea();

        Console.WriteLine("Area is: " + materialAmount);
        
    }
}

public class Blind
{
    public double _width;
    public double _height;
    public string _color;

    public double GetArea()
    {
        return _width * _height;
    }
}

