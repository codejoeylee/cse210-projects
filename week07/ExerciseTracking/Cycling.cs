namespace Exercise_Tracker;

public class Cycling : Activity
{
    protected double Speed { get; private set; }

    public Cycling(string date, int minutes, double speed) : base(date, minutes)
    {
        this.Speed = speed;
    }

    public override double GetDistance()
    {
        return (Speed * Minutes) / 60;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }

    public override string GetSummary()
    {
        return
            $"{base.GetSummary()} Cycling - Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min/mile";
    }
}