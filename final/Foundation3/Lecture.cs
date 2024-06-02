class Lecture : Event
{
  public string _speaker;
  private int _capacity;

  public Lecture(string speaker, int capacity, string title, string description, string date, string time, Address address) : base(title, description, date, time, address) 
  {
    _speaker = speaker;
    _capacity = capacity;
  }

  public string Speaker
  {
    get { return _speaker; }
  }
  public int Capacity
  {
    get { return _capacity; }
  }

    public override string GetFullDetails()
    {
    return $"Type: Lecture\n {Title} - {Description}\n {Date} @ {Time}\n {Address.DisplayAddress()}\n Speaker: {_speaker}\n Capacity: {_capacity} ";
    }

    public override string GetShortDescription()
    {
      return $"Lecture - {Title} - {Date}";
    }
}