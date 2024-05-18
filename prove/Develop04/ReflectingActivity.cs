
class ReflectingActivity : Activity
{
  private Dictionary<string, string> _promptAndQuestion = new Dictionary<string, string>();

  Random randomNumber = new Random();

  public ReflectingActivity(string name, string description, string duration) : base(name, description, duration)
  {
    _promptAndQuestion.Add("Recall a time when you faced a significant challenge.", "What was the challenge, and how did it manifest in your life?");
    _promptAndQuestion.Add("Consider the steps you took to address the challenge.", "What strategies or resources did you utilize to tackle the problem?");
    _promptAndQuestion.Add("Think about the lessons you learned from overcoming a difficulty.", "What insights did you gain about yourself and your abilities?");
    _promptAndQuestion.Add("Consider the impact of overcoming a challenge on your personal growth.", "In what ways did this experience contribute to your development and maturity?");
    _promptAndQuestion.Add("Think about how you celebrate your victories.", "Did you take time to recognize your achievements and reflect on your journey?");
    _promptAndQuestion.Add("Think about how you can apply the lessons learned from this experience in the future.", "What strategies or approaches will you carry forward from this experience?");
  }

  public void Run()
  {
    DisplayStartingMessage();

    Console.WriteLine("Get ready...");

    ShowSpinner();

    /*  foreach (string prompt in _promptAndQuestion.Keys)
     {
       Console.WriteLine(prompt);
       Console.WriteLine(_promptAndQuestion[prompt]);
     } */

    Console.WriteLine("Consider the following prompt: ");

    Console.WriteLine("");

    GetRandomPromptAndQuestion();

    DisplayEndingMessage();




  }

  public void GetRandomPromptAndQuestion()
  {
    // maybe do not add key

    var promptAndQuestion =  _promptAndQuestion.ElementAt(randomNumber.Next(0, _promptAndQuestion.Count));


    Console.WriteLine($"--- {promptAndQuestion.Key} ---");

    Console.WriteLine("");

     Console.WriteLine("When you have something in mid, press enter to continue.");

    Console.ReadLine();

    Console.WriteLine("");

    Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
    Console.Write("You may begin in: ");
    ShowCountDown(5);

    Console.WriteLine("");

    Console.Write(promptAndQuestion.Value);
    ShowSpinner();
    Console.ReadLine();

    Console.Write("How did you feel when it was complete? ");
    ShowSpinner();
    Console.ReadLine();

    Console.Write("What is your favorite thing about this experience? ");
    ShowSpinner();
    Console.ReadLine();


  }

  /* public string GetRandomQuestion()
  {
    string myQuestion = _promptAndQuestion.ElementAt(randomNumber.Next(0, _promptAndQuestion.Count)).Value;

    return myQuestion;
  } */

  /* public void DisplayPrompt()
  {
    Console.WriteLine($"--- {GetRandomPrompt()} ---");
  }

  public void DisplayQuestions()
  {
    Console.WriteLine($"--- {GetRandomQuestion()} ---");
  } */
}