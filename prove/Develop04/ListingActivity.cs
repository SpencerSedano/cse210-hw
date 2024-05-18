class ListingActivity : Activity
{
  private int _count;
  private List<string> _prompts = new List<string>();


  public ListingActivity(string name, string description, string duration) : base(name, description, duration)
  {
    _prompts.Add("How has your faith in Jesus Christ influenced your daily decisions and actions?");
    _prompts.Add("How do you seek to strengthen your testimony on a regular basis?");
    _prompts.Add("How do you recognize and act on personal revelation in your life?");
    _prompts.Add("How has prayer helped you navigate challenges and trials in your life?");
    _prompts.Add("What experiences have you had that taught you the value of service?");
    _prompts.Add("What practices have you found effective in strengthening your faith and unity?");
  }

  public void Run()
  {
    DisplayStartingMessage();

    Console.Clear();

    Console.WriteLine("Get ready...");

    ShowSpinner();

    Console.WriteLine("List as many responses you can to the following prompt: ");

    GetRandomPrompt();

    Console.Write("You may being in: ");
    ShowCountDown(5);

    Console.WriteLine("");

    int durationParse = int.Parse(_duration);

    DateTime endTime = DateTime.Now.AddSeconds(durationParse);

    while (DateTime.Now < endTime)
    {
      Console.Write("> ");
      string response = Console.ReadLine();
      if (!string.IsNullOrEmpty(response))
      {
          _count++;
      }
    }

    DisplayEndingMessage();
  }

  public void GetRandomPrompt()
  {
    Random randomPrompt = new Random();

    int index = randomPrompt.Next(_prompts.Count);
    Console.WriteLine($"--- {_prompts[index]} ---");
  }

  public List<string> GetListFromUser()
  {
    return _prompts;
  }

}