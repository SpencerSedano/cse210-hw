class Reception : Event
{
  private string _email;

  public Reception(string email, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
  {
    _email = email;    
  }

  public override string GetFullDetails()
  {
    return $"Type: Reception\n {Title} - {Description}\n {Date} @ {Time}\n {Address.DisplayAddress()}\n {_email} ";
  }

  public override string GetShortDescription()
  {
    return $"Reception - {Title} - {Date}";
  }

  
}