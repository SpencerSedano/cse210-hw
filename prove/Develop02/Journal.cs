using System.Globalization;

class Journal 
{
  public List<Entry> _entries = new List<Entry>();

  public void AddEntry()
  {
    PromptGenerator promptGenerator = new PromptGenerator();
    string randomPrompt = promptGenerator.GetRandomPrompt();

    Console.WriteLine("Random Prompt: " + randomPrompt);
                
    string userWrite = Console.ReadLine();

    Entry entry = new Entry();

    entry._date = DateTime.Now;
    entry._promptText = randomPrompt;
    entry._entryText = userWrite;

    _entries.Add(entry);
  }
  public void DisplayAll()
  {
    foreach (Entry text in _entries)
    {
      Console.WriteLine($"{text._date}, Prompt: {text._promptText}, Entry: {text._entryText}");
    }
    
  }
  

  public void LoadFromFile()
  {
    Console.WriteLine("Reading List from file...");
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

        _entries.Add(newEntry);
    }
  }


  public void SaveToFile()
  {
    Console.Write("Filename: ");
    string userFileName = Console.ReadLine(); 
    string filename = userFileName + ".txt";

    using (StreamWriter outputFile = new StreamWriter(filename))
    {
        foreach (Entry write in _entries)
        {
            outputFile.WriteLine($"{write._date}, Prompt: {write._promptText}, Entry: {write._entryText}");
        }
    }
  }

}