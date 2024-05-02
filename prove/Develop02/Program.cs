using System;
using System.Globalization;
class Program
{   
    
    static void Main(string[] args)
    {
        /* List<Entry> entries = new List<Entry>(); */

        Journal journal = new Journal();

        int userInput = 0;

        while (userInput != 5)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            userInput = int.Parse(Console.ReadLine());


            if (userInput == 1)
            {
                journal.AddEntry();
/*                 PromptGenerator promptGenerator = new PromptGenerator();
                string randomPrompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine("Random Prompt: " + randomPrompt);
                
                string userWrite = Console.ReadLine(); */
            
                /* Entry entry = new Entry();

                entry._date = DateTime.Now;
                entry._promptText = randomPrompt;
                entry._entryText = userWrite;

                entries.Add(entry); */
            }

            if (userInput == 2)
            {
                journal.DisplayAll();
                /* foreach (Entry text in entries)
                {
                    Console.WriteLine($"{text._date}, Prompt: {text._promptText}, Entry: {text._entryText}");
                } */
            }
            if (userInput == 3)
            {
                journal.LoadFromFile();
                /* Console.WriteLine("Reading List from file...");
                Console.WriteLine("Filename: ");
                string userFileName = Console.ReadLine();
                string filename = userFileName + ".txt";

                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");
                    string format = "M/d/yyyy h:mm:ss tt";
                    Entry newEntry = new Entry();
                    newEntry._date = DateTime.ParseExact(parts[0], format, CultureInfo.InvariantCulture);
                    newEntry._promptText = parts[1];
                    newEntry._entryText = parts[2];

                    entries.Add(newEntry);
                } */

            }
            if (userInput == 4)
            {
                journal.SaveToFile();
               /*  Console.Write("Filename: ");
                string userFileName = Console.ReadLine(); 
                string filename = userFileName + ".txt";

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (Entry write in entries )
                    {
                        outputFile.WriteLine($"{write._date}, Prompt: {write._promptText}, Entry: {write._entryText}");
                    }
                } */
            }
        }
       
    }
}