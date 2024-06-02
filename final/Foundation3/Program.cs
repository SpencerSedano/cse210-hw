using System;

class Program
{
    static void Main(string[] args)
    {
        // Lecture Object
        Address addressLecture = new Address("Great Street", "Cali City", "Cali Province", "COL");
        Lecture lecture = new Lecture("Bob the Builder", 200, "Learn Blazor", "Strong Framework", "1/1/2025", "8:00am", addressLecture);

        Console.WriteLine(lecture.GetStandardDetails());

        Console.WriteLine("");

        Console.WriteLine(lecture.GetFullDetails());

        Console.WriteLine("");

        Console.WriteLine(lecture.GetShortDescription());

        // Some Space
        Console.WriteLine("------------------------");

        // Reception Object
        Address addressReception = new Address("Main Street 333", "Buenos Aires", "Buenos Aires Province", "ARG");
        Reception reception = new Reception("rob@gmail.com", "2000 Class", "Senior High School Meeting After 24 years", "2/5/2024", "6:00pm", addressReception);

        Console.WriteLine(reception.GetStandardDetails());

        Console.WriteLine("");

        Console.WriteLine(reception.GetFullDetails());

        Console.WriteLine("");

        Console.WriteLine(reception.GetShortDescription());

         // Some Space
        Console.WriteLine("------------------------");

        // Reception Object
        Address addressOutdoor = new Address("Taiwan Dadao 200 Section 3", "Shilin", "Taipei", "TW");
        Outdoor outdoor = new Outdoor("Very Nice Sunny Day", "Taipei Elephant Mountain", "Get to know the most famous places of Taipei", "8/7/2025", "3:00pm", addressOutdoor);

        Console.WriteLine(outdoor.GetStandardDetails());

        Console.WriteLine("");

        Console.WriteLine(outdoor.GetFullDetails());

        Console.WriteLine("");

        Console.WriteLine(outdoor.GetShortDescription());

    
    
    }

}