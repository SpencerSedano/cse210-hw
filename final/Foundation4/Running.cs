class Running : Activity
{
  private double _distance;

  public Running(double distance, string date, double minutes) : base(date, minutes)
  {
    _distance = distance;
  }

    public override string GetActivitySummary()
    {
    return $"{Date} Swimming ({Minutes} min) - Distance: {GetDistance()} km, Speed: {GetSpeed(90):f2} kph, Pace: {GetPace(90)} minutes per km";
    }
    public override double GetDistance()
    {
      return _distance * 50 / 1000;
    }

    public override double GetSpeed(double minutes)
    {
      return GetDistance() / minutes * 60;
    }

    public override double GetPace(double minutes)
    {
      return minutes / GetDistance();
    }

}