using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = -1;
        while (userChoice != 4)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("\t 1. Start breathing activity");
            Console.WriteLine("\t 2. Start reflecting activity");
            Console.WriteLine("\t 3. Start listing activity");
            Console.WriteLine("\t 4. Quit");
            Console.Write("Select a choice from the menu: ");
            userChoice = int.Parse(Console.ReadLine());

            Console.WriteLine(userChoice);

            // New Object
            BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "0");
            ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "0");
            ListingActivity listingActivity = new ListingActivity("Listing Activity", "reflect on the good things in your life by having you list as many things as you can in a certain area.", "0");

            if (userChoice == 1)
            {
                breathingActivity.Run();
            }
            else if (userChoice == 2)
            {
                reflectingActivity.Run();
            }
            else if (userChoice == 3)
            {
                listingActivity.Run();
            }
        }
       

    }
}