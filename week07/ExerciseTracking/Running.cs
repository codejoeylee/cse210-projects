namespace Exercise_Tracker;

public class Running : Activity
{
    protected double Distance{get; private set;}

    public Running(string date, int minutes, double distance)
        : base(date, minutes)
    {
        this.Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return (Distance / Minutes) * 60;
    }

    public override double GetPace()
    {
        return Minutes / Distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Running - Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min/mile";
    }
}