class Event
{
  private string _title;
  private string _description;
  private string _date;
  private string _time;
  private Address _address;

  public Event(string title, string description, string date, string time, Address address)
  {
    _title = title;
    _description = description;
    _date = date;
    _time = time;
    _address = address;
  }

  // Get Standard details string
  public string GetStandardDetails()
  {
    return $"{_title} - {_description}\n {_date} @ {_time}\n {_address.DisplayAddress()}";
  }

  // Get Full details string
  public virtual string GetFullDetails()
  {
    return "";
  }

  // Get Short description string
  public virtual string GetShortDescription()
  {
    return "";
  }













  // Getters and Setters
  public string Title
  {
    get { return _title; }
  }

  public string Description
  {
    get { return _description; }
  }

  public string Date
  {
    get { return _date; }
  }

  public string Time
  {
      get { return _time; }

  }

  public Address Address
  {
    get { return _address; }
  }
}