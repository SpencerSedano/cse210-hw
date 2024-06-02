class Outdoor : Event
{
  private string _weather;

  public Outdoor(string weather, string title, string description, string date, string time, Address address) : base (title, description, date, time, address)
  {
    _weather = weather;
  }

    public override string GetFullDetails()
  {
    return $"Type: Outdoor\n {Title} - {Description}\n {Date} @ {Time}\n {Address.DisplayAddress()}\n Weather: {_weather}";
  }

  public override string GetShortDescription()
  {
    return $"Outdoor - {Title} - {Date}";
  }
}