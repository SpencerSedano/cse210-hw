class BreathingActivity : Activity
{

 public BreathingActivity(string name, string description, string duration) : base( name,  description,  duration)
 {
    
 }


 public void Run()
 {
      DisplayStartingMessage();
      Console.WriteLine("Get ready...");

      ShowSpinner();

      Console.WriteLine("");

      for (int i = int.Parse(_duration); i > 0; i -= 10)
      {
         Console.WriteLine("");

         Console.Write("Breathe in...");
         Console.Write(5);
         Thread.Sleep(1000);
         Console.Write("\b");
         Console.Write(4);
         Thread.Sleep(1000);
         Console.Write("\b");
         Console.Write(3);
         Thread.Sleep(1000);
         Console.Write("\b");
         Console.Write(2);
         Thread.Sleep(1000);
         Console.Write("\b");
         Console.Write(1);
         Thread.Sleep(1000);
         Console.Write("\b \b");

         Console.WriteLine("");

         Console.Write("Breathe out...");
         Console.Write(5);
         Thread.Sleep(1000);
         Console.Write("\b");
         Console.Write(4);
         Thread.Sleep(1000);
         Console.Write("\b");
         Console.Write(3);
         Thread.Sleep(1000);
         Console.Write("\b");
         Console.Write(2);
         Thread.Sleep(1000);
         Console.Write("\b");
         Console.Write(1);
         Thread.Sleep(1000);
         Console.Write("\b \b");

         Console.WriteLine("");
      }

      Console.WriteLine("");

      DisplayEndingMessage();
      
 } 

}