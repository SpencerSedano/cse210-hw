class PromptGenerator 
{
  public List<string> _prompts = new List<string>();
  
  public PromptGenerator() // Constructor
  /*It has the same name as the class, it's a special method in a class, can be used to assign arguments 
  directly when calling the new object.*/ 
  {
    _prompts.Add("What is the most exciting part of your day? ");
    _prompts.Add("What is something that you are grateful for? ");
    _prompts.Add("What can you do to make your day better? ");
    _prompts.Add("Is there somebody that I need to say thank you? Why?");
    _prompts.Add("How am I doing with my current goal?");
  }

  public string GetRandomPrompt()
  {
    if (_prompts.Count == 0)
    {
      return "No prompts available";
    }
    else 
    {
      Random rnd = new Random();
      return _prompts[rnd.Next(_prompts.Count)];
    }
  }
}