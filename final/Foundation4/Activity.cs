class Activity
{
  private string _date;
  private double _minutes;

  public Activity(string date, double minutes)
  {
    _date = date;
    _minutes = minutes;
  }

  // Get Activity Summary String
  public virtual string GetActivitySummary()
  {
    return "";
  }

  // Get Distance
  // Distance (km) = swimming laps * 50 / 1000
  public virtual double GetDistance()
  {
    return 0;
  }


  // Get Speed

  public virtual double GetSpeed(double minutes)
  {
    return 0;
  }

  // Get Pace

  public virtual double GetPace(double minutes)
  {
    return 0;
  }

  // Getters and Setters

  public string Date
  {
    get { return _date; }
  }
  public double Minutes
  {
    get { return _minutes; }
  }
}