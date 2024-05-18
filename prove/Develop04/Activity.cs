class Activity
{
  protected string _name;
  protected string _description;
  protected string _duration;

  public Activity(string name, string description, string duration)
  {
    _name = name;
    _description = description;
    _duration = duration;
  }

  public void DisplayStartingMessage()
  {
    Console.WriteLine($"Welcome to the {_name}");
    
    Console.WriteLine("");

    Console.WriteLine($"This activity will help you {_description}");

    Console.WriteLine("");

    Console.Write("How long, in seconds would you like for your session? ");
    _duration = Console.ReadLine();
  }

  public void DisplayEndingMessage()
  {
    Console.WriteLine("Well done!!");
    ShowSpinner();
    
    Console.WriteLine("");

    Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
    ShowSpinner();
  }

  public void ShowSpinner()
  {
    Console.Write("|");

    Thread.Sleep(500);
    Console.Write("\b");
    Console.Write("/");
    Thread.Sleep(500);
    Console.Write("\b");

    Console.Write("-");

    Thread.Sleep(500);
    Console.Write("\b");
    Console.Write("\\");
    Thread.Sleep(500);
    Console.Write("\b");

    Console.Write("|");

    Thread.Sleep(500);
    Console.Write("\b");
    Console.Write("/");
    Thread.Sleep(500);
    Console.Write("\b");

    Console.Write("-");

    Thread.Sleep(500);
    Console.Write("\b");
    Console.Write("\\");
    Thread.Sleep(500);
    Console.Write("\b");

    Console.Write("|");
    Thread.Sleep(500);
    Console.Write("\b \b");
  }

  public void ShowCountDown(int seconds)
  {
    for (int i = seconds; i > 0; i--)
    {
      Console.Write(i);
      Thread.Sleep(1000);
      Console.Write("\b \b");
    }
  }
}